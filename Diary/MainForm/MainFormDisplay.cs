using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainFormDisplay : Form
    {
        dnd_hotdqEntities db;
        DBHelper dbHelper;
        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            dbHelper = new DBHelper();
            db = new dnd_hotdqEntities(dbHelper.BuildConnectionString());
            ucPersons1.DataSourcePerson = db.People.ToList(); //Wird include benötitg? .Include("Clan")
            ucDiary1.DataSourceDiary = db.Diaries.ToList();
            ucClan1.DataSourceClan = db.Clans.ToList();
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            dbHelper.BackupDB();
        }
    }
}
