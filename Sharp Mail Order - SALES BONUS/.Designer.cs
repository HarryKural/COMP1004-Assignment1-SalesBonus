namespace Sharp_Mail_Order___SALES_BONUS
{
    partial class SalesBonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.FrançaisRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 381);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(84, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Tag = "Calculate";
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(193, 381);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(84, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Tag = "Print";
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(337, 381);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(84, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Tag = "Clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.buttonClickHandler);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(16, 165);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(171, 20);
            this.EmployeeNameLabel.TabIndex = 8;
            this.EmployeeNameLabel.Text = "Employee\'s Name";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(16, 207);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(214, 20);
            this.EmployeeIDLabel.TabIndex = 9;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(16, 247);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(220, 20);
            this.HoursWorkedLabel.TabIndex = 10;
            this.HoursWorkedLabel.Text = "Hours Worked:";
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(16, 291);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(220, 20);
            this.TotalMonthlySalesLabel.TabIndex = 11;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(16, 332);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(216, 20);
            this.SalesBonusLabel.TabIndex = 12;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(193, 167);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.EmployeeNameTextBox.TabIndex = 13;
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(238, 207);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(149, 20);
            this.EmployeeIDTextBox.TabIndex = 14;
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(238, 247);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(149, 20);
            this.HoursWorkedTextBox.TabIndex = 15;
            this.HoursWorkedTextBox.Tag = "hoursWorked";
            this.HoursWorkedTextBox.TextChanged += new System.EventHandler(this.validValuesChecker);
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(241, 291);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(146, 20);
            this.TotalMonthlySalesTextBox.TabIndex = 16;
            this.TotalMonthlySalesTextBox.Tag = "monthlySales";
            this.TotalMonthlySalesTextBox.TextChanged += new System.EventHandler(this.validValuesChecker);
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(238, 332);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(149, 20);
            this.SalesBonusTextBox.TabIndex = 17;
            this.SalesBonusTextBox.TabStop = false;
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.FrançaisRadioButton);
            this.LanguageGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguageGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageGroupBox.Location = new System.Drawing.Point(241, 47);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(146, 88);
            this.LanguageGroupBox.TabIndex = 18;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "Language";
            // 
            // FrançaisRadioButton
            // 
            this.FrançaisRadioButton.AutoSize = true;
            this.FrançaisRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrançaisRadioButton.Location = new System.Drawing.Point(6, 52);
            this.FrançaisRadioButton.Name = "FrançaisRadioButton";
            this.FrançaisRadioButton.Size = new System.Drawing.Size(78, 20);
            this.FrançaisRadioButton.TabIndex = 9;
            this.FrançaisRadioButton.TabStop = true;
            this.FrançaisRadioButton.Text = "Français";
            this.FrançaisRadioButton.UseVisualStyleBackColor = true;
            this.FrançaisRadioButton.CheckedChanged += new System.EventHandler(this.languageChanger);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 25);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(70, 20);
            this.EnglishRadioButton.TabIndex = 8;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.languageChanger);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(49, 33);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(99, 102);
            this.Logo.TabIndex = 19;
            this.Logo.TabStop = false;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.HoursWorkedTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.HoursWorkedLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton FrançaisRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox Logo;
    }
}

