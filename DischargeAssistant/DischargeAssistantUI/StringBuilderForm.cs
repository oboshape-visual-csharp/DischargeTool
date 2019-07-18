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
    public partial class StringBuilderForm : Form
    {
        private bool WarnblockFileNotExists = true;
        private bool WarnBlockFileEmpty = true;
        private DischargeMainForm originatorForm = null;
        private int m_selectedLoadbankIndex = -1;
        public StringBuilderForm()
        {
            InitializeComponent();
        }

        private void StringBuilderForm_Load(object sender, EventArgs e)
        {
            // just need to pop a few cells in here to get the ball rolling
            PopulateBlockCountDropdown();
            PopulateBlockTypeDropDown();
            BlockTypeDropDown.SelectedItem = 0;
            BlockCountDropdown.SelectedItem = 0;
            UseSelectedStringButton.Enabled = false;
            CheckValidSelection();

        }

        private void EditBlocksButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CellDataEditorForm cellDataEditorForm = new CellDataEditorForm();
            cellDataEditorForm.SetCallingForm(this);
            cellDataEditorForm.ShowDialog();
            
        }

        private void BlockTypeDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_selectedLoadbankIndex = GlobalData.batteryCellDataList.FindIndex(item => item == BlockTypeDropDown.SelectedItem as CellModel);
            CheckValidSelection();
        }

        private void PopulateBlockCountDropdown()
        {
            int maxCount = 200;
            List<int> cellCountList = new List<int>();

            for (int i = 1; i <= maxCount; i++)
            {
                cellCountList.Add(i);
            }

            BlockCountDropdown.DataSource = cellCountList;
            BlockCountDropdown.DisplayMember = cellCountList.ToString();
        }

        private void BlockCountDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValidSelection();
        }

        private void PopulateBlockTypeDropDown()
        {
           if (Utility.DoesBlockDataFileExist() == true)
            {
                // load the BlockData file and save to globaldata variable
                if (Utility.IsCellDatafileEmpty() == true)
                {
                    if (WarnBlockFileEmpty == true)
                    {
                        MessageBox.Show("Block Data file empty, create block info.");
                        WarnBlockFileEmpty = false;
                    }
                }
                else
                {
                    //empty and clear the list for a refresh
                    BlockTypeDropDown.DataSource = null;
                    BlockTypeDropDown.Items.Clear();
                    // so there is a file and theres stuff in it, so show the data in the dropdown
                    Utility.ReadCellData();
                    BlockTypeDropDown.DataSource = GlobalData.batteryCellDataList;
                    BlockTypeDropDown.DisplayMember = "CellName";
                    // reset the selected index to clear it out for both dropdowns
                    BlockTypeDropDown.SelectedIndex = -1;
                    BlockCountDropdown.SelectedIndex = -1;
                }
            }
            else
            {
                if (WarnblockFileNotExists == true)
                {
                    MessageBox.Show("No Block Data File, create block info.");
                    WarnblockFileNotExists = false;
                }
            }
        }

        // called when the form has became visible, should work
        private void StringBuilderForm_VisibleChanged(object sender, EventArgs e)
        {
            // reload the block type dropdown on visibility change
            PopulateBlockTypeDropDown();
            CheckValidSelection();
        }

        private void CancelStringButton_Click(object sender, EventArgs e)
        {
            // if the form is cancelled, clear the global string information first
            GlobalData.selectedBatteryString = null;
            // then just close this form
            this.Close();
            // and make sure the originator form is shown and the ETV is enabled
            originatorForm.Show();
        }

        // set the string information in the global data based on what is selected
        private void SetStringButton_Click(object sender, EventArgs e)
        {
            CellModel selectedBlocktype = BlockTypeDropDown.SelectedItem as CellModel;
            int selectedBlockCount;
            bool canParseInt = int.TryParse(BlockCountDropdown.SelectedItem.ToString(), out selectedBlockCount);
            
            if (selectedBlocktype != null && canParseInt)
            {
                GlobalData.selectedBatteryString = new BatteryStringObject(selectedBlocktype, selectedBlockCount);
                stringSummaryLabel.Text =
                    "Selected a string of " + selectedBlockCount + " x " + selectedBlocktype.CellName + " in series,\n\n" +
                    "With a nominal voltage of " + GlobalData.selectedBatteryString.GetStringNomVolts() + 
                    "v  and an ETV of " + GlobalData.selectedBatteryString.GetStringETV() + "v.";

                // enable the use this string button if still valid
                UseSelectedStringButton.Enabled = (GlobalData.selectedBatteryString == null) ? false : true;
            }
            else
            {
                MessageBox.Show("Invalid Selection..");
            }
        }

        void CheckValidSelection()
        {
            bool valid = false;
     
            if(BlockTypeDropDown.SelectedItem != null)
            {
                if(BlockCountDropdown.SelectedItem != null)
                {
                    valid = true;
                }
            }
            SetStringButton.Enabled = valid;
        }

        public void PassInForm(DischargeMainForm _passedIn)
        {
            originatorForm = _passedIn;
        }

        private void UseSelectedStringButton_Click(object sender, EventArgs e)
        {
            // need to somehow tell the main form that a string has been selected for use
            // close this form down
            originatorForm.Show();
            this.Close();
        }


    }
}
