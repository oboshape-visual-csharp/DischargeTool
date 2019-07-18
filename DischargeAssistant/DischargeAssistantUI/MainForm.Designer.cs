namespace DischargeAssistant
{
    partial class DischargeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DischargeMainForm));
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.loadBankDropDown = new System.Windows.Forms.ComboBox();
            this.SelectLoadbankLabel = new System.Windows.Forms.Label();
            this.editLoadbanksButton = new System.Windows.Forms.Button();
            this.etvTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stringBuilderButton = new System.Windows.Forms.Button();
            this.showAchievableButton = new System.Windows.Forms.Button();
            this.extraInfoLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.NewLoadbankButton = new System.Windows.Forms.Button();
            this.minVoltsSuffixLabel = new System.Windows.Forms.Label();
            this.ClearStringDataButton = new System.Windows.Forms.Button();
            this.LoadRateTextbox = new System.Windows.Forms.TextBox();
            this.loadRateLabel = new System.Windows.Forms.Label();
            this.LoadRateSuffixLabel = new System.Windows.Forms.Label();
            this.OutputResultsLabel = new System.Windows.Forms.Label();
            this.InfoPic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainTitleLabel.Location = new System.Drawing.Point(79, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(263, 40);
            this.MainTitleLabel.TabIndex = 0;
            this.MainTitleLabel.Text = "Loadbank Assistant";
            // 
            // loadBankDropDown
            // 
            this.loadBankDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBankDropDown.FormattingEnabled = true;
            this.loadBankDropDown.Location = new System.Drawing.Point(12, 88);
            this.loadBankDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadBankDropDown.Name = "loadBankDropDown";
            this.loadBankDropDown.Size = new System.Drawing.Size(218, 29);
            this.loadBankDropDown.TabIndex = 1;
            this.loadBankDropDown.Text = "<selected bank>";
            this.toolTip1.SetToolTip(this.loadBankDropDown, "Select Loadbank to use");
            this.loadBankDropDown.SelectedIndexChanged += new System.EventHandler(this.LoadBankDropDown_SelectedIndexChanged);
            // 
            // SelectLoadbankLabel
            // 
            this.SelectLoadbankLabel.AutoSize = true;
            this.SelectLoadbankLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLoadbankLabel.ForeColor = System.Drawing.Color.Navy;
            this.SelectLoadbankLabel.Location = new System.Drawing.Point(11, 65);
            this.SelectLoadbankLabel.Name = "SelectLoadbankLabel";
            this.SelectLoadbankLabel.Size = new System.Drawing.Size(203, 21);
            this.SelectLoadbankLabel.TabIndex = 2;
            this.SelectLoadbankLabel.Text = "Select Loadbank from list :";
            // 
            // editLoadbanksButton
            // 
            this.editLoadbanksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLoadbanksButton.Location = new System.Drawing.Point(237, 88);
            this.editLoadbanksButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editLoadbanksButton.Name = "editLoadbanksButton";
            this.editLoadbanksButton.Size = new System.Drawing.Size(66, 29);
            this.editLoadbanksButton.TabIndex = 3;
            this.editLoadbanksButton.Text = "Edit..";
            this.toolTip1.SetToolTip(this.editLoadbanksButton, "Click here to Edit curently selected loadbank ");
            this.editLoadbanksButton.UseVisualStyleBackColor = true;
            this.editLoadbanksButton.Click += new System.EventHandler(this.EditLoadbanksButton_Click);
            // 
            // etvTextBox
            // 
            this.etvTextBox.Location = new System.Drawing.Point(12, 159);
            this.etvTextBox.Name = "etvTextBox";
            this.etvTextBox.Size = new System.Drawing.Size(69, 29);
            this.etvTextBox.TabIndex = 4;
            this.etvTextBox.Text = "0";
            this.etvTextBox.TextChanged += new System.EventHandler(this.etvTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(8, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "String ETV voltage :";
            this.toolTip1.SetToolTip(this.label1, "Enter End Terminal Voltage for string.");
            // 
            // stringBuilderButton
            // 
            this.stringBuilderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringBuilderButton.Location = new System.Drawing.Point(16, 231);
            this.stringBuilderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stringBuilderButton.Name = "stringBuilderButton";
            this.stringBuilderButton.Size = new System.Drawing.Size(176, 29);
            this.stringBuilderButton.TabIndex = 6;
            this.stringBuilderButton.Text = "Define String..";
            this.toolTip1.SetToolTip(this.stringBuilderButton, "Defines the cell type and number of blocks in string");
            this.stringBuilderButton.UseVisualStyleBackColor = true;
            this.stringBuilderButton.Click += new System.EventHandler(this.StringBuilderButton_Click);
            // 
            // showAchievableButton
            // 
            this.showAchievableButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAchievableButton.Location = new System.Drawing.Point(70, 283);
            this.showAchievableButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAchievableButton.Name = "showAchievableButton";
            this.showAchievableButton.Size = new System.Drawing.Size(272, 29);
            this.showAchievableButton.TabIndex = 7;
            this.showAchievableButton.Text = "Show Achievable current at ETV";
            this.toolTip1.SetToolTip(this.showAchievableButton, "Click here to show results");
            this.showAchievableButton.UseVisualStyleBackColor = true;
            this.showAchievableButton.Click += new System.EventHandler(this.showAchievableButton_Click);
            // 
            // extraInfoLabel
            // 
            this.extraInfoLabel.BackColor = System.Drawing.Color.White;
            this.extraInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.extraInfoLabel.Location = new System.Drawing.Point(16, 317);
            this.extraInfoLabel.Name = "extraInfoLabel";
            this.extraInfoLabel.Size = new System.Drawing.Size(373, 20);
            this.extraInfoLabel.TabIndex = 9;
            this.extraInfoLabel.Text = "Will show extra data if battery string and test load are defined";
            this.extraInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(314, 463);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 29);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.toolTip1.SetToolTip(this.quitButton, "Click it, find out...");
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // NewLoadbankButton
            // 
            this.NewLoadbankButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLoadbankButton.Location = new System.Drawing.Point(314, 88);
            this.NewLoadbankButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewLoadbankButton.Name = "NewLoadbankButton";
            this.NewLoadbankButton.Size = new System.Drawing.Size(75, 29);
            this.NewLoadbankButton.TabIndex = 13;
            this.NewLoadbankButton.Text = "New..";
            this.toolTip1.SetToolTip(this.NewLoadbankButton, "Create a new loadbank to use");
            this.NewLoadbankButton.UseVisualStyleBackColor = true;
            this.NewLoadbankButton.Click += new System.EventHandler(this.NewLoadbankButton_Click);
            // 
            // minVoltsSuffixLabel
            // 
            this.minVoltsSuffixLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVoltsSuffixLabel.ForeColor = System.Drawing.Color.Navy;
            this.minVoltsSuffixLabel.Location = new System.Drawing.Point(87, 168);
            this.minVoltsSuffixLabel.Name = "minVoltsSuffixLabel";
            this.minVoltsSuffixLabel.Size = new System.Drawing.Size(27, 20);
            this.minVoltsSuffixLabel.TabIndex = 20;
            this.minVoltsSuffixLabel.Text = "V";
            // 
            // ClearStringDataButton
            // 
            this.ClearStringDataButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearStringDataButton.Location = new System.Drawing.Point(213, 231);
            this.ClearStringDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearStringDataButton.Name = "ClearStringDataButton";
            this.ClearStringDataButton.Size = new System.Drawing.Size(176, 29);
            this.ClearStringDataButton.TabIndex = 21;
            this.ClearStringDataButton.Text = "Clear String Data..";
            this.toolTip1.SetToolTip(this.ClearStringDataButton, "deletes the currently selected string data");
            this.ClearStringDataButton.UseVisualStyleBackColor = true;
            this.ClearStringDataButton.Click += new System.EventHandler(this.ClearStringDataButton_Click);
            // 
            // LoadRateTextbox
            // 
            this.LoadRateTextbox.Enabled = false;
            this.LoadRateTextbox.Location = new System.Drawing.Point(186, 159);
            this.LoadRateTextbox.Name = "LoadRateTextbox";
            this.LoadRateTextbox.Size = new System.Drawing.Size(69, 29);
            this.LoadRateTextbox.TabIndex = 22;
            this.LoadRateTextbox.Text = "0";
            this.toolTip1.SetToolTip(this.LoadRateTextbox, "Enter your required Discharge rate");
            this.LoadRateTextbox.TextChanged += new System.EventHandler(this.LoadRateTextbox_TextChanged);
            // 
            // loadRateLabel
            // 
            this.loadRateLabel.AutoSize = true;
            this.loadRateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadRateLabel.ForeColor = System.Drawing.Color.Navy;
            this.loadRateLabel.Location = new System.Drawing.Point(182, 135);
            this.loadRateLabel.Name = "loadRateLabel";
            this.loadRateLabel.Size = new System.Drawing.Size(221, 21);
            this.loadRateLabel.TabIndex = 23;
            this.loadRateLabel.Text = "Load Rate to use with string :";
            this.toolTip1.SetToolTip(this.loadRateLabel, "enter the discharge rate to use for testing");
            // 
            // LoadRateSuffixLabel
            // 
            this.LoadRateSuffixLabel.Enabled = false;
            this.LoadRateSuffixLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadRateSuffixLabel.ForeColor = System.Drawing.Color.Navy;
            this.LoadRateSuffixLabel.Location = new System.Drawing.Point(261, 168);
            this.LoadRateSuffixLabel.Name = "LoadRateSuffixLabel";
            this.LoadRateSuffixLabel.Size = new System.Drawing.Size(27, 20);
            this.LoadRateSuffixLabel.TabIndex = 24;
            this.LoadRateSuffixLabel.Text = "A";
            // 
            // OutputResultsLabel
            // 
            this.OutputResultsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.OutputResultsLabel.Location = new System.Drawing.Point(19, 352);
            this.OutputResultsLabel.Name = "OutputResultsLabel";
            this.OutputResultsLabel.Size = new System.Drawing.Size(370, 108);
            this.OutputResultsLabel.TabIndex = 25;
            this.OutputResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPic
            // 
            this.InfoPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoPic.BackgroundImage")));
            this.InfoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoPic.Location = new System.Drawing.Point(398, 5);
            this.InfoPic.Name = "InfoPic";
            this.InfoPic.Size = new System.Drawing.Size(35, 31);
            this.InfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoPic.TabIndex = 26;
            this.InfoPic.TabStop = false;
            this.toolTip1.SetToolTip(this.InfoPic, resources.GetString("InfoPic.ToolTip"));
            this.InfoPic.UseWaitCursor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 32767;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // DischargeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 504);
            this.Controls.Add(this.InfoPic);
            this.Controls.Add(this.OutputResultsLabel);
            this.Controls.Add(this.LoadRateSuffixLabel);
            this.Controls.Add(this.loadRateLabel);
            this.Controls.Add(this.LoadRateTextbox);
            this.Controls.Add(this.ClearStringDataButton);
            this.Controls.Add(this.minVoltsSuffixLabel);
            this.Controls.Add(this.NewLoadbankButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.extraInfoLabel);
            this.Controls.Add(this.showAchievableButton);
            this.Controls.Add(this.stringBuilderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etvTextBox);
            this.Controls.Add(this.editLoadbanksButton);
            this.Controls.Add(this.SelectLoadbankLabel);
            this.Controls.Add(this.loadBankDropDown);
            this.Controls.Add(this.MainTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DischargeMainForm";
            this.Text = "Discharge Assistant";
            this.Activated += new System.EventHandler(this.DischargeMainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DischargeMainForm_FormClosed);
            this.Load += new System.EventHandler(this.DischargeMainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.DischargeMainForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.ComboBox loadBankDropDown;
        private System.Windows.Forms.Label SelectLoadbankLabel;
        private System.Windows.Forms.Button editLoadbanksButton;
        private System.Windows.Forms.TextBox etvTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stringBuilderButton;
        private System.Windows.Forms.Button showAchievableButton;
        private System.Windows.Forms.Label extraInfoLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button NewLoadbankButton;
        private System.Windows.Forms.Label minVoltsSuffixLabel;
        private System.Windows.Forms.Button ClearStringDataButton;
        private System.Windows.Forms.TextBox LoadRateTextbox;
        private System.Windows.Forms.Label loadRateLabel;
        private System.Windows.Forms.Label LoadRateSuffixLabel;
        private System.Windows.Forms.Label OutputResultsLabel;
        private System.Windows.Forms.PictureBox InfoPic;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

