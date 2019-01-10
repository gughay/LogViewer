using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LogViewer.Controllers
{
    public class SqlEditorController : Controller
    {
        public List<CustomTable> MultySelect(string query)
        {
            query = query.Replace('@', ' ');
            DataSet result = new DataSet();
            List<CustomTable> tables = new List<CustomTable>();
            using (SqlCommand command = new SqlCommand())
            {
                var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                var queryString = query;
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                tables = fillTables(dataSet);
                conn.Close();
            }
            return tables;
        }

        static List<CustomTable> fillTables(DataSet dataSet)
        {
            List<CustomTable> tables = new List<CustomTable>();
            CustomTable tbl = new CustomTable();

            for (var i = 0; i < dataSet.Tables.Count; i++)
            {
                tbl = new CustomTable();
                tbl.Name = "Table" + i.ToString();
                tbl.Columns = new List<string>();
                tbl.Rows = new List<List<string>>();
                for (int j = 0; j < dataSet.Tables[i].Columns.Count; j++)
                {
                    tbl.Columns.Add(dataSet.Tables[i].Columns[j].ColumnName);
                }
                for (int k = 0; k < dataSet.Tables[i].Rows.Count; k++)
                {
                    var row = new List<string>();
                    for (int t = 0; t < tbl.Columns.Count; t++)
                    {
                        row.Add(dataSet.Tables[i].Rows[k][t].ToString());
                    }
                    tbl.Rows.Add(row);
                }
                tables.Add(tbl);
            }
            return tables;
        }


    }


    public class CustomTable
    {
        public string Name { get; set; }
        public List<string> Columns { get; set; }
        public List<List<string>> Rows { get; set; }
    }
}
