﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDataBase
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
