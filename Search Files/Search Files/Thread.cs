using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Files
{
    class Thread
    {
        private TreeView tvNode = null;
        private string directory = string.Empty;
        private Regex reg = null;
        private char separator = '\\';
        private TextBox tbCurrentDirectory = null;
        private TextBox tbCountFoundFiles = null;
        private TextBox tbCountAllFiles = null;
        private Timer timer = null;
        private Button btnStop = null;
        private Button btnContinue = null;
        private Button btnPause = null;
        private bool isStoped = false;
        private bool isPause = false;
        private int counterFoundFiles = 0;
        private int counterAllFiles = 0;

        public Thread(TreeView _tvNode, string _directory, Regex _reg, TextBox _tbCurrentDirectory, 
            TextBox _tbCountFoundFiles, TextBox _tbCountAllFiles, Timer _timer, Button _btnStop, Button _btnContinue, Button _btnPause, char _separator = '\\')
        {
            tvNode = _tvNode;
            directory = _directory;
            reg = _reg;
            separator = _separator;
            tbCurrentDirectory = _tbCurrentDirectory;
            tbCountFoundFiles = _tbCountFoundFiles;
            tbCountAllFiles = _tbCountAllFiles;
            timer = _timer;
            btnStop = _btnStop;
            btnContinue = _btnContinue;
            btnPause = _btnPause;
        }
        public void getFiles()
        {
            btnStop.Click += btnStop_Click;
            btnContinue.Click += btnContinue_Click;
            btnPause.Click += btnPause_Click;
            var files = Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories);
            TreeNode node = null;
            
            foreach (string pathToFile in files)
            {
                counterAllFiles++;

                if (reg.IsMatch(pathToFile))
                {

                    if (isStoped)
                        break;

                    counterFoundFiles++;

                    foreach (string subPath in pathToFile.Split(separator))
                    {
                        if (isStoped)
                            break;

                        string key = string.Concat(subPath, separator);

                        TreeNode[] nodes = tvNode.Nodes.Find(key, true);

                        if (nodes.Length == 0)
                            if (node == null)
                                tvNode.Invoke(new Action(() =>
                                {
                                    node = tvNode.Nodes.Add(key, subPath);
                                }));
                            else
                                tvNode.Invoke(new Action(() =>
                                {
                                    node = node.Nodes.Add(key, subPath);
                                }));
                        else
                            node = nodes[0];

                        while (isPause)
                        {
                            if (isStoped)
                                break;
                            timer.Stop();
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }

                getStatus(pathToFile, counterFoundFiles, counterAllFiles);
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            isPause = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isStoped = true;
        }

        private void getStatus(string currentDirectory, int countFoundFiles, int countAllFiles)
        {
            tbCurrentDirectory.Invoke(new Action(() =>
            {
                tbCurrentDirectory.Text = currentDirectory;
            }));

            tbCountFoundFiles.Invoke(new Action(() =>
            {
                tbCountFoundFiles.Text = countFoundFiles.ToString();
            }));

            tbCountAllFiles.Invoke(new Action(() =>
            {
                tbCountAllFiles.Text = countAllFiles.ToString();
            }));
        }

    }
}
