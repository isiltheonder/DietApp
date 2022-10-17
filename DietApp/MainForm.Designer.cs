namespace DietApp
{
    partial class MainForm
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
            this.msMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.msiReport = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.msSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLang = new System.Windows.Forms.ToolStripMenuItem();
            this.msiEng = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTr = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDiet = new System.Windows.Forms.GroupBox();
            this.btnDeleteDiet = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pbFoodPic = new System.Windows.Forms.PictureBox();
            this.lblFoodPic = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbMeal = new System.Windows.Forms.ComboBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblDietList = new System.Windows.Forms.Label();
            this.dgvDietList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.gbDiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenus,
            this.msSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMenus
            // 
            this.msMenus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiReport,
            this.msiLogOut});
            this.msMenus.Name = "msMenus";
            this.msMenus.Size = new System.Drawing.Size(55, 20);
            this.msMenus.Text = "Menus";
            // 
            // msiReport
            // 
            this.msiReport.Name = "msiReport";
            this.msiReport.Size = new System.Drawing.Size(180, 22);
            this.msiReport.Text = "Daily Report";
            // 
            // msiLogOut
            // 
            this.msiLogOut.Name = "msiLogOut";
            this.msiLogOut.Size = new System.Drawing.Size(180, 22);
            this.msiLogOut.Text = "Logout";
            this.msiLogOut.Click += new System.EventHandler(this.msiLogOut_Click);
            // 
            // msSettings
            // 
            this.msSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiLang});
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(61, 20);
            this.msSettings.Text = "Settings";
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
            this.msiEng.Click += new System.EventHandler(this.msiEng_Click);
            // 
            // msiTr
            // 
            this.msiTr.Name = "msiTr";
            this.msiTr.Size = new System.Drawing.Size(180, 22);
            this.msiTr.Text = "Turkish";
            this.msiTr.Click += new System.EventHandler(this.msiTr_Click);
            // 
            // gbDiet
            // 
            this.gbDiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDiet.BackgroundImage = global::DietApp.Properties.Resources.soluk1;
            this.gbDiet.Controls.Add(this.btnDeleteDiet);
            this.gbDiet.Controls.Add(this.dtpDate);
            this.gbDiet.Controls.Add(this.lblDate);
            this.gbDiet.Controls.Add(this.pbFoodPic);
            this.gbDiet.Controls.Add(this.lblFoodPic);
            this.gbDiet.Controls.Add(this.nudAmount);
            this.gbDiet.Controls.Add(this.btnAddDiet);
            this.gbDiet.Controls.Add(this.cbFood);
            this.gbDiet.Controls.Add(this.cbMeal);
            this.gbDiet.Controls.Add(this.lblFood);
            this.gbDiet.Controls.Add(this.label1);
            this.gbDiet.Controls.Add(this.lblAmount);
            this.gbDiet.Controls.Add(this.lblMeal);
            this.gbDiet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDiet.Location = new System.Drawing.Point(13, 28);
            this.gbDiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbDiet.MinimumSize = new System.Drawing.Size(265, 387);
            this.gbDiet.Name = "gbDiet";
            this.gbDiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbDiet.Size = new System.Drawing.Size(265, 409);
            this.gbDiet.TabIndex = 1;
            this.gbDiet.TabStop = false;
            this.gbDiet.Text = "Diet";
            // 
            // btnDeleteDiet
            // 
            this.btnDeleteDiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDiet.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteDiet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDiet.Location = new System.Drawing.Point(162, 288);
            this.btnDeleteDiet.Name = "btnDeleteDiet";
            this.btnDeleteDiet.Size = new System.Drawing.Size(96, 35);
            this.btnDeleteDiet.TabIndex = 8;
            this.btnDeleteDiet.Text = "Delete Diet";
            this.btnDeleteDiet.UseVisualStyleBackColor = false;
            this.btnDeleteDiet.Click += new System.EventHandler(this.btnDeleteDiet_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(149, 173);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(108, 25);
            this.dtpDate.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightCoral;
            this.lblDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(146, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 18);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // pbFoodPic
            // 
            this.pbFoodPic.BackColor = System.Drawing.Color.Transparent;
            this.pbFoodPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoodPic.Location = new System.Drawing.Point(8, 236);
            this.pbFoodPic.Name = "pbFoodPic";
            this.pbFoodPic.Size = new System.Drawing.Size(148, 147);
            this.pbFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodPic.TabIndex = 6;
            this.pbFoodPic.TabStop = false;
            // 
            // lblFoodPic
            // 
            this.lblFoodPic.AutoSize = true;
            this.lblFoodPic.BackColor = System.Drawing.Color.LightCoral;
            this.lblFoodPic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFoodPic.Location = new System.Drawing.Point(7, 209);
            this.lblFoodPic.Name = "lblFoodPic";
            this.lblFoodPic.Size = new System.Drawing.Size(44, 18);
            this.lblFoodPic.TabIndex = 5;
            this.lblFoodPic.Text = "Food";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(8, 171);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(76, 25);
            this.nudAmount.TabIndex = 3;
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDiet.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddDiet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDiet.Location = new System.Drawing.Point(162, 348);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(96, 35);
            this.btnAddDiet.TabIndex = 6;
            this.btnAddDiet.Text = "Add Diet";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.btnAddDiet_Click);
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(7, 114);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(250, 25);
            this.cbFood.TabIndex = 2;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbMeal
            // 
            this.cbMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeal.FormattingEnabled = true;
            this.cbMeal.Location = new System.Drawing.Point(8, 52);
            this.cbMeal.Name = "cbMeal";
            this.cbMeal.Size = new System.Drawing.Size(250, 25);
            this.cbMeal.TabIndex = 1;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.LightCoral;
            this.lblFood.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFood.Location = new System.Drawing.Point(5, 94);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(44, 18);
            this.lblFood.TabIndex = 0;
            this.lblFood.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "/ g";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.LightCoral;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(7, 150);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 18);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.BackColor = System.Drawing.Color.LightCoral;
            this.lblMeal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeal.Location = new System.Drawing.Point(7, 32);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(42, 18);
            this.lblMeal.TabIndex = 0;
            this.lblMeal.Text = "Meal";
            // 
            // lblDietList
            // 
            this.lblDietList.AutoSize = true;
            this.lblDietList.BackColor = System.Drawing.Color.LightCoral;
            this.lblDietList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDietList.Location = new System.Drawing.Point(286, 28);
            this.lblDietList.Name = "lblDietList";
            this.lblDietList.Size = new System.Drawing.Size(67, 18);
            this.lblDietList.TabIndex = 2;
            this.lblDietList.Text = "Diet List";
            // 
            // dgvDietList
            // 
            this.dgvDietList.AllowUserToAddRows = false;
            this.dgvDietList.AllowUserToDeleteRows = false;
            this.dgvDietList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDietList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDietList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDietList.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvDietList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDietList.Location = new System.Drawing.Point(289, 48);
            this.dgvDietList.MultiSelect = false;
            this.dgvDietList.Name = "dgvDietList";
            this.dgvDietList.ReadOnly = true;
            this.dgvDietList.RowHeadersVisible = false;
            this.dgvDietList.RowHeadersWidth = 62;
            this.dgvDietList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDietList.Size = new System.Drawing.Size(416, 389);
            this.dgvDietList.TabIndex = 5;
            this.dgvDietList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDietList_UserDeletingRow);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DietApp.Properties.Resources.soluk1;
            this.ClientSize = new System.Drawing.Size(719, 440);
            this.Controls.Add(this.dgvDietList);
            this.Controls.Add(this.lblDietList);
            this.Controls.Add(this.gbDiet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(651, 280);
            this.Name = "MainForm";
            this.Text = "Diet App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbDiet.ResumeLayout(false);
            this.gbDiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDietList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMenus;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.GroupBox gbDiet;
        private System.Windows.Forms.ComboBox cbMeal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnAddDiet;
        private System.Windows.Forms.Label lblDietList;
        private System.Windows.Forms.DataGridView dgvDietList;
        private System.Windows.Forms.ToolStripMenuItem msiReport;
        private System.Windows.Forms.ToolStripMenuItem msiLang;
        private System.Windows.Forms.ToolStripMenuItem msiEng;
        private System.Windows.Forms.ToolStripMenuItem msiTr;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoodPic;
        private System.Windows.Forms.Label lblFoodPic;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem msiLogOut;
        private System.Windows.Forms.Button btnDeleteDiet;
    }
}