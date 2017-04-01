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
            ucPicture1.PictureAdded += new EventHandler(PictureAdded);
            cbxFilterColumn.SelectedIndex = 1; // Initialfeld für Filter
        }

        [Description("Binding Source für PersonGrid."), Category("Data")]
        public BindingSource DataSourcePerson
        {
            get { return personBindingSource; }
        }

        [Description("Binding Source für DiaryGrid."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; } 
            set { diaryBindingSource = value; }
        }

        [Description("Binding Source für PlaceColumn."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
        }

        [Description("Binding Source für ItemColumn."), Category("Data")]
        public BindingSource DataSourceItem
        {
            get { return itemBindingSource; }
        }

        [Description("Binding Source für QuestColumn."), Category("Data")]
        public BindingSource DataSourceQuest
        {
            get { return questBindingSource; }
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
                LinkNewlyAddedDiaryRowToCurrentPerson();
                DiaryRowAdded?.Invoke(sender, e);
            }
        }

        private void LinkNewlyAddedDiaryRowToCurrentPerson()
        {
            Person obj = personBindingSource.Current as Person;
            if (obj != null)
            {
                if (diaryBindingSource.Current != null)
                {
                    ((Diary)diaryBindingSource.Current).People.Add(obj);
                }
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
            else
            {
                diaryBindingSource.DataSource = null;
            }
        }

        public void ShowPicture()
        {
            Person obj = personBindingSource.Current as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                ucPicture1.Image = obj.Picture;
            }
        }

        private void dbgrdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
                ShowPicture();
            }
        }

        private void ucPersons_Load(object sender, EventArgs e)
        {
            ShowDiaryEntries();
            ShowPicture();
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
        private void AddCheckboxesToPersonList()
        {
            DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
            cbColumn.HeaderText = "";
            cbColumn.FalseValue = "0";
            cbColumn.TrueValue = "1";
            cbColumn.Width = 20;
            cbColumn.DefaultCellStyle.BackColor = Color.LawnGreen;
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
        }

        /// <summary>
        /// Ändert den Modus der Personenansicht in den Einzelbearbeitungsmodus eines Tagebucheintrages.
        /// </summary>
        public void ChangePersonModeTo_DiaryDetailEdit()
        {
            AddCheckboxesToPersonList();
            dbgrdDiary.Visible = false;
            Diary currentDiary = DataSourceDiary.Current as Diary;
            if (currentDiary != null)
            {
                lblDiaryEntries.Text = $"Person entries for Diaryentry: {currentDiary.Entry}"; 
            }
        }

        /// <summary>
        /// Ändert den Modus der Personenansicht zurück in den normalen Modus.
        /// </summary>
        public void ChangePersonModeTo_NormalMode()
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
            if (dbgrdDiary.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
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
            if (dbgrdPersons.Columns[e.ColumnIndex].Name == "DeletePerson" && e.RowIndex >= 0)
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
                ShowDiaryEntries();
            }
        }

        private void PictureAdded(object sender, EventArgs e)
        {
            (personBindingSource.Current as Person).Picture = ucPicture1.Image;
        }

        private List<Person> PersonList;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (PersonList == null)
            {
                PersonList = DataSourcePerson.DataSource as List<Person>;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                DataSourcePerson.DataSource = PersonList;
                foreach (DataGridViewRow row in dbgrdPersons.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                if (cbxFilterColumn.SelectedItem.ToString() == "All")
                {
                    FullTextSearch((sender as TextBox).Text);
                }
                else
                {
                    List<Person> query =
                        PersonList.FindAll(delegate (Person obj)
                        {
                            switch (cbxFilterColumn.SelectedItem.ToString())
                            {
                                case "Name":
                                    if (obj.Name == null)
                                    {
                                        return false;
                                    }
                                    return obj.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Title":
                                    if (obj.Title == null)
                                    {
                                        return false;
                                    }
                                    return obj.Title.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Rank":
                                    if (obj.Rank == null)
                                    {
                                        return false;
                                    }
                                    return obj.Rank.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Clan":
                                    if (obj.Clan == null)
                                    {
                                        return false;
                                    }
                                    return obj.Clan.ToString().IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Place Met":
                                    if (obj.Place == null)
                                    {
                                        return false;
                                    }
                                    return obj.Place.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Place last known":
                                    if (obj.Place1 == null)
                                    {
                                        return false;
                                    }
                                    return obj.Place1.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Race":
                                    if (obj.Race == null)
                                    {
                                        return false;
                                    }
                                    return obj.Race.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Dead":
                                    if (obj.Dead == null)
                                    {
                                        return false;
                                    }
                                    return obj.Dead.ToString().IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Alignement":
                                    if (obj.Alignement == null)
                                    {
                                        return false;
                                    }
                                    return obj.Alignement.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Comment":
                                    if (obj.Comment_2 == null)
                                    {
                                        return false;
                                    }
                                    return obj.Comment_2.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Details":
                                    if (obj.Details == null)
                                    {
                                        return false;
                                    }
                                    return obj.Details.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                default:
                                    return false;
                            }
                        });
                    DataSourcePerson.DataSource = query;
                }
            }
        }

        private void FullTextSearch(string searchText)
        {
            dbgrdPersons.CurrentCell = dbgrdPersons[0, dbgrdPersons.RowCount - 1]; //Benötigt, damit CurrencyMangerfehler nicht auftritt (aktuelle row kann nicht ausgeblendet werrden).
            foreach (DataGridViewRow row in dbgrdPersons.Rows)
            {
                if (row.Index != dbgrdPersons.RowCount - 1)
                {
                    row.Visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value ?? "").ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
