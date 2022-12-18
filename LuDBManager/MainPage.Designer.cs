namespace LuDBManager
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDatabase_ConnectDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDatabase_CloseConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuDatabase_SaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuDatabase_OpenKeystore = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDatabase_OpenImageFile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label_Loading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitter2 = new System.Windows.Forms.Panel();
            this.splitter = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Label_ConnectionStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDatabase_ConnectDatabase,
            this.MenuDatabase_CloseConnection,
            this.toolStripSeparator1,
            this.MenuDatabase_SaveDatabase,
            this.toolStripSeparator2,
            this.MenuDatabase_OpenKeystore,
            this.MenuDatabase_OpenImageFile});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // MenuDatabase_ConnectDatabase
            // 
            this.MenuDatabase_ConnectDatabase.Name = "MenuDatabase_ConnectDatabase";
            this.MenuDatabase_ConnectDatabase.Size = new System.Drawing.Size(288, 22);
            this.MenuDatabase_ConnectDatabase.Text = "Connect to database";
            this.MenuDatabase_ConnectDatabase.Click += new System.EventHandler(this.Event_ConnectDatabase);
            // 
            // MenuDatabase_CloseConnection
            // 
            this.MenuDatabase_CloseConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MenuDatabase_CloseConnection.Enabled = false;
            this.MenuDatabase_CloseConnection.Name = "MenuDatabase_CloseConnection";
            this.MenuDatabase_CloseConnection.Size = new System.Drawing.Size(288, 22);
            this.MenuDatabase_CloseConnection.Text = "Close connection";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // MenuDatabase_SaveDatabase
            // 
            this.MenuDatabase_SaveDatabase.Enabled = false;
            this.MenuDatabase_SaveDatabase.Name = "MenuDatabase_SaveDatabase";
            this.MenuDatabase_SaveDatabase.Size = new System.Drawing.Size(288, 22);
            this.MenuDatabase_SaveDatabase.Text = "Save database";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // MenuDatabase_OpenKeystore
            // 
            this.MenuDatabase_OpenKeystore.Enabled = false;
            this.MenuDatabase_OpenKeystore.Name = "MenuDatabase_OpenKeystore";
            this.MenuDatabase_OpenKeystore.Size = new System.Drawing.Size(288, 22);
            this.MenuDatabase_OpenKeystore.Text = "Open keystore file in notepad.exe";
            // 
            // MenuDatabase_OpenImageFile
            // 
            this.MenuDatabase_OpenImageFile.Enabled = false;
            this.MenuDatabase_OpenImageFile.Name = "MenuDatabase_OpenImageFile";
            this.MenuDatabase_OpenImageFile.Size = new System.Drawing.Size(288, 22);
            this.MenuDatabase_OpenImageFile.Text = "Open database image file in notepad.exe";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Label_Loading);
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.splitter);
            this.splitContainer1.Panel1.Controls.Add(this.Button_Close);
            this.splitContainer1.Panel1.Controls.Add(this.Button_Connect);
            this.splitContainer1.Panel1.Controls.Add(this.Label_ConnectionStatus);
            this.splitContainer1.Size = new System.Drawing.Size(684, 362);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 1;
            // 
            // Label_Loading
            // 
            this.Label_Loading.AutoSize = true;
            this.Label_Loading.Location = new System.Drawing.Point(11, 88);
            this.Label_Loading.Name = "Label_Loading";
            this.Label_Loading.Size = new System.Drawing.Size(43, 13);
            this.Label_Loading.TabIndex = 6;
            this.Label_Loading.Text = "Waiting";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(63, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Location = new System.Drawing.Point(14, 115);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(197, 1);
            this.splitter2.TabIndex = 5;
            // 
            // splitter
            // 
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Location = new System.Drawing.Point(14, 72);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(197, 1);
            this.splitter.TabIndex = 3;
            // 
            // Button_Close
            // 
            this.Button_Close.Enabled = false;
            this.Button_Close.Location = new System.Drawing.Point(136, 42);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(55, 42);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 23);
            this.Button_Connect.TabIndex = 1;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Event_ConnectDatabase);
            // 
            // Label_ConnectionStatus
            // 
            this.Label_ConnectionStatus.AutoSize = true;
            this.Label_ConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_ConnectionStatus.Location = new System.Drawing.Point(11, 9);
            this.Label_ConnectionStatus.Name = "Label_ConnectionStatus";
            this.Label_ConnectionStatus.Size = new System.Drawing.Size(118, 18);
            this.Label_ConnectionStatus.TabIndex = 0;
            this.Label_ConnectionStatus.Text = "No connection";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "LuDB Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuDatabase_ConnectDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuDatabase_CloseConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuDatabase_SaveDatabase;
        private System.Windows.Forms.ToolStripMenuItem MenuDatabase_OpenKeystore;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Label_ConnectionStatus;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuDatabase_OpenImageFile;
        private System.Windows.Forms.Panel splitter;
        private System.Windows.Forms.Panel splitter2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Label_Loading;
    }
}

