using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace xamarintiklagelsin.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
