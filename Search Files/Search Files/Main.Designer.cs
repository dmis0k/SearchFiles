namespace Search_Files
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvFoundFiles = new System.Windows.Forms.TreeView();
            this.btnStartDirectory = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbStartDirectory = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.fbdStartDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.tbCurrentDirectory = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblTimeSearch = new System.Windows.Forms.Label();
            this.lblTextTimeSearch = new System.Windows.Forms.Label();
            this.tbCountAllFiles = new System.Windows.Forms.TextBox();
            this.tbCountFoundFiles = new System.Windows.Forms.TextBox();
            this.lblCountAllFiles = new System.Windows.Forms.Label();
            this.lblCountFoundFiles = new System.Windows.Forms.Label();
            this.lblCurrentDir = new System.Windows.Forms.Label();
            this.pnlTree = new System.Windows.Forms.Panel();
            this.tmrSearch = new System.Windows.Forms.Timer(this.components);
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvFoundFiles
            // 
            this.tvFoundFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFoundFiles.Location = new System.Drawing.Point(10, 9);
            this.tvFoundFiles.Name = "tvFoundFiles";
            this.tvFoundFiles.Size = new System.Drawing.Size(340, 437);
            this.tvFoundFiles.TabIndex = 0;
            // 
            // btnStartDirectory
            // 
            this.btnStartDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDirectory.Location = new System.Drawing.Point(3, 29);
            this.btnStartDirectory.Name = "btnStartDirectory";
            this.btnStartDirectory.Size = new System.Drawing.Size(345, 23);
            this.btnStartDirectory.TabIndex = 1;
            this.btnStartDirectory.Text = "Задать стартовую директорию";
            this.btnStartDirectory.UseVisualStyleBackColor = true;
            this.btnStartDirectory.Click += new System.EventHandler(this.btnStartDirectory_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(3, 84);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(345, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(3, 169);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(345, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbStartDirectory
            // 
            this.tbStartDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStartDirectory.Location = new System.Drawing.Point(3, 3);
            this.tbStartDirectory.Name = "tbStartDirectory";
            this.tbStartDirectory.ReadOnly = true;
            this.tbStartDirectory.Size = new System.Drawing.Size(348, 20);
            this.tbStartDirectory.TabIndex = 4;
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Location = new System.Drawing.Point(3, 58);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(345, 20);
            this.tbFileName.TabIndex = 5;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.Controls.Add(this.btnPause);
            this.pnlButtons.Controls.Add(this.btnContinue);
            this.pnlButtons.Controls.Add(this.tbStartDirectory);
            this.pnlButtons.Controls.Add(this.btnStop);
            this.pnlButtons.Controls.Add(this.tbFileName);
            this.pnlButtons.Controls.Add(this.btnStart);
            this.pnlButtons.Controls.Add(this.btnStartDirectory);
            this.pnlButtons.Location = new System.Drawing.Point(370, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(354, 195);
            this.pnlButtons.TabIndex = 6;
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // tbCurrentDirectory
            // 
            this.tbCurrentDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentDirectory.Location = new System.Drawing.Point(3, 38);
            this.tbCurrentDirectory.Name = "tbCurrentDirectory";
            this.tbCurrentDirectory.ReadOnly = true;
            this.tbCurrentDirectory.Size = new System.Drawing.Size(345, 20);
            this.tbCurrentDirectory.TabIndex = 7;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.Controls.Add(this.lblTimeSearch);
            this.pnlStatus.Controls.Add(this.lblTextTimeSearch);
            this.pnlStatus.Controls.Add(this.tbCountAllFiles);
            this.pnlStatus.Controls.Add(this.tbCountFoundFiles);
            this.pnlStatus.Controls.Add(this.lblCountAllFiles);
            this.pnlStatus.Controls.Add(this.lblCountFoundFiles);
            this.pnlStatus.Controls.Add(this.lblCurrentDir);
            this.pnlStatus.Controls.Add(this.tbCurrentDirectory);
            this.pnlStatus.Location = new System.Drawing.Point(370, 201);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(351, 260);
            this.pnlStatus.TabIndex = 8;
            // 
            // lblTimeSearch
            // 
            this.lblTimeSearch.AutoSize = true;
            this.lblTimeSearch.Location = new System.Drawing.Point(94, 124);
            this.lblTimeSearch.Name = "lblTimeSearch";
            this.lblTimeSearch.Size = new System.Drawing.Size(10, 13);
            this.lblTimeSearch.TabIndex = 14;
            this.lblTimeSearch.Text = " ";
            // 
            // lblTextTimeSearch
            // 
            this.lblTextTimeSearch.AutoSize = true;
            this.lblTextTimeSearch.Location = new System.Drawing.Point(3, 124);
            this.lblTextTimeSearch.Name = "lblTextTimeSearch";
            this.lblTextTimeSearch.Size = new System.Drawing.Size(85, 13);
            this.lblTextTimeSearch.TabIndex = 13;
            this.lblTextTimeSearch.Text = "Время поиска: ";
            // 
            // tbCountAllFiles
            // 
            this.tbCountAllFiles.Location = new System.Drawing.Point(240, 70);
            this.tbCountAllFiles.Name = "tbCountAllFiles";
            this.tbCountAllFiles.ReadOnly = true;
            this.tbCountAllFiles.Size = new System.Drawing.Size(43, 20);
            this.tbCountAllFiles.TabIndex = 12;
            // 
            // tbCountFoundFiles
            // 
            this.tbCountFoundFiles.Location = new System.Drawing.Point(104, 70);
            this.tbCountFoundFiles.Name = "tbCountFoundFiles";
            this.tbCountFoundFiles.ReadOnly = true;
            this.tbCountFoundFiles.Size = new System.Drawing.Size(43, 20);
            this.tbCountFoundFiles.TabIndex = 11;
            // 
            // lblCountAllFiles
            // 
            this.lblCountAllFiles.AutoSize = true;
            this.lblCountAllFiles.Location = new System.Drawing.Point(153, 73);
            this.lblCountAllFiles.Name = "lblCountAllFiles";
            this.lblCountAllFiles.Size = new System.Drawing.Size(81, 13);
            this.lblCountAllFiles.TabIndex = 10;
            this.lblCountAllFiles.Text = "Всего файлов:";
            // 
            // lblCountFoundFiles
            // 
            this.lblCountFoundFiles.AutoSize = true;
            this.lblCountFoundFiles.Location = new System.Drawing.Point(3, 73);
            this.lblCountFoundFiles.Name = "lblCountFoundFiles";
            this.lblCountFoundFiles.Size = new System.Drawing.Size(95, 13);
            this.lblCountFoundFiles.TabIndex = 9;
            this.lblCountFoundFiles.Text = "Найдено файлов:";
            // 
            // lblCurrentDir
            // 
            this.lblCurrentDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDir.AutoSize = true;
            this.lblCurrentDir.Location = new System.Drawing.Point(3, 22);
            this.lblCurrentDir.Name = "lblCurrentDir";
            this.lblCurrentDir.Size = new System.Drawing.Size(117, 13);
            this.lblCurrentDir.TabIndex = 8;
            this.lblCurrentDir.Text = "Текущая директория:";
            // 
            // pnlTree
            // 
            this.pnlTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTree.Controls.Add(this.tvFoundFiles);
            this.pnlTree.Location = new System.Drawing.Point(2, 3);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(362, 455);
            this.pnlTree.TabIndex = 13;
            // 
            // tmrSearch
            // 
            this.tmrSearch.Interval = 1000;
            this.tmrSearch.Tick += new System.EventHandler(this.tmrSearch_Tick);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(3, 113);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(345, 23);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(3, 142);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(345, 23);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.pnlTree);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlButtons);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvFoundFiles;
        private System.Windows.Forms.Button btnStartDirectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbStartDirectory;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FolderBrowserDialog fbdStartDirectory;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.TextBox tbCurrentDirectory;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.TextBox tbCountAllFiles;
        private System.Windows.Forms.TextBox tbCountFoundFiles;
        private System.Windows.Forms.Label lblCountAllFiles;
        private System.Windows.Forms.Label lblCountFoundFiles;
        private System.Windows.Forms.Label lblCurrentDir;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.Timer tmrSearch;
        private System.Windows.Forms.Label lblTimeSearch;
        private System.Windows.Forms.Label lblTextTimeSearch;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnPause;
    }
}

