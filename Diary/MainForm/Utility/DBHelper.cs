using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;

namespace MainForm
{
    public class DBHelper
    {
        public string DBName { get; set; }
        public Server SQLServer { get; }
        public Dictionary<string,string> BackupLocations { get; set; }

        public DBHelper()
            {
                DBName = "dnd_hotdq";
                SQLServer = new Server($"{Environment.MachineName}\\SQLEXPRESS");
                BackupLocations = new Dictionary<string, string>();
                BackupLocations.Add("SSDEVO250", $"C:\\Users\\JackAction\\Dropbox\\_Meins\\DnD\\_DiaryDB\\{DBName}.bak");
                BackupLocations.Add("KLAPPI", $"C:\\Users\\Fabian\\Dropbox\\_Meins\\DnD\\_DiaryDB\\{DBName}.bak");
            }

        /// <summary>
        /// Liefert den Connectionstring zu einer DB zurück.
        /// https://www.codeproject.com/Tips/798392/Changing-Databases-at-Run-time-using-Entity-Framew
        /// </summary>
        /// <returns>Kompletter Connectionstring</returns>
        public String BuildConnectionString()
        {
            String connString = $"data source={ SQLServer.Name };initial catalog={ DBName };integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

            EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
            esb.Metadata = "res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            esb.Provider = "System.Data.SqlClient";
            esb.ProviderConnectionString = connString;

            return esb.ToString();
        }
        /// <summary>
        /// Sichert die Datenbank auf das Dateisystem
        /// </summary>
        public void BackupDB()
        {
            Backup backup = new Backup() { Action = BackupActionType.Database, Database = DBName };
            backup.Devices.AddDevice(BackupLocations[Environment.MachineName], DeviceType.File);
            backup.Initialize = true;
            backup.SqlBackup(SQLServer);
        }
        /// <summary>
        /// Lädt das Datenbankbackup vom Dateisystem
        /// </summary>
        public void RestoreDB()
        {
            SQLServer.KillAllProcesses(DBName);
            Restore restore = new Restore() { Action = RestoreActionType.Database, Database = DBName, NoRecovery = false, ReplaceDatabase = true };
            restore.Devices.AddDevice(BackupLocations[Environment.MachineName], DeviceType.File);
            restore.SqlRestore(SQLServer);
        }
    }
}
