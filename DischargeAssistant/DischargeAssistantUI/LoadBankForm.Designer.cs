namespace DischargeAssistant
{
    partial class LoadBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadBankForm));
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.LoadbankNameLabel = new System.Windows.Forms.Label();
            this.loadbankNameTextBox = new System.Windows.Forms.TextBox();
            this.bankPowerLabel = new System.Windows.Forms.Label();
            this.loadbankPowerTextbox = new System.Windows.Forms.TextBox();
            this.kwSuffixLabel = new System.Windows.Forms.Label();
            this.MinVoltageLabel = new System.Windows.Forms.Label();
            this.minVoltageTextBox = new System.Windows.Forms.TextBox();
            this.MaxVoltageLabel = new System.Windows.Forms.Label();
            this.MaxVoltageTextbox = new System.Windows.Forms.TextBox();
            this.CreateEditButton = new System.Windows.Forms.Button();
            this.minVoltsSuffixLabel = new System.Windows.Forms.Label();
            this.maxVoltsSuffixLabel = new System.Windows.Forms.Label();
            this.DeleteLoadbankButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.AutoSize = true;
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainTitleLabel.Location = new System.Drawing.Point(3, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(71, 40);
            this.MainTitleLabel.TabIndex = 1;
            this.MainTitleLabel.Text = "Title";
            // 
            // LoadbankNameLabel
            // 
            this.LoadbankNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadbankNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.LoadbankNameLabel.Location = new System.Drawing.Point(15, 67);
            this.LoadbankNameLabel.Name = "LoadbankNameLabel";
            this.LoadbankNameLabel.Size = new System.Drawing.Size(190, 21);
            this.LoadbankNameLabel.TabIndex = 7;
            this.LoadbankNameLabel.Text = "Enter Loadbank Name :";
            this.toolTip1.SetToolTip(this.LoadbankNameLabel, "Enter a simple name for the loadbank that will appear in the dropdowns");
            // 
            // loadbankNameTextBox
            // 
            this.loadbankNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbankNameTextBox.Location = new System.Drawing.Point(19, 91);
            this.loadbankNameTextBox.Name = "loadbankNameTextBox";
            this.loadbankNameTextBox.Size = new System.Drawing.Size(172, 29);
            this.loadbankNameTextBox.TabIndex = 6;
            this.loadbankNameTextBox.Text = "<bank name>";
            // 
            // bankPowerLabel
            // 
            this.bankPowerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankPowerLabel.ForeColor = System.Drawing.Color.Navy;
            this.bankPowerLabel.Location = new System.Drawing.Point(15, 139);
            this.bankPowerLabel.Name = "bankPowerLabel";
            this.bankPowerLabel.Size = new System.Drawing.Size(190, 21);
            this.bankPowerLabel.TabIndex = 9;
            this.bankPowerLabel.Text = "Enter Loadbank Power :";
            this.toolTip1.SetToolTip(this.bankPowerLabel, "Enter the power of the loadbank\r\nthis is in KW,  so for a 31KW bank, \r\njust enter" +
        " 31, and not 31000\r\n");
            // 
            // loadbankPowerTextbox
            // 
            this.loadbankPowerTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbankPowerTextbox.Location = new System.Drawing.Point(19, 163);
            this.loadbankPowerTextbox.Name = "loadbankPowerTextbox";
            this.loadbankPowerTextbox.Size = new System.Drawing.Size(97, 29);
            this.loadbankPowerTextbox.TabIndex = 8;
            this.loadbankPowerTextbox.Text = "<power KW>";
            // 
            // kwSuffixLabel
            // 
            this.kwSuffixLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kwSuffixLabel.ForeColor = System.Drawing.Color.Navy;
            this.kwSuffixLabel.Location = new System.Drawing.Point(128, 166);
            this.kwSuffixLabel.Name = "kwSuffixLabel";
            this.kwSuffixLabel.Size = new System.Drawing.Size(56, 21);
            this.kwSuffixLabel.TabIndex = 10;
            this.kwSuffixLabel.Text = "KW";
            // 
            // MinVoltageLabel
            // 
            this.MinVoltageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinVoltageLabel.ForeColor = System.Drawing.Color.Navy;
            this.MinVoltageLabel.Location = new System.Drawing.Point(15, 211);
            this.MinVoltageLabel.Name = "MinVoltageLabel";
            this.MinVoltageLabel.Size = new System.Drawing.Size(111, 21);
            this.MinVoltageLabel.TabIndex = 15;
            this.MinVoltageLabel.Text = "Min Voltage :";
            // 
            // minVoltageTextBox
            // 
            this.minVoltageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVoltageTextBox.Location = new System.Drawing.Point(132, 211);
            this.minVoltageTextBox.Name = "minVoltageTextBox";
            this.minVoltageTextBox.Size = new System.Drawing.Size(73, 29);
            this.minVoltageTextBox.TabIndex = 14;
            this.minVoltageTextBox.Text = "<Min V>";
            this.toolTip1.SetToolTip(this.minVoltageTextBox, "Minimum input voltage for loadbank");
            // 
            // MaxVoltageLabel
            // 
            this.MaxVoltageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxVoltageLabel.ForeColor = System.Drawing.Color.Navy;
            this.MaxVoltageLabel.Location = new System.Drawing.Point(15, 253);
            this.MaxVoltageLabel.Name = "MaxVoltageLabel";
            this.MaxVoltageLabel.Size = new System.Drawing.Size(111, 21);
            this.MaxVoltageLabel.TabIndex = 17;
            this.MaxVoltageLabel.Text = "Max Voltage :";
            // 
            // MaxVoltageTextbox
            // 
            this.MaxVoltageTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxVoltageTextbox.Location = new System.Drawing.Point(132, 250);
            this.MaxVoltageTextbox.Name = "MaxVoltageTextbox";
            this.MaxVoltageTextbox.Size = new System.Drawing.Size(73, 29);
            this.MaxVoltageTextbox.TabIndex = 16;
            this.MaxVoltageTextbox.Text = "<Max V>";
            this.toolTip1.SetToolTip(this.MaxVoltageTextbox, resources.GetString("MaxVoltageTextbox.ToolTip"));
            // 
            // CreateEditButton
            // 
            this.CreateEditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEditButton.Location = new System.Drawing.Point(19, 295);
            this.CreateEditButton.Name = "CreateEditButton";
            this.CreateEditButton.Size = new System.Drawing.Size(87, 29);
            this.CreateEditButton.TabIndex = 18;
            this.CreateEditButton.Text = "Create";
            this.toolTip1.SetToolTip(this.CreateEditButton, "Create and save the loadbank");
            this.CreateEditButton.UseVisualStyleBackColor = true;
            this.CreateEditButton.Click += new System.EventHandler(this.CreateEditButton_Click);
            // 
            // minVoltsSuffixLabel
            // 
            this.minVoltsSuffixLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minVoltsSuffixLabel.ForeColor = System.Drawing.Color.Navy;
            this.minVoltsSuffixLabel.Location = new System.Drawing.Point(211, 214);
            this.minVoltsSuffixLabel.Name = "minVoltsSuffixLabel";
            this.minVoltsSuffixLabel.Size = new System.Drawing.Size(27, 21);
            this.minVoltsSuffixLabel.TabIndex = 19;
            this.minVoltsSuffixLabel.Text = "V";
            // 
            // maxVoltsSuffixLabel
            // 
            this.maxVoltsSuffixLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxVoltsSuffixLabel.ForeColor = System.Drawing.Color.Navy;
            this.maxVoltsSuffixLabel.Location = new System.Drawing.Point(211, 253);
            this.maxVoltsSuffixLabel.Name = "maxVoltsSuffixLabel";
            this.maxVoltsSuffixLabel.Size = new System.Drawing.Size(25, 21);
            this.maxVoltsSuffixLabel.TabIndex = 20;
            this.maxVoltsSuffixLabel.Text = "V";
            // 
            // DeleteLoadbankButton
            // 
            this.DeleteLoadbankButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLoadbankButton.Location = new System.Drawing.Point(132, 295);
            this.DeleteLoadbankButton.Name = "DeleteLoadbankButton";
            this.DeleteLoadbankButton.Size = new System.Drawing.Size(87, 29);
            this.DeleteLoadbankButton.TabIndex = 21;
            this.DeleteLoadbankButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.DeleteLoadbankButton, "delete this selected loadbank");
            this.DeleteLoadbankButton.UseVisualStyleBackColor = true;
            this.DeleteLoadbankButton.Click += new System.EventHandler(this.DeleteLoadbankButton_Click);
            // 
            // LoadBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(241, 338);
            this.Controls.Add(this.DeleteLoadbankButton);
            this.Controls.Add(this.maxVoltsSuffixLabel);
            this.Controls.Add(this.minVoltsSuffixLabel);
            this.Controls.Add(this.CreateEditButton);
            this.Controls.Add(this.MaxVoltageLabel);
            this.Controls.Add(this.MaxVoltageTextbox);
            this.Controls.Add(this.MinVoltageLabel);
            this.Controls.Add(this.minVoltageTextBox);
            this.Controls.Add(this.kwSuffixLabel);
            this.Controls.Add(this.bankPowerLabel);
            this.Controls.Add(this.loadbankPowerTextbox);
            this.Controls.Add(this.LoadbankNameLabel);
            this.Controls.Add(this.loadbankNameTextBox);
            this.Controls.Add(this.MainTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadBankForm";
            this.Text = "LoadBankForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.Label LoadbankNameLabel;
        private System.Windows.Forms.TextBox loadbankNameTextBox;
        private System.Windows.Forms.Label bankPowerLabel;
        private System.Windows.Forms.TextBox loadbankPowerTextbox;
        private System.Windows.Forms.Label kwSuffixLabel;
        private System.Windows.Forms.Label MinVoltageLabel;
        private System.Windows.Forms.TextBox minVoltageTextBox;
        private System.Windows.Forms.Label MaxVoltageLabel;
        private System.Windows.Forms.TextBox MaxVoltageTextbox;
        private System.Windows.Forms.Button CreateEditButton;
        private System.Windows.Forms.Label minVoltsSuffixLabel;
        private System.Windows.Forms.Label maxVoltsSuffixLabel;
        private System.Windows.Forms.Button DeleteLoadbankButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}