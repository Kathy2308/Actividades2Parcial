﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Template_Method
{
    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
}
