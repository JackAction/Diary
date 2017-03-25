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
            ucDiary1.PlaceAdded += new EventHandler(Place_RowsAdded);
            ucPersons1.PlaceAdded += new EventHandler(Place_RowsAdded);
            ucDiary1.ChangePeopleOfDiaryEntry += new EventHandler(ChangePeopleOfDiaryEntry);
            ucDiary1.ItemAdded += new EventHandler(Item_RowsAdded);
            ucDiary1.QuestAdded += new EventHandler(Quest_RowsAdded);
            ucDiary1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            ucPersons1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            ucPlace1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            ucPersons1.PersonRowDeleted += new EventHandler(Person_RowsDeleted);
            ucClan1.PersonRowDeleted += new EventHandler(Person_RowsDeleted);

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
                applicationState = ApplicationState.DBLoaded;
            }
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson.DataSource = entityManager.GetPersons();
            ucPersons1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucDiary1.DataSourceDiary.DataSource = entityManager.GetDiaryEntries();
            ucDiary1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucClan1.DataSourceClan.DataSource = entityManager.GetClans();
            ucPlace1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucDiary1.DataSourceItem.DataSource = entityManager.GetItems();
            ucDiary1.DataSourceQuest.DataSource = entityManager.GetQuests();
            ucPersons1.DataSourceItem.DataSource = entityManager.GetItems();
            ucPersons1.DataSourceQuest.DataSource = entityManager.GetQuests();
            ucPlace1.DataSourceItem.DataSource = entityManager.GetItems();
            ucPlace1.DataSourceQuest.DataSource = entityManager.GetQuests();
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

                //MessageBox.Show("Save success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (applicationState == ApplicationState.DBLoaded)
            {
                Diary newDiary;
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        newDiary = (Diary)ucDiary1.DataSourceDiary.Current;
                        break;
                    case "tabPerson":
                        newDiary = (Diary)ucPersons1.DataSourceDiary.Current;
                        break;
                    case "tabPlaces":
                        newDiary = (Diary)ucPlace1.DataSourceDiary.Current;
                        break;
                    default:
                        newDiary = null;
                        break;
                }
                // Überschreibe die SessionID mit dem entsprechenden Eingabefeldwert
                if (newDiary != null)
                {
                    newDiary.SessionID = (int)txtSessionID.Value;
                    entityManager.AddDiaryEntry(newDiary); 
                }
            }
        }

        private void Diary_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                Diary deletedDiary;
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        deletedDiary = (Diary)ucDiary1.DataSourceDiary.Current;
                        break;
                    case "tabPerson":
                        deletedDiary = (Diary)ucPersons1.DataSourceDiary.Current;
                        break;
                    case "tabPlaces":
                        deletedDiary = (Diary)ucPlace1.DataSourceDiary.Current;
                        break;
                    default:
                        deletedDiary = new Diary();
                        break;
                }
                if (deletedDiary != null)
                {
                    entityManager.DeleteDiaryEntry(deletedDiary);
                }
            }
        }

        private void Clan_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                entityManager.AddClanEntry((Clan)ucClan1.DataSourceClan.Current);
            }
        }

        private void Person_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
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

        private void Person_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabPerson":
                        entityManager.DeletePersonEntry((Person)ucPersons1.DataSourcePerson.Current);
                        break;
                    case "tabClans":
                        entityManager.DeletePersonEntry((Person)ucClan1.DataSourcePerson.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Place_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddPlaceEntry(ucDiary1.NewPlace);
                        btnSave_Click(null, null);
                        break;
                    case "tabPerson":
                        entityManager.AddPlaceEntry(ucPersons1.NewPlace);
                        btnSave_Click(null, null);
                        break;
                    case "tabPlaces":
                        entityManager.AddPlaceEntry((Place)ucPlace1.DataSourcePlace.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Item_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddItemEntry(ucDiary1.NewItem);
                        btnSave_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Quest_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddQuestEntry(ucDiary1.NewQuest);
                        btnSave_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ChangePeopleOfDiaryEntry(object sender, EventArgs e)
        {
            mstControl.SelectTab("tabPerson");
            tmp = ucPersons1.DataSourceDiary;
            ucPersons1.DataSourceDiary = ucDiary1.DataSourceDiary;
            currentDiary = ucDiary1.DataSourceDiary.Current as Diary;
            ucPersons1.AddCheckboxesToPersonList();
            btnAddPeopleToDiary.Visible = true;
            mstControl.TabPages.Remove(tabDiary);
            mstControl.TabPages.Remove(tabClans);
            mstControl.TabPages.Remove(tabPlaces);
        }

        private BindingSource tmp;
        private Diary currentDiary;

        private void btnAddPeopleToDiary_Click(object sender, EventArgs e)
        {
            if (currentDiary != null)
            {
                currentDiary.People = ucPersons1.GetCheckedPeople(); 
            }
            ucPersons1.DataSourceDiary = tmp;
            ucPersons1.setNormalMode();
            btnAddPeopleToDiary.Visible = false;
            mstControl.TabPages.Insert(0, tabDiary);
            mstControl.TabPages.Insert(2, tabClans);
            mstControl.TabPages.Insert(3, tabPlaces);
            mstControl.SelectTab("tabDiary");
        }

        /// <summary>
        /// Event Handler bei Tab-wechsel: Benötigt um zusätzliche Datagrids zu aktualisieren aufgrund aktuell selektierter Zeile in Hauptdatagrid des Tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mstControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Damit alles in DB gespeichert wird und aktuell ist 
            if (applicationState == ApplicationState.DBLoaded)
            {
                btnSave_Click(null, null); 
            }

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
