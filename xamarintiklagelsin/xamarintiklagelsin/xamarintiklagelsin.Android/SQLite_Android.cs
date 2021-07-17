using SQLite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xamarintiklagelsin.Models;
using Xamarin.Forms;
using xamarintiklagelsin.Droid;

[assembly:Dependency(typeof(SQLite_Android))]
namespace xamarintiklagelsin.Droid
{
    public class SQLite_Android :ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}