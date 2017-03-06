using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainFormDisplay : Form
    {
        private ApplicationState applicationState;
        EntityManager entityManager;

        public MainFormDisplay()
        {
            applicationState = ApplicationState.Starting;
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            entityManager = new EntityManager();

            if (Environment.MachineName == "KLAPPI")
            {
                WindowState = FormWindowState.Maximized; 
            }

            // Delegate Eventhandlers von User Controls
            ucDiary1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);
            ucClan1.ClanRowAdded += new EventHandler(Clan_RowsAdded);
            ucClan1.PersonRowAdded += new EventHandler(Person_RowsAdded);
            ucPersons1.PersonRowAdded += new EventHandler(Person_RowsAdded);
            ucPersons1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);
            ucPlace1.PlaceRowAdded += new EventHandler(Place_RowsAdded);
            ucPlace1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);

            applicationState = ApplicationState.Started;
        }

        /// <summary>
        /// Event Handler Button: Datenbankbackup auf Dropbox speichern.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            entityManager.BackupDB();
        }

        /// <summary>
        /// Event Handler Button: Lokale Datenbank laden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                applicationState = ApplicationState.DBInteraction;
                entityManager.LoadDatafromDB();
                setDatasourcess();
                mstControl_SelectedIndexChanged(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                applicationState = ApplicationState.Started;
            }
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson.DataSource = entityManager.GetPersons();
            ucDiary1.DataSourceDiary.DataSource = entityManager.GetDiaryEntries();
            ucClan1.DataSourceClan.DataSource = entityManager.GetClans();
            ucPlace1.DataSourcePlace.DataSource = entityManager.GetPlaces();
        }

        /// <summary>
        /// Event Handler Button: Datenbankbackup von Dropbox laden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadDBBackup_Click(object sender, EventArgs e)
        {
            entityManager.RestoreDB();
            btnLoadDB_Click(null,null);
        }

        /// <summary>
        /// Event Handler Button: Lokale Datenbank sichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                entityManager.SaveChangesToDB(); // Führt die änderungen auf dem db c# objekt effektiv auf der DB aus

                MessageBox.Show("Save success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setDatasourcess();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            entityManager.DiscardChanges();
            setDatasourcess();
        }

        private void Diary_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddDiaryEntry((Diary)ucDiary1.DataSourceDiary.Current);
                        break;
                    case "tabPerson":
                        entityManager.AddDiaryEntry((Diary)ucPersons1.DataSourceDiary.Current);
                        break;
                    case "tabPlaces":
                        entityManager.AddDiaryEntry((Diary)ucPlace1.DataSourceDiary.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Clan_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                entityManager.AddClanEntry((Clan)ucClan1.DataSourceClan.Current);
            }
        }

        private void Person_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabPerson":
                        entityManager.AddPersonEntry((Person)ucPersons1.DataSourcePerson.Current);
                        break;
                    case "tabClans":
                        entityManager.AddPersonEntry((Person)ucClan1.DataSourcePerson.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Place_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                entityManager.AddPlaceEntry((Place)ucPlace1.DataSourcePlace.Current);
            }
        }

        /// <summary>
        /// Event Handler bei Tab-wechsel: Benötigt um zusätzliche Datagrids zu aktualisieren aufgrund aktuell selektierter Zeile in Hauptdatagrid des Tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mstControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mstControl.SelectedTab.Name)
            {
                case "tabDiary":
                    // Zurzeit kein weiteres Datagrid, somit nicht benötigt.
                    break;
                case "tabPerson":
                    ucPersons1.ShowDiaryEntries();
                    break;
                case "tabPlaces":
                    ucPlace1.ShowDiaryEntries();
                    break;
                case "tabClans":
                    ucClan1.ShowMembers();
                    ucClan1.ShowDiaryEntries();
                    break;
                default:
                    break;
            }
        }
    }
}
