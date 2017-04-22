using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucBase : UserControl
    {
        public ucBase()
        {
            InitializeComponent();
        }

        public void RaiseErrorMessageForSessionID(object sender, DataGridViewDataErrorEventArgs e)
        {
            bool errorColumnIsSessionID = e.ColumnIndex == 0 ? true : false;

            if (errorColumnIsSessionID)
            {
                MessageBox.Show("Session ID muss eine Nummer sein.", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public void ActivateComboBoxOnFirstClick(object sender, DataGridViewCellEventArgs e)
        {
            // How to activate combobox on first click (Datagridview):
            // http://stackoverflow.com/questions/13005112/how-to-activate-combobox-on-first-click-datagridview?noredirect=1&lq=1

            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }
    }
}
