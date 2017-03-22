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
            diaryBindingSource.Filter = string.Format("{0}='{1}'", "Entry", "Krog");
            
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

        private List<Diary> diaryList;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (diaryList == null)
            {
                diaryList = DataSourceDiary.DataSource as List<Diary>; 
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                DataSourceDiary.DataSource = diaryList;
            }
            else
            {

                List<Diary> query =
                    diaryList.FindAll(delegate (Diary obj)
                    {
                        return obj.Entry.Contains((sender as TextBox).Text);
                    });

                DataSourceDiary.DataSource = query.ToList();
            }


        }
    }
}
