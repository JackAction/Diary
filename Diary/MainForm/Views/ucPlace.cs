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
        }

        [Description("Binding Source für Place."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
            set { placeBindingSource = value; }
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

        private void dbgrdPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
            }
        }
        private void ShowDiaryEntries()
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
        private void ucPlace_Load(object sender, EventArgs e)
        {
            ShowDiaryEntries();
        }
    }
}
