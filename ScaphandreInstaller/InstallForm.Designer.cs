﻿namespace ScaphandreInstaller
{
    partial class InstallForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.installTextBox = new System.Windows.Forms.TextBox();
            this.installButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.createModdingArchive = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(272, 157);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(122, 29);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Browse folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // installTextBox
            // 
            this.installTextBox.Location = new System.Drawing.Point(12, 129);
            this.installTextBox.Name = "installTextBox";
            this.installTextBox.Size = new System.Drawing.Size(382, 22);
            this.installTextBox.TabIndex = 1;
            this.installTextBox.TextChanged += new System.EventHandler(this.installTextBox_TextChanged);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(12, 157);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(110, 64);
            this.installButton.TabIndex = 2;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(12, 86);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(382, 17);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "%VERSION%";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(284, 192);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(110, 29);
            this.uninstallButton.TabIndex = 3;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // createModdingArchive
            // 
            this.createModdingArchive.AutoSize = true;
            this.createModdingArchive.Location = new System.Drawing.Point(15, 227);
            this.createModdingArchive.Name = "createModdingArchive";
            this.createModdingArchive.Size = new System.Drawing.Size(286, 21);
            this.createModdingArchive.TabIndex = 6;
            this.createModdingArchive.Text = "Create Scaphandre Modding API archive";
            this.createModdingArchive.UseVisualStyleBackColor = true;
            this.createModdingArchive.CheckedChanged += new System.EventHandler(this.createModdingArchive_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(12, 103);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(382, 22);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "%ERROR%";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScaphandreInstaller.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // InstallForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(406, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.createModdingArchive);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.uninstallButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.installTextBox);
            this.Controls.Add(this.selectFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InstallForm";
            this.Text = "Scaphandre Engine Installer";
            this.Load += new System.EventHandler(this.InstallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox installTextBox;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.CheckBox createModdingArchive;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

