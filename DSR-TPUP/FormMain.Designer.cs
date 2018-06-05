﻿namespace DSR_TPUP
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblGameDir = new System.Windows.Forms.Label();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.tmrCheckThread = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tpgUnpack = new System.Windows.Forms.TabPage();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnUnpackBrowse = new System.Windows.Forms.Button();
            this.txtUnpackDir = new System.Windows.Forms.TextBox();
            this.lblUnpackDir = new System.Windows.Forms.Label();
            this.tpgRepack = new System.Windows.Forms.TabPage();
            this.btnRepack = new System.Windows.Forms.Button();
            this.btnRepackBrowse = new System.Windows.Forms.Button();
            this.txtRepackDir = new System.Windows.Forms.TextBox();
            this.lblRepackDir = new System.Windows.Forms.Label();
            this.btnGameBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblUpdate = new System.Windows.Forms.Label();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.tclMain.SuspendLayout();
            this.tpgUnpack.SuspendLayout();
            this.tpgRepack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Location = new System.Drawing.Point(22, 9);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(80, 13);
            this.lblGameDir.TabIndex = 0;
            this.lblGameDir.Text = "Game Directory";
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(22, 25);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(627, 20);
            this.txtGameDir.TabIndex = 3;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED";
            // 
            // tmrCheckThread
            // 
            this.tmrCheckThread.Enabled = true;
            this.tmrCheckThread.Tick += new System.EventHandler(this.tmrCheckThread_Tick);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 188);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(728, 274);
            this.txtLog.TabIndex = 5;
            // 
            // tclMain
            // 
            this.tclMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tclMain.Controls.Add(this.tpgUnpack);
            this.tclMain.Controls.Add(this.tpgRepack);
            this.tclMain.Location = new System.Drawing.Point(12, 51);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(728, 102);
            this.tclMain.TabIndex = 6;
            // 
            // tpgUnpack
            // 
            this.tpgUnpack.Controls.Add(this.btnUnpack);
            this.tpgUnpack.Controls.Add(this.btnUnpackBrowse);
            this.tpgUnpack.Controls.Add(this.txtUnpackDir);
            this.tpgUnpack.Controls.Add(this.lblUnpackDir);
            this.tpgUnpack.Location = new System.Drawing.Point(4, 22);
            this.tpgUnpack.Name = "tpgUnpack";
            this.tpgUnpack.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUnpack.Size = new System.Drawing.Size(720, 76);
            this.tpgUnpack.TabIndex = 0;
            this.tpgUnpack.Text = "Unpack";
            this.tpgUnpack.UseVisualStyleBackColor = true;
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(639, 46);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 3;
            this.btnUnpack.Text = "Unpack";
            this.toolTip1.SetToolTip(this.btnUnpack, "Dump all of the game\'s textures to the specified directory");
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnUnpackBrowse
            // 
            this.btnUnpackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpackBrowse.Location = new System.Drawing.Point(639, 17);
            this.btnUnpackBrowse.Name = "btnUnpackBrowse";
            this.btnUnpackBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackBrowse.TabIndex = 2;
            this.btnUnpackBrowse.Text = "Browse";
            this.btnUnpackBrowse.UseVisualStyleBackColor = true;
            this.btnUnpackBrowse.Click += new System.EventHandler(this.btnUnpackBrowse_Click);
            // 
            // txtUnpackDir
            // 
            this.txtUnpackDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpackDir.Location = new System.Drawing.Point(6, 19);
            this.txtUnpackDir.Name = "txtUnpackDir";
            this.txtUnpackDir.Size = new System.Drawing.Size(627, 20);
            this.txtUnpackDir.TabIndex = 1;
            this.txtUnpackDir.Text = "Texture Dump";
            // 
            // lblUnpackDir
            // 
            this.lblUnpackDir.AutoSize = true;
            this.lblUnpackDir.Location = new System.Drawing.Point(6, 3);
            this.lblUnpackDir.Name = "lblUnpackDir";
            this.lblUnpackDir.Size = new System.Drawing.Size(84, 13);
            this.lblUnpackDir.TabIndex = 0;
            this.lblUnpackDir.Text = "Output Directory";
            // 
            // tpgRepack
            // 
            this.tpgRepack.Controls.Add(this.btnRepack);
            this.tpgRepack.Controls.Add(this.btnRepackBrowse);
            this.tpgRepack.Controls.Add(this.txtRepackDir);
            this.tpgRepack.Controls.Add(this.lblRepackDir);
            this.tpgRepack.Location = new System.Drawing.Point(4, 22);
            this.tpgRepack.Name = "tpgRepack";
            this.tpgRepack.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRepack.Size = new System.Drawing.Size(720, 76);
            this.tpgRepack.TabIndex = 1;
            this.tpgRepack.Text = "Repack";
            this.tpgRepack.UseVisualStyleBackColor = true;
            // 
            // btnRepack
            // 
            this.btnRepack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepack.Location = new System.Drawing.Point(639, 46);
            this.btnRepack.Name = "btnRepack";
            this.btnRepack.Size = new System.Drawing.Size(75, 23);
            this.btnRepack.TabIndex = 7;
            this.btnRepack.Text = "Repack";
            this.toolTip1.SetToolTip(this.btnRepack, "Repack any files with textures in the override directory");
            this.btnRepack.UseVisualStyleBackColor = true;
            this.btnRepack.Click += new System.EventHandler(this.btnRepack_Click);
            // 
            // btnRepackBrowse
            // 
            this.btnRepackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepackBrowse.Location = new System.Drawing.Point(639, 17);
            this.btnRepackBrowse.Name = "btnRepackBrowse";
            this.btnRepackBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnRepackBrowse.TabIndex = 6;
            this.btnRepackBrowse.Text = "Browse";
            this.btnRepackBrowse.UseVisualStyleBackColor = true;
            this.btnRepackBrowse.Click += new System.EventHandler(this.btnRepackBrowse_Click);
            // 
            // txtRepackDir
            // 
            this.txtRepackDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepackDir.Location = new System.Drawing.Point(6, 19);
            this.txtRepackDir.Name = "txtRepackDir";
            this.txtRepackDir.Size = new System.Drawing.Size(627, 20);
            this.txtRepackDir.TabIndex = 5;
            this.txtRepackDir.Text = "Texture Override";
            // 
            // lblRepackDir
            // 
            this.lblRepackDir.AutoSize = true;
            this.lblRepackDir.Location = new System.Drawing.Point(6, 3);
            this.lblRepackDir.Name = "lblRepackDir";
            this.lblRepackDir.Size = new System.Drawing.Size(92, 13);
            this.lblRepackDir.TabIndex = 4;
            this.lblRepackDir.Text = "Override Directory";
            // 
            // btnGameBrowse
            // 
            this.btnGameBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameBrowse.Location = new System.Drawing.Point(655, 23);
            this.btnGameBrowse.Name = "btnGameBrowse";
            this.btnGameBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnGameBrowse.TabIndex = 7;
            this.btnGameBrowse.Text = "Browse";
            this.btnGameBrowse.UseVisualStyleBackColor = true;
            this.btnGameBrowse.Click += new System.EventHandler(this.btnGameBrowse_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(655, 159);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore";
            this.toolTip1.SetToolTip(this.btnRestore, "Restore all backups in the game directory");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(574, 159);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 9;
            this.btnAbort.Text = "Abort";
            this.toolTip1.SetToolTip(this.btnAbort, "Stop the current operation");
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.Location = new System.Drawing.Point(277, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(453, 13);
            this.lblUpdate.TabIndex = 10;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbUpdate.Location = new System.Drawing.Point(280, 9);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(450, 13);
            this.llbUpdate.TabIndex = 11;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 474);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnGameBrowse);
            this.Controls.Add(this.tclMain);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(this.lblGameDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "DSR Texture Packer/Unpacker <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tclMain.ResumeLayout(false);
            this.tpgUnpack.ResumeLayout(false);
            this.tpgUnpack.PerformLayout();
            this.tpgRepack.ResumeLayout(false);
            this.tpgRepack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Timer tmrCheckThread;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tpgUnpack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnUnpackBrowse;
        private System.Windows.Forms.TextBox txtUnpackDir;
        private System.Windows.Forms.Label lblUnpackDir;
        private System.Windows.Forms.TabPage tpgRepack;
        private System.Windows.Forms.Button btnRepack;
        private System.Windows.Forms.Button btnRepackBrowse;
        private System.Windows.Forms.TextBox txtRepackDir;
        private System.Windows.Forms.Label lblRepackDir;
        private System.Windows.Forms.Button btnGameBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel llbUpdate;
    }
}

