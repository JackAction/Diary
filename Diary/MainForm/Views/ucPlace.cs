using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucPlace : ucBase
    {
        private List<Place> placeList;

        public ucPlace()
        {
            InitializeComponent();
            ucPicture1.PictureAdded += new EventHandler(PictureAdded);
            cbxFilterColumn.SelectedIndex = 5; // Initialfeld für Filter
        }

        #region DataSources

        [Description("Binding Source für PlaceGrid."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
        }

        [Description("Binding Source für DiaryGrid."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
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

        #endregion

        #region Handle creation of new Model Entries

        [Description("Neue Zeile wurde zu Place DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler PlaceRowAdded;

        private void dbgrdPlaces_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bool newRowAddedByUser = e.RowIndex > placeBindingSource.Count - 1 ? true : false;
            if (newRowAddedByUser)
            {
                PlaceRowAdded?.Invoke(sender, e);
            }
        }

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bool newRowAddedByUser = e.RowIndex > diaryBindingSource.Count - 1 ? true : false;
            if (newRowAddedByUser)
            {
                LinkNewlyAddedDiaryRowToCurrentPlace();
                DiaryRowAdded?.Invoke(sender, e);
            }
        }

        private void LinkNewlyAddedDiaryRowToCurrentPlace()
        {
            Place obj = placeBindingSource.Current as Place;
            if (obj != null)
            {
                if (diaryBindingSource.Current != null)
                {
                    ((Diary)diaryBindingSource.Current).Place = obj;
                }
            }
        }

        #endregion

        #region Handle deletion of Model Entries

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
                ShowDiaryEntries();
            }
        }

        private void dbgrdPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdPlaces.Columns[e.ColumnIndex].Name == "DeletePlace" && e.RowIndex >= 0)
            {
                placeRowDeleted(sender, e);
            }
        }

        private void dbgrdPlaces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                placeRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Place DataGrid gelöscht."), Category("Data")]
        public event EventHandler PlaceRowDeleted;

        private void placeRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PlaceRowDeleted?.Invoke(sender, e);
                placeBindingSource.RemoveCurrent();
            }
        }

        #endregion

        #region Search and filter functions

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (placeList == null)
            {
                placeList = DataSourcePlace.DataSource as List<Place>;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                DataSourcePlace.DataSource = placeList;
                foreach (DataGridViewRow row in dbgrdPlaces.Rows)
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
                    List<Place> query =
                        placeList.FindAll(delegate (Place obj)
                        {
                            switch (cbxFilterColumn.SelectedItem.ToString())
                            {
                                case "Continent":
                                    if (obj.Continent == null)
                                    {
                                        return false;
                                    }
                                    return obj.Continent.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "City":
                                    if (obj.City == null)
                                    {
                                        return false;
                                    }
                                    return obj.City.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "District":
                                    if (obj.District == null)
                                    {
                                        return false;
                                    }
                                    return obj.District.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Building":
                                    if (obj.Building == null)
                                    {
                                        return false;
                                    }
                                    return obj.Building.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Name":
                                    if (obj.Name == null)
                                    {
                                        return false;
                                    }
                                    return obj.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
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
                    DataSourcePlace.DataSource = query;
                }
            }
        }

        private void FullTextSearch(string searchText)
        {
            dbgrdPlaces.CurrentCell = dbgrdPlaces[0, dbgrdPlaces.RowCount - 1]; //Benötigt, damit CurrencyMangerfehler nicht auftritt (aktuelle row kann nicht ausgeblendet werrden).
            foreach (DataGridViewRow row in dbgrdPlaces.Rows)
            {
                if (row.Index != dbgrdPlaces.RowCount - 1)
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

        #endregion

        #region Refresh data dependant of primary DGV selection

        private void dbgrdPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
                ShowPicture();
            }
        }

        public void ShowDiaryEntries()
        {
            Place obj = placeBindingSource.Current as Place;
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
            Place obj = placeBindingSource.Current as Place;
            if (obj != null)
            {
                ucPicture1.Image = obj.Picture;
            }
        }

        #endregion

        private void ucPlace_Load(object sender, EventArgs e)
        {
            ShowDiaryEntries();
            ShowPicture();
        }

        private void PictureAdded(object sender, EventArgs e)
        {
            (placeBindingSource.Current as Place).Picture = ucPicture1.Image;
        }

        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            RaiseErrorMessageForSessionID(sender, e);
        }

        private void dbgrdDiary_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ActivateComboBoxOnFirstClick(sender, e);
        }

    }
}
