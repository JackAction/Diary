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
    public partial class ucPersons : ucBase
    {
        public ucPersons()
        {
            InitializeComponent();
            ucAddNewPlace1.PlaceAdded += new EventHandler(ucPlaceAdded);
        }

        [Description("Binding Source für Person."), Category("Data")]
        public BindingSource DataSourcePerson
        {
            get { return personBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Diary."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; } 
            set { diaryBindingSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Place."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Item."), Category("Data")]
        public BindingSource DataSourceItem
        {
            get { return itemBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Quest."), Category("Data")]
        public BindingSource DataSourceQuest
        {
            get { return questBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Neue Zeile wurde zu Person DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler PersonRowAdded;

        private void dbgrdPersons_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > personBindingSource.Count - 1)
            {
                PersonRowAdded?.Invoke(sender, e);
            }
        }

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > diaryBindingSource.Count - 1)
            {
                Person obj = personBindingSource.Current as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
                if (obj != null)
                {
                    if (diaryBindingSource.Current != null)
                    {
                        ((Diary)diaryBindingSource.Current).People.Add(obj);
                    }
                }
                DiaryRowAdded?.Invoke(sender, e);
            }
        }

        public void ShowDiaryEntries()
        {
            Person obj = personBindingSource.Current as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                if (obj.Diaries != null)
                {
                    diaryBindingSource.DataSource = obj.Diaries.ToList();
                }
            }
        }

        private void dbgrdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
            }
        }

        private void ucPersons_Load(object sender, EventArgs e)
        {
            ShowDiaryEntries();
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

        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Session ID muss eine Nummer sein.", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt der Personenliste eine Checkboxspalte hinzu und markiert jene, welche im aktuellen Diaryeintrag vorhanden sind. Setzt danach den DiaryEditMode.
        /// </summary>
        public void AddCheckboxesToPersonList()
        {
            DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
            cbColumn.HeaderText = "";
            cbColumn.FalseValue = "0";
            cbColumn.TrueValue = "1";
            cbColumn.Width = 20;
            dbgrdPersons.Columns.Insert(0, cbColumn);

            foreach (DataGridViewRow row in dbgrdPersons.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                Person currentPerson = row.DataBoundItem as Person;
                Diary currentDiary = DataSourceDiary.Current as Diary;

                if (currentDiary != null)
                {
                    if (currentDiary.People.Contains(currentPerson))
                    {
                        cell.Value = cell.TrueValue;
                    } 
                }
            }
            setDiaryMode();
        }

        private void setDiaryMode()
        {
            dbgrdDiary.Visible = false;
            Diary currentDiary = DataSourceDiary.Current as Diary;
            if (currentDiary != null)
            {
                lblDiaryEntries.Text = $"Person entries for Diaryentry: {currentDiary.Entry}"; 
            }
        }

        public void setNormalMode()
        {
            dbgrdDiary.Visible = true;
            lblDiaryEntries.Text = "Diary Entries";
            dbgrdPersons.Columns.RemoveAt(0);
        }

        /// <summary>
        /// Liefert alle Personen, welche in der Checkboxspalte markiert sind.
        /// </summary>
        /// <returns>Alle Personen, welche in der Checkboxspalte markiert sind</returns>
        public List<Person> GetCheckedPeople()
        {
            List<Person> personsWithCheck = new List<Person>();
            foreach (DataGridViewRow row in dbgrdPersons.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

                if (cell.Value != null)
                {
                    if (cell.Value == cell.TrueValue)
                    {
                        personsWithCheck.Add((row.DataBoundItem as Person));
                    }
                }
            }
            return personsWithCheck;
        }

        private void dbgrdDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdDiary.Columns[e.ColumnIndex].Name == "Delete")
            {
                diaryRowDeleted(sender, e);
            }
        }

        private void dbgrdDiary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                diaryRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Diary DataGrid gelöscht."), Category("Data")]
        public event EventHandler DiaryRowDeleted;

        private void diaryRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DiaryRowDeleted?.Invoke(sender, e);
                diaryBindingSource.RemoveCurrent();
            }
        }

        private void dbgrdPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdPersons.Columns[e.ColumnIndex].Name == "DeletePerson")
            {
                personRowDeleted(sender, e);
            }
        }

        private void dbgrdPersons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                personRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Person DataGrid gelöscht."), Category("Data")]
        public event EventHandler PersonRowDeleted;

        private void personRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PersonRowDeleted?.Invoke(sender, e);
                personBindingSource.RemoveCurrent();
            }
        }
    }
}
