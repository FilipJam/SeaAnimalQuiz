﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SeaAnimalsQuiz
{
    public interface IDatabase
    {
        OleDbConnection GetConnection();
    }
}
