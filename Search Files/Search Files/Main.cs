using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Search_Files
{
    public partial class MainForm : Form
    {
        private DateTime t1, t2;
        private TimeSpan ts, ts_temp;
        private Thread thread;
        private bool isStoped = false;
        private string startDirectory = "C:\\";
        private string regex = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            getParams();
        }

        private void btnStartDirectory_Click(object sender, EventArgs e)
        {
            if (fbdStartDirectory.ShowDialog() == DialogResult.OK)
                tbStartDirectory.Text = fbdStartDirectory.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startDirectory = tbStartDirectory.Text;
            regex = tbFileName.Text;
            tvFoundFiles.Nodes.Clear();
            bw.RunWorkerAsync();
            tmrSearch.Interval = 1000;
            t1 = DateTime.Now;
            tmrSearch.Start();

            btnStartDirectory.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
            btnStart.Enabled = false;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            if (tbStartDirectory.Text != string.Empty && tbFileName.Text != string.Empty)
            {
                btnStart.Invoke(new Action(() =>
                {
                    btnStop.Enabled = true;
                }));
                try
                {
                    Thread thread = new Thread(tvFoundFiles, tbStartDirectory.Text, new Regex(tbFileName.Text), tbCurrentDirectory, tbCountFoundFiles, tbCountAllFiles, tmrSearch, btnStop, btnContinue, btnPause);
                    thread.getFiles();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Не удалось запустить поиск файлов!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Один из параметров поиска не задан либо задан неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Invoke(new Action(() =>
            {
                btnStart.Enabled = true;
            }));

            btnStop.Invoke(new Action(() =>
            {
                btnStop.Enabled = false;
                btnContinue.Enabled = false;
            }));

            btnContinue.Invoke(new Action(() =>
            {
                btnContinue.Enabled = false;
            }));

            btnPause.Invoke(new Action(() =>
            {
                btnPause.Enabled = false;
            }));

            btnStartDirectory.Invoke(new Action(() =>
            {
                btnStartDirectory.Enabled = true;
            }));

            tmrSearch.Stop();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStartDirectory.Enabled = true;
            btnStart.Enabled = true;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            t1 = DateTime.Now;
            tmrSearch.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
        }

        private void tmrSearch_Tick(object sender, EventArgs e)
        {
            t2 = DateTime.Now;
            ts = t2 - t1 + ts_temp;
            lblTimeSearch.Text = String.Format("{0:00}:{1:00}:{2:00}",ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            save(startDirectory, regex);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ts_temp = ts;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnContinue.Enabled = true;
            btnPause.Enabled = false;
        }

        private void save(string filename, string regex)
        {
            Properties.Settings.Default.startDirectory = filename;
            Properties.Settings.Default.regex = regex;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        { 
            tbFileName.Text = regex;
            tbStartDirectory.Text = startDirectory;
        }

        private void getParams()
        {
            startDirectory = Properties.Settings.Default.startDirectory;
            regex = Properties.Settings.Default.regex;
        }
    }
}
