﻿using System;
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
            DBHelper.dbName = "dnd_hotdq";
            db = new dnd_hotdqEntities(DBHelper.BuildConnectionString($"{Environment.MachineName}\\SQLEXPRESS", DBHelper.dbName));
            ucPersons1.DataSourcePerson = db.People.ToList(); //Wird include benötitg? .Include("Clan")
            ucDiary1.DataSourceDiary = db.Diaries.ToList();
            ucClan1.DataSourceClan = db.Clans.ToList();
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            DBHelper.BackupDB();
        }
    }
}
