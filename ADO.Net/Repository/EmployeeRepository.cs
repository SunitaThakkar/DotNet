using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO.Net.Repository
{
    public class EmployeeRepository
    {
        private SqlConnection Con;

        private void Connection()
        {
            string str = ConfigurationManager.ConnectionStrings["myCon"].ToString();
            Con = new SqlConnection();
        }

        public bool AddEmployee()
        {

        }
    }
}