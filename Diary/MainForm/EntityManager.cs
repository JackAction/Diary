using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class EntityManager
    {
        DBHelper dbHelper;
        dnd_hotdqEntities db;

        public EntityManager()
        {
            dbHelper = new DBHelper();
        }

        public void BackupDB()
        {
            dbHelper.BackupDB();
        }
        public void RestoreDB()
        {
            dbHelper.RestoreDB();
        }

        public void LoadDatafromDB()
        {
            db = new dnd_hotdqEntities(dbHelper.BuildConnectionString());
        }

        public async void SaveChangesToDB()
        {
            await db.SaveChangesAsync();
        }

        public void DiscardChanges()
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        public List<Person> GetPersons()
        {
            return db.People.ToList(); //Wird include benötitg? .Include("Clan")
        }

        public List<Diary> GetDiaryEntries()
        {
            return db.Diaries.ToList();
        }

        public List<Place> GetPlaces()
        {
            return db.Places.ToList();
        }

        public List<Clan> GetClans()
        {
            return db.Clans.ToList();
        }

    }


    /// <summary>
    /// Fügt einen Konstruktor zu Model.Context.cs hinzu, welchem ein ConnectionString übergeben werden kann
    /// </summary>
    public partial class dnd_hotdqEntities : DbContext
    {
        public dnd_hotdqEntities(String connString)
            : base(connString)
        {
        }
    }
}
