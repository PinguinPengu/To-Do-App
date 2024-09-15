using System;
using System.Data.SQLite;
using System.IO;

namespace Aufgabenverwaltungssystem.Core
{
    internal class TaskDatabase
    {
        public SQLiteConnection myConnection;

        public TaskDatabase()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");

            if (!File.Exists("./database.sqlite3"))
            {
                Console.WriteLine("Database Created");
                SQLiteConnection.CreateFile("database.sqlite3");

                myConnection.Open();

                string createEintraegeTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Eintraege (
                        Titel TEXT PRIMARY KEY,
                        Beschreibung TEXT,
                        Datum TEXT NOT NULL,
                        Priorität INTEGER NOT NULL,
                        Status INTEGER NOT NULL
                    );";

                var command = new SQLiteCommand(createEintraegeTableQuery, myConnection);
                command.ExecuteNonQuery();


                Console.WriteLine("Table 'Eintraege' created successfully.");


                myConnection.Close();
            }
        }
    }
}
