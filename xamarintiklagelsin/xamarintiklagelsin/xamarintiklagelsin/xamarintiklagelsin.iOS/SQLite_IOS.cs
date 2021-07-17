using Foundation;
using SQLite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using xamarintiklagelsin.Models;
using Xamarin.Forms;
using xamarintiklagelsin.iOS;

[assembly:Dependency(typeof(SQLite_IOS))]
namespace xamarintiklagelsin.iOS
{
    public class SQLite_IOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}