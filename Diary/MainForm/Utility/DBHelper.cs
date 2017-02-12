using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public static class DBHelper
    {
        public static string dbName { get; set; }

        /// <summary>
        /// Liefert den Connectionstring zu einer DB zurück.
        /// https://www.codeproject.com/Tips/798392/Changing-Databases-at-Run-time-using-Entity-Framew
        /// </summary>
        /// <param name="DataSource">SQL Server Name</param>
        /// <param name="Database">Name der DB</param>
        /// <returns></returns>
        public static String BuildConnectionString(String DataSource, String Database)
        {
            // Build the connection string from the provided datasource and database
            String connString = $"data source={ DataSource };initial catalog={ Database };integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

            // Build the MetaData... feel free to copy/paste it from the connection string in the config file.
            EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
            esb.Metadata = "res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            esb.Provider = "System.Data.SqlClient";
            esb.ProviderConnectionString = connString;

            // Generate the full string and return it
            return esb.ToString();
        }

        public static void BackupDB()
        {
            Server server = new Server($"{Environment.MachineName}\\SQLEXPRESS");
            Backup backup = new Backup() { Action = BackupActionType.Database, Database = dbName };
            backup.Devices.AddDevice(@"C:\Users\JackAction\Dropbox\_Meins\DnD\_DiaryDB\dnd_hotdq.bak", DeviceType.File);
            backup.Initialize = true;
            backup.SqlBackup(server);
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
