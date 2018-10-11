using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace ConsoleApp1
{
   public  class DataAccess
    {
        private SQLiteConnection sqlite;

        private string GetFullPathFromDataBase()
        {
            string startupPath = Directory.GetCurrentDirectory();
            string dbFile = @"\Data\mydb2.db";
            return startupPath + dbFile;
        }

        public DataAccess()
        {
            string dbPath = GetFullPathFromDataBase();
            sqlite = new SQLiteConnection(@"Data Source="+dbPath);
        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                sqlite.Open();  //Initiate connection to the db
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetInt32(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
            }
            finally
            {
                sqlite.Close();
            }
            return dt;
        }
    }
    }