using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace DischargeAssistant
{
    public partial class CellDataEditorForm : Form
    {

        // temp block data for use in validation
        string _BlockName;
        double _nomVolts;
        double _etvVolts;
        private int m_IndexOfSelectedBlock = -1;
        private StringBuilderForm passedinForm = null;

        public CellDataEditorForm()
        {
            InitializeComponent();
        }

        public void SetCallingForm(StringBuilderForm callingForm)
        {
            passedinForm = callingForm;
        }

        private void CellDataEditorForm_Load(object sender, EventArgs e)
        {
            DeleteSelectedBlockButton.Enabled = false; // disable until something is selected
            SaveBlockChangedButton.Enabled = false;

            if (Utility.DoesBlockDataFileExist() == true)
            { 
                // load the BlockData file and save to globaldata variable
                if (Utility.IsCellDatafileEmpty() == true)
                {
                    MessageBox.Show("Block Data file empty, create block info.");
                    DisableControlsForFirstBlockData();
                }
                else
                {
                    // so there is a file and theres stuff in it, so show the data in the dropdown
                    Utility.ReadCellData();
                    blockDropDown.DataSource = GlobalData.batteryCellDataList;
                    blockDropDown.DisplayMember = "CellName";
                }
            }
            else
            {
                MessageBox.Show("No Block Data File, create block info.");
                DisableControlsForFirstBlockData();
            }


            // just so theres nothing selected at start
            blockDropDown.SelectedIndex = -1;
        }

       


        


        //-------------------------------------------------------------
        // ADD A NEW BLOCK TO THE GLOBAL DATA AND SAVE TO FILE
        //-------------------------------------------------------------
        private void AddNewBlockButton_Click(object sender, EventArgs e)
        {
            if(ValidateBlockForm())
            {
                GlobalData.batteryCellDataList.Add(new CellModel(_BlockName, _nomVolts, _etvVolts));
                Utility.SaveCellDataListToFile();
                // update the dropdown
                UpdateBlockDropDown();
                ClearForm();
                if (Utility.IsCellDatafileEmpty() == false)
                {
                    EnableControlsBlockData();
                    UpdateBlockDropDown();
                    DeleteSelectedBlockButton.Enabled = false;
                    SaveBlockChangedButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please check all fields are validly populated!");
            }
        }

       

        private void BlockEditorExit_Click(object sender, EventArgs e)
        {
            passedinForm.Visible = true;
            this.Close();
        }


        private void DeleteSelectedBlockButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
                    MessageBox.Show("Are you sure you want to delete the Block?", "Delete Blocktype : " + GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].CellName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // delete the loadbank and refresh list
                GlobalData.batteryCellDataList.RemoveAt(m_IndexOfSelectedBlock);
                Utility.SaveCellDataListToFile();
                Utility.ReadCellData();
                m_IndexOfSelectedBlock = -1;
                UpdateBlockDropDown();
                if (Utility.IsCellDatafileEmpty() )
                {
                    Console.WriteLine("EMPTY");
                    DisableControlsForFirstBlockData();
                }
                // update the dropdown
                UpdateBlockDropDown();
                ClearForm();

                DeleteSelectedBlockButton.Enabled = false;
                SaveBlockChangedButton.Enabled = false;
            }

            if (result == DialogResult.No)
            {
                // just return to the form
            }


        }


        //-------------------------------------------------------------
        // THIS IS FIRED WHEN A CONFIRMED SELECTION IS MADE IN DROPDOWN
        //-------------------------------------------------------------
        private void BlockDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_IndexOfSelectedBlock = GlobalData.batteryCellDataList.FindIndex(item => item == blockDropDown.SelectedItem as CellModel);
           // CellModel temp = blockDropDown.SelectedItem as CellModel;
            if (m_IndexOfSelectedBlock >= 0)
            {
                DeleteSelectedBlockButton.Enabled = true;
                SaveBlockChangedButton.Enabled = true;
                // populate the text boxes with the selected values
                BlockNameTextBox.Text = GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].CellName.ToString();
                nominalVoltsTextbox.Text = GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].NominalVoltage.ToString();
                ETVTextBox.Text = GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].EtvVoltage.ToString();

            }
            else
            {
                DeleteSelectedBlockButton.Enabled = false;
            }

            // clear the message at the bottom when a new item is selected
            ShowMessage("");
        }




        //-------------------------------------------------------------
        // THIS IS ALL THE FORMS HELPER METHODS
        //-------------------------------------------------------------
        
            
        //-------------------------------------------------------------
        // DISABLE THE CONTROLS FOR FIRST TIME BLOCK DATA CREATION
        //-------------------------------------------------------------
        private void DisableControlsForFirstBlockData()
        {
            blockDropDown.Enabled = false;
            DeleteSelectedBlockButton.Enabled = false;
            SaveBlockChangedButton.Enabled = false;
        }


        //-------------------------------------------------------------
        // ENABLE ALL THE FORM BUTTONS
        //-------------------------------------------------------------
        private void EnableControlsBlockData()
        {
            blockDropDown.Enabled = true;
            DeleteSelectedBlockButton.Enabled = true;
            SaveBlockChangedButton.Enabled = true;
        }

        //-------------------------------------------------------------
        // UPDATE THE DROPDOWN
        //-------------------------------------------------------------
        private void UpdateBlockDropDown()
        {
            blockDropDown.DataSource = null;
            blockDropDown.Items.Clear();
            blockDropDown.DataSource = GlobalData.batteryCellDataList;
            blockDropDown.DisplayMember = "CellName";
            blockDropDown.SelectedIndex = -1;
        }

        //-------------------------------------------------------------
        // VALIDATE THE FORM DATA
        //-------------------------------------------------------------
        private bool ValidateBlockForm()
        {
            bool isValid = true;
            // check that the boxes are not zer length
            if (BlockNameTextBox.Text.Trim().Length == 0) { isValid = false; }
            if (nominalVoltsTextbox.Text.Trim().Length == 0) { isValid = false; }
            if (ETVTextBox.Text.Trim().Length == 0) { isValid = false; }

            // now check for input validity
            _BlockName = BlockNameTextBox.Text.Trim().ToString();
            isValid = double.TryParse(nominalVoltsTextbox.Text.Trim(), out _nomVolts);
            isValid = double.TryParse(ETVTextBox.Text.Trim(), out _etvVolts);

            if (isValid == false)
            {
                // reset temp block info
                _BlockName = "";
                _nomVolts = 0;
                _etvVolts = 0;
            }

            return isValid;
        }


        //-------------------------------------------------------------
        // Save the data back to the selected object in the list
        //-------------------------------------------------------------
        private void SaveBlockChangedButton_Click(object sender, EventArgs e)
        {
            if(ValidateBlockForm())
            {
                GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].CellName = _BlockName;
                GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].NominalVoltage = _nomVolts;
                GlobalData.batteryCellDataList[m_IndexOfSelectedBlock].EtvVoltage = _etvVolts;
                Utility.SaveCellDataListToFile();
                SaveBlockChangedButton.Enabled = false; // turn off the save button
                UpdateBlockDropDown();
                ClearForm();
                ShowMessage("Changes saved...");
            }
        }

        private void ClearForm()
        {
            // reset temp block info
            _BlockName = "";
            _nomVolts = 0;
            _etvVolts = 0;

            // clear the form text boxes
            BlockNameTextBox.Text = "";
            nominalVoltsTextbox.Text = "";
            ETVTextBox.Text = "";
        }

        private void ShowMessage(string _message)
        {
            MessageLabel.Text = _message;
        }
    }


}
