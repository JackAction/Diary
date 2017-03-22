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
    public partial class ucDiary : ucBase
    {
        public ucDiary()
        {
            InitializeComponent();
            ucAddNewPlace1.PlaceAdded += new EventHandler(ucPlaceAdded);
        }

        [Description("Binding Source für Diary."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Place."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > diaryBindingSource.Count - 1)
            {
                DiaryRowAdded?.Invoke(sender, e); 
            }
        }


        [Description("New Place."), Category("Data")]
        public Place NewPlace
        {
            get
            {
                return ucAddNewPlace1.NewPlace;
            }
        }

        [Description("Neuer Place wird hinzugefügt."), Category("Data")]
        public event EventHandler PlaceAdded;

        private void ucPlaceAdded(object sender, EventArgs e)
        {
            PlaceAdded?.Invoke(sender, e);
        }







        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dbgrdDiary.Rows.Count-1; i++)
            {
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dbgrdDiary.Rows[i].Cells["peopleDataGridViewTextBoxColumn"];
                Diary obj = diaryBindingSource.List[i] as Diary;
                if (obj != null)
                {
                    if (obj.People != null)
                    {

                        comboCell.Items.Clear();
                        foreach (object itemToAdd in obj.People.ToList())
                        {
                            comboCell.Items.Add(itemToAdd);
                        }

                        //comboCell.DataSource = obj.People.ToList();
                        //comboCell.ValueType = typeof(List<Person>);
                        ////comboCell.Value = 1;
                        //comboCell.ValueMember = "ID";
                        //comboCell.DisplayMember = "Name";
                        ////comboCell.Value = obj.People.ToList().First();
                    }
                }

            }
        }

        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Session ID muss eine Nummer sein.", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Description("Personen zu einem Diary Eintrag ändern."), Category("Data")]
        public event EventHandler ChangePeopleOfDiaryEntry;

        private void dbgrdDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                ChangePeopleOfDiaryEntry?.Invoke(sender, e);
            }
        }
    }
}
