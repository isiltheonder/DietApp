namespace DietApp
{
    partial class NewPassForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.gbRecovery = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRecover = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.msiThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDark = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLight = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLang = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEng = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTr = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msiContact = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRecovery.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(6, 51);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(222, 23);
            this.txtbEmail.TabIndex = 1;
            // 
            // txtbAnswer
            // 
            this.txtbAnswer.Location = new System.Drawing.Point(6, 117);
            this.txtbAnswer.Name = "txtbAnswer";
            this.txtbAnswer.Size = new System.Drawing.Size(222, 23);
            this.txtbAnswer.TabIndex = 2;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(6, 97);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(155, 17);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer of the Question";
            // 
            // gbRecovery
            // 
            this.gbRecovery.Controls.Add(this.btnCancel);
            this.gbRecovery.Controls.Add(this.btnRecover);
            this.gbRecovery.Controls.Add(this.lblOutput);
            this.gbRecovery.Controls.Add(this.lblEmail);
            this.gbRecovery.Controls.Add(this.txtbAnswer);
            this.gbRecovery.Controls.Add(this.lblAnswer);
            this.gbRecovery.Controls.Add(this.txtbEmail);
            this.gbRecovery.Location = new System.Drawing.Point(12, 27);
            this.gbRecovery.Name = "gbRecovery";
            this.gbRecovery.Size = new System.Drawing.Size(464, 231);
            this.gbRecovery.TabIndex = 4;
            this.gbRecovery.TabStop = false;
            this.gbRecovery.Text = "Recover Password";
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(238, 19);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(220, 206);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecover.Location = new System.Drawing.Point(129, 196);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(99, 29);
            this.btnRecover.TabIndex = 5;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSettings,
            this.msAbout});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(484, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "menuStrip1";
            // 
            // msSettings
            // 
            this.msSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiThemes,
            this.msiLang});
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(61, 20);
            this.msSettings.Text = "Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(9, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // msiThemes
            // 
            this.msiThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDark,
            this.msiLight});
            this.msiThemes.Name = "msiThemes";
            this.msiThemes.Size = new System.Drawing.Size(180, 22);
            this.msiThemes.Text = "Themes";
            // 
            // msiDark
            // 
            this.msiDark.Name = "msiDark";
            this.msiDark.Size = new System.Drawing.Size(180, 22);
            this.msiDark.Text = "Dark Mode";
            // 
            // msiLight
            // 
            this.msiLight.Name = "msiLight";
            this.msiLight.Size = new System.Drawing.Size(180, 22);
            this.msiLight.Text = "Light Mode";
            // 
            // msiLang
            // 
            this.msiLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiEng,
            this.msiTr});
            this.msiLang.Name = "msiLang";
            this.msiLang.Size = new System.Drawing.Size(180, 22);
            this.msiLang.Text = "Language";
            // 
            // msiEng
            // 
            this.msiEng.Name = "msiEng";
            this.msiEng.Size = new System.Drawing.Size(180, 22);
            this.msiEng.Text = "English";
            // 
            // msiTr
            // 
            this.msiTr.Name = "msiTr";
            this.msiTr.Size = new System.Drawing.Size(180, 22);
            this.msiTr.Text = "Turkish";
            // 
            // msAbout
            // 
            this.msAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiContact,
            this.msiLicence,
            this.msiAboutUs});
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(52, 20);
            this.msAbout.Text = "About";
            // 
            // msiContact
            // 
            this.msiContact.Name = "msiContact";
            this.msiContact.Size = new System.Drawing.Size(180, 22);
            this.msiContact.Text = "Contact";
            // 
            // msiLicence
            // 
            this.msiLicence.Name = "msiLicence";
            this.msiLicence.Size = new System.Drawing.Size(180, 22);
            this.msiLicence.Text = "Licence";
            // 
            // msiAboutUs
            // 
            this.msiAboutUs.Name = "msiAboutUs";
            this.msiAboutUs.Size = new System.Drawing.Size(180, 22);
            this.msiAboutUs.Text = "About Us";
            // 
            // NewPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 264);
            this.Controls.Add(this.gbRecovery);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewPassForm";
            this.Text = "Password Recovery";
            this.gbRecovery.ResumeLayout(false);
            this.gbRecovery.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.GroupBox gbRecovery;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.ToolStripMenuItem msiThemes;
        private System.Windows.Forms.ToolStripMenuItem msiDark;
        private System.Windows.Forms.ToolStripMenuItem msiLight;
        private System.Windows.Forms.ToolStripMenuItem msiLang;
        private System.Windows.Forms.ToolStripMenuItem msiEng;
        private System.Windows.Forms.ToolStripMenuItem msiTr;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
        private System.Windows.Forms.ToolStripMenuItem msiContact;
        private System.Windows.Forms.ToolStripMenuItem msiLicence;
        private System.Windows.Forms.ToolStripMenuItem msiAboutUs;
    }
}