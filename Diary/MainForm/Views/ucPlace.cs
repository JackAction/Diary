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
    public partial class ucPlace : ucBase
    {
        public ucPlace()
        {
            InitializeComponent();
            ucPicture1.PictureAdded += new EventHandler(PictureAdded);
        }

        [Description("Binding Source für Place."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
            set { placeBindingSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Diary."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
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

        [Description("Neue Zeile wurde zu Place DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler PlaceRowAdded;

        private void dbgrdPlaces_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > placeBindingSource.Count - 1)
            {
                PlaceRowAdded?.Invoke(sender, e);
            }
        }

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > diaryBindingSource.Count - 1)
            {
                Place obj = placeBindingSource.Current as Place; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
                if (obj != null)
                {
                    if (diaryBindingSource.Current != null)
                    {
                        ((Diary)diaryBindingSource.Current).Place = obj;
                    }
                }
                DiaryRowAdded?.Invoke(sender, e);
            }
        }

        public void ShowDiaryEntries()
        {
            Place obj = placeBindingSource.Current as Place; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                if (obj.Diaries != null)
                {
                    diaryBindingSource.DataSource = obj.Diaries.ToList();
                }
            }
        }

        public void ShowPicture()
        {
            Place obj = placeBindingSource.Current as Place; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                ucPicture1.Image = obj.Picture;
            }
        }

        private void dbgrdPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
                ShowPicture();
            }
        }

        private void ucPlace_Load(object sender, EventArgs e)
        {
            ShowDiaryEntries();
            ShowPicture();
        }

        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Session ID muss eine Nummer sein.", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dbgrdPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdPlaces.Columns[e.ColumnIndex].Name == "DeletePlace")
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

        private void PictureAdded(object sender, EventArgs e)
        {
            (placeBindingSource.Current as Place).Picture = ucPicture1.Image;
        }
    }
}
