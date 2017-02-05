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
        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            db = new dnd_hotdqEntities();
            ucPersons1.DataSourcePerson = db.People.Include("Clan").ToList(); //Wird include benötitg?
        }
    }
}
