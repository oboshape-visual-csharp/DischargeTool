namespace DischargeAssistant
{
    partial class StringBuilderForm
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
            this.BlockTypeDropDown = new System.Windows.Forms.ComboBox();
            this.SetStringButton = new System.Windows.Forms.Button();
            this.SelectLoadbankLabel = new System.Windows.Forms.Label();
            this.BlockCountDropdown = new System.Windows.Forms.ComboBox();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.editBlocksButton = new System.Windows.Forms.Button();
            this.CancelStringButton = new System.Windows.Forms.Button();
            this.UseSelectedStringButton = new System.Windows.Forms.Button();
            this.stringSummaryLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BlockTypeDropDown
            // 
            this.BlockTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlockTypeDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockTypeDropDown.FormattingEnabled = true;
            this.BlockTypeDropDown.Location = new System.Drawing.Point(23, 69);
            this.BlockTypeDropDown.Name = "BlockTypeDropDown";
            this.BlockTypeDropDown.Size = new System.Drawing.Size(121, 29);
            this.BlockTypeDropDown.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BlockTypeDropDown, "Select the block type of the string");
            this.BlockTypeDropDown.SelectionChangeCommitted += new System.EventHandler(this.BlockTypeDropDown_SelectionChangeCommitted);
            // 
            // SetStringButton
            // 
            this.SetStringButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStringButton.Location = new System.Drawing.Point(298, 67);
            this.SetStringButton.Name = "SetStringButton";
            this.SetStringButton.Size = new System.Drawing.Size(105, 31);
            this.SetStringButton.TabIndex = 1;
            this.SetStringButton.Text = "Set String..";
            this.toolTip1.SetToolTip(this.SetStringButton, "set the string to what you have selected");
            this.SetStringButton.UseVisualStyleBackColor = true;
            this.SetStringButton.Click += new System.EventHandler(this.SetStringButton_Click);
            // 
            // SelectLoadbankLabel
            // 
            this.SelectLoadbankLabel.AutoSize = true;
            this.SelectLoadbankLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLoadbankLabel.ForeColor = System.Drawing.Color.Navy;
            this.SelectLoadbankLabel.Location = new System.Drawing.Point(19, 45);
            this.SelectLoadbankLabel.Name = "SelectLoadbankLabel";
            this.SelectLoadbankLabel.Size = new System.Drawing.Size(97, 21);
            this.SelectLoadbankLabel.TabIndex = 5;
            this.SelectLoadbankLabel.Text = "Block Type :";
            // 
            // BlockCountDropdown
            // 
            this.BlockCountDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlockCountDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockCountDropdown.FormattingEnabled = true;
            this.BlockCountDropdown.Location = new System.Drawing.Point(176, 69);
            this.BlockCountDropdown.Name = "BlockCountDropdown";
            this.BlockCountDropdown.Size = new System.Drawing.Size(100, 29);
            this.BlockCountDropdown.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BlockCountDropdown, "how many blocks are in the string");
            this.BlockCountDropdown.SelectedIndexChanged += new System.EventHandler(this.BlockCountDropdown_SelectedIndexChanged);
            // 
            // blockCountLabel
            // 
            this.blockCountLabel.AutoSize = true;
            this.blockCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockCountLabel.ForeColor = System.Drawing.Color.Navy;
            this.blockCountLabel.Location = new System.Drawing.Point(172, 45);
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(106, 21);
            this.blockCountLabel.TabIndex = 7;
            this.blockCountLabel.Text = "Block Count :";
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.AutoSize = true;
            this.multiplyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyLabel.ForeColor = System.Drawing.Color.Navy;
            this.multiplyLabel.Location = new System.Drawing.Point(150, 77);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(20, 21);
            this.multiplyLabel.TabIndex = 8;
            this.multiplyLabel.Text = "X";
            // 
            // editBlocksButton
            // 
            this.editBlocksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBlocksButton.Location = new System.Drawing.Point(23, 104);
            this.editBlocksButton.Name = "editBlocksButton";
            this.editBlocksButton.Size = new System.Drawing.Size(121, 31);
            this.editBlocksButton.TabIndex = 9;
            this.editBlocksButton.Text = "Edit Blocks..";
            this.toolTip1.SetToolTip(this.editBlocksButton, "edit and change the cell / block details");
            this.editBlocksButton.UseVisualStyleBackColor = true;
            this.editBlocksButton.Click += new System.EventHandler(this.EditBlocksButton_Click);
            // 
            // CancelStringButton
            // 
            this.CancelStringButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelStringButton.Location = new System.Drawing.Point(256, 338);
            this.CancelStringButton.Name = "CancelStringButton";
            this.CancelStringButton.Size = new System.Drawing.Size(147, 31);
            this.CancelStringButton.TabIndex = 10;
            this.CancelStringButton.Text = "Cancel String..";
            this.toolTip1.SetToolTip(this.CancelStringButton, "clears the string information\r\nand return to previous window\r\n");
            this.CancelStringButton.UseVisualStyleBackColor = true;
            this.CancelStringButton.Click += new System.EventHandler(this.CancelStringButton_Click);
            // 
            // UseSelectedStringButton
            // 
            this.UseSelectedStringButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseSelectedStringButton.Location = new System.Drawing.Point(12, 338);
            this.UseSelectedStringButton.Name = "UseSelectedStringButton";
            this.UseSelectedStringButton.Size = new System.Drawing.Size(158, 31);
            this.UseSelectedStringButton.TabIndex = 11;
            this.UseSelectedStringButton.Text = "Use Selected..";
            this.toolTip1.SetToolTip(this.UseSelectedStringButton, "as long as you have set the string\r\npressing use selected will save the string in" +
        "formation\r\nand return to previous window\r\n");
            this.UseSelectedStringButton.UseVisualStyleBackColor = true;
            this.UseSelectedStringButton.Click += new System.EventHandler(this.UseSelectedStringButton_Click);
            // 
            // stringSummaryLabel
            // 
            this.stringSummaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringSummaryLabel.Location = new System.Drawing.Point(20, 227);
            this.stringSummaryLabel.Name = "stringSummaryLabel";
            this.stringSummaryLabel.Size = new System.Drawing.Size(383, 90);
            this.stringSummaryLabel.TabIndex = 12;
            this.stringSummaryLabel.Text = "String data not currently defined.";
            // 
            // StringBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 381);
            this.ControlBox = false;
            this.Controls.Add(this.stringSummaryLabel);
            this.Controls.Add(this.UseSelectedStringButton);
            this.Controls.Add(this.CancelStringButton);
            this.Controls.Add(this.editBlocksButton);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.blockCountLabel);
            this.Controls.Add(this.BlockCountDropdown);
            this.Controls.Add(this.SelectLoadbankLabel);
            this.Controls.Add(this.SetStringButton);
            this.Controls.Add(this.BlockTypeDropDown);
            this.Name = "StringBuilderForm";
            this.Text = "StringBuilderForm";
            this.Load += new System.EventHandler(this.StringBuilderForm_Load);
            this.VisibleChanged += new System.EventHandler(this.StringBuilderForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BlockTypeDropDown;
        private System.Windows.Forms.Button SetStringButton;
        private System.Windows.Forms.Label SelectLoadbankLabel;
        private System.Windows.Forms.ComboBox BlockCountDropdown;
        private System.Windows.Forms.Label blockCountLabel;
        private System.Windows.Forms.Label multiplyLabel;
        private System.Windows.Forms.Button editBlocksButton;
        private System.Windows.Forms.Button CancelStringButton;
        private System.Windows.Forms.Button UseSelectedStringButton;
        private System.Windows.Forms.Label stringSummaryLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}