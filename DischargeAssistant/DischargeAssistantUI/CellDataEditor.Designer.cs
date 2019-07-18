namespace DischargeAssistant
{
    partial class CellDataEditorForm
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
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.blockDropDown = new System.Windows.Forms.ComboBox();
            this.SelectBlockLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedBlockButton = new System.Windows.Forms.Button();
            this.BlockNameLabel = new System.Windows.Forms.Label();
            this.BlockNameTextBox = new System.Windows.Forms.TextBox();
            this.nominalVoltsTextbox = new System.Windows.Forms.TextBox();
            this.NominalVoltsLabel = new System.Windows.Forms.Label();
            this.ETVTextBox = new System.Windows.Forms.TextBox();
            this.ETVLabel = new System.Windows.Forms.Label();
            this.AddNewBlockButton = new System.Windows.Forms.Button();
            this.SaveBlockChangedButton = new System.Windows.Forms.Button();
            this.BlockEditorExit = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(403, 40);
            this.MainTitleLabel.TabIndex = 1;
            this.MainTitleLabel.Text = "Block Editor";
            // 
            // blockDropDown
            // 
            this.blockDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockDropDown.FormattingEnabled = true;
            this.blockDropDown.Location = new System.Drawing.Point(19, 88);
            this.blockDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockDropDown.Name = "blockDropDown";
            this.blockDropDown.Size = new System.Drawing.Size(277, 29);
            this.blockDropDown.TabIndex = 2;
            this.toolTip1.SetToolTip(this.blockDropDown, "Select the Block/Cell type to use");
            this.blockDropDown.SelectionChangeCommitted += new System.EventHandler(this.BlockDropDown_SelectionChangeCommitted);
            // 
            // SelectBlockLabel
            // 
            this.SelectBlockLabel.AutoSize = true;
            this.SelectBlockLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBlockLabel.ForeColor = System.Drawing.Color.Navy;
            this.SelectBlockLabel.Location = new System.Drawing.Point(15, 65);
            this.SelectBlockLabel.Name = "SelectBlockLabel";
            this.SelectBlockLabel.Size = new System.Drawing.Size(228, 21);
            this.SelectBlockLabel.TabIndex = 3;
            this.SelectBlockLabel.Text = "Select Block from dropdown :";
            // 
            // DeleteSelectedBlockButton
            // 
            this.DeleteSelectedBlockButton.Enabled = false;
            this.DeleteSelectedBlockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedBlockButton.Location = new System.Drawing.Point(315, 88);
            this.DeleteSelectedBlockButton.Name = "DeleteSelectedBlockButton";
            this.DeleteSelectedBlockButton.Size = new System.Drawing.Size(142, 29);
            this.DeleteSelectedBlockButton.TabIndex = 22;
            this.DeleteSelectedBlockButton.Text = "Delete Selected";
            this.toolTip1.SetToolTip(this.DeleteSelectedBlockButton, "Deletes the currently selected block type from database");
            this.DeleteSelectedBlockButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedBlockButton.Click += new System.EventHandler(this.DeleteSelectedBlockButton_Click);
            // 
            // BlockNameLabel
            // 
            this.BlockNameLabel.AutoSize = true;
            this.BlockNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.BlockNameLabel.Location = new System.Drawing.Point(18, 158);
            this.BlockNameLabel.Name = "BlockNameLabel";
            this.BlockNameLabel.Size = new System.Drawing.Size(142, 21);
            this.BlockNameLabel.TabIndex = 23;
            this.BlockNameLabel.Text = "Block type Name :";
            this.toolTip1.SetToolTip(this.BlockNameLabel, "Enter a simple name that appears in dropdown");
            // 
            // BlockNameTextBox
            // 
            this.BlockNameTextBox.Location = new System.Drawing.Point(19, 182);
            this.BlockNameTextBox.Name = "BlockNameTextBox";
            this.BlockNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.BlockNameTextBox.TabIndex = 24;
            this.toolTip1.SetToolTip(this.BlockNameTextBox, "Enter friendly name for Cell / Block type");
            // 
            // nominalVoltsTextbox
            // 
            this.nominalVoltsTextbox.Location = new System.Drawing.Point(211, 182);
            this.nominalVoltsTextbox.Name = "nominalVoltsTextbox";
            this.nominalVoltsTextbox.Size = new System.Drawing.Size(68, 20);
            this.nominalVoltsTextbox.TabIndex = 26;
            this.toolTip1.SetToolTip(this.nominalVoltsTextbox, "Enter nominal voltage");
            // 
            // NominalVoltsLabel
            // 
            this.NominalVoltsLabel.AutoSize = true;
            this.NominalVoltsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NominalVoltsLabel.ForeColor = System.Drawing.Color.Navy;
            this.NominalVoltsLabel.Location = new System.Drawing.Point(207, 158);
            this.NominalVoltsLabel.Name = "NominalVoltsLabel";
            this.NominalVoltsLabel.Size = new System.Drawing.Size(139, 21);
            this.NominalVoltsLabel.TabIndex = 25;
            this.NominalVoltsLabel.Text = "Nominal Voltage :";
            this.toolTip1.SetToolTip(this.NominalVoltsLabel, "Enter nominal voltage of cell/block");
            // 
            // ETVTextBox
            // 
            this.ETVTextBox.Location = new System.Drawing.Point(356, 182);
            this.ETVTextBox.Name = "ETVTextBox";
            this.ETVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ETVTextBox.TabIndex = 28;
            this.toolTip1.SetToolTip(this.ETVTextBox, "enter the ETV voltage for block");
            // 
            // ETVLabel
            // 
            this.ETVLabel.AutoSize = true;
            this.ETVLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETVLabel.ForeColor = System.Drawing.Color.Navy;
            this.ETVLabel.Location = new System.Drawing.Point(352, 158);
            this.ETVLabel.Name = "ETVLabel";
            this.ETVLabel.Size = new System.Drawing.Size(105, 21);
            this.ETVLabel.TabIndex = 27;
            this.ETVLabel.Text = "ETV Voltage :";
            this.toolTip1.SetToolTip(this.ETVLabel, "enter ETV voltage of block/cel");
            // 
            // AddNewBlockButton
            // 
            this.AddNewBlockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBlockButton.Location = new System.Drawing.Point(160, 291);
            this.AddNewBlockButton.Name = "AddNewBlockButton";
            this.AddNewBlockButton.Size = new System.Drawing.Size(142, 29);
            this.AddNewBlockButton.TabIndex = 29;
            this.AddNewBlockButton.Text = "Add As New ";
            this.toolTip1.SetToolTip(this.AddNewBlockButton, "Creates a new Cell/BLock based on the information you have entered");
            this.AddNewBlockButton.UseVisualStyleBackColor = true;
            this.AddNewBlockButton.Click += new System.EventHandler(this.AddNewBlockButton_Click);
            // 
            // SaveBlockChangedButton
            // 
            this.SaveBlockChangedButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBlockChangedButton.Location = new System.Drawing.Point(12, 291);
            this.SaveBlockChangedButton.Name = "SaveBlockChangedButton";
            this.SaveBlockChangedButton.Size = new System.Drawing.Size(142, 29);
            this.SaveBlockChangedButton.TabIndex = 30;
            this.SaveBlockChangedButton.Text = "Save Changes";
            this.toolTip1.SetToolTip(this.SaveBlockChangedButton, "Overwrites the information for the currently selected block / cell");
            this.SaveBlockChangedButton.UseVisualStyleBackColor = true;
            this.SaveBlockChangedButton.Click += new System.EventHandler(this.SaveBlockChangedButton_Click);
            // 
            // BlockEditorExit
            // 
            this.BlockEditorExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockEditorExit.Location = new System.Drawing.Point(315, 291);
            this.BlockEditorExit.Name = "BlockEditorExit";
            this.BlockEditorExit.Size = new System.Drawing.Size(142, 29);
            this.BlockEditorExit.TabIndex = 31;
            this.BlockEditorExit.Text = "Close";
            this.toolTip1.SetToolTip(this.BlockEditorExit, "cancels and returns to previous window");
            this.BlockEditorExit.UseVisualStyleBackColor = true;
            this.BlockEditorExit.Click += new System.EventHandler(this.BlockEditorExit_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(19, 346);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(285, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(430, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "V";
            // 
            // CellDataEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 332);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.BlockEditorExit);
            this.Controls.Add(this.SaveBlockChangedButton);
            this.Controls.Add(this.AddNewBlockButton);
            this.Controls.Add(this.ETVTextBox);
            this.Controls.Add(this.ETVLabel);
            this.Controls.Add(this.nominalVoltsTextbox);
            this.Controls.Add(this.NominalVoltsLabel);
            this.Controls.Add(this.BlockNameTextBox);
            this.Controls.Add(this.BlockNameLabel);
            this.Controls.Add(this.DeleteSelectedBlockButton);
            this.Controls.Add(this.SelectBlockLabel);
            this.Controls.Add(this.blockDropDown);
            this.Controls.Add(this.MainTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CellDataEditorForm";
            this.Text = "Block Data Editor";
            this.Load += new System.EventHandler(this.CellDataEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.ComboBox blockDropDown;
        private System.Windows.Forms.Label SelectBlockLabel;
        private System.Windows.Forms.Button DeleteSelectedBlockButton;
        private System.Windows.Forms.Label BlockNameLabel;
        private System.Windows.Forms.TextBox BlockNameTextBox;
        private System.Windows.Forms.TextBox nominalVoltsTextbox;
        private System.Windows.Forms.Label NominalVoltsLabel;
        private System.Windows.Forms.TextBox ETVTextBox;
        private System.Windows.Forms.Label ETVLabel;
        private System.Windows.Forms.Button AddNewBlockButton;
        private System.Windows.Forms.Button SaveBlockChangedButton;
        private System.Windows.Forms.Button BlockEditorExit;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}