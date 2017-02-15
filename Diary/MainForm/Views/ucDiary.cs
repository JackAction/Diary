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
        }

        public object DataSourceDiary
        {
            get { return diaryBindingSource.DataSource; }
            set { diaryBindingSource.DataSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }
    }
}
