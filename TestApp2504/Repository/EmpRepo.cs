using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestApp2504.Models;

namespace TestApp2504.Repository
{
    public class EmpRepo
    {
        private SqlConnection con;

        private void Connection()
        {
            string strcon = ConfigurationManager.ConnectionStrings["TestHRM"].ConnectionString;
            con = new SqlConnection(strcon);
        }

        public bool ADDEmployee(EmployeeModel objempmodel)
        {
            Connection();

            SqlCommand cmd = new SqlCommand("SP_InsertEmpDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", objempmodel.EMPId);
            cmd.Parameters.AddWithValue("@EmpName", objempmodel.EmpName);
            cmd.Parameters.AddWithValue("@DOJ", objempmodel.DOJ);
            cmd.Parameters.AddWithValue("@DeptID", objempmodel.DeptID);
            cmd.Parameters.AddWithValue("@Salary", objempmodel.salary);
            cmd.Parameters.AddWithValue("@WorkingPlace" , objempmodel.WorkingPlace);
            cmd.Parameters.AddWithValue("@Age" , objempmodel.AGE);
            cmd.Parameters.AddWithValue("@Gender", objempmodel.Gender);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<EmployeeModel> GetEmployees()
        {
            Connection();
            List<EmployeeModel> EmployeesList = new List<EmployeeModel>();

            SqlCommand cmd = new SqlCommand("Sp_GetEmpDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure ;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sda.Fill(dt);
            con.Close() ;

            foreach (DataRow dr in dt.Rows)
            {
                EmployeesList.Add(
                    new EmployeeModel()
                    {
                        EMPId = Convert.ToInt32(dr["EmpID"]),
                        EmpName = Convert.ToString(dr["EmpName"]),
                        DOJ = Convert.ToDateTime(dr["DOJ"]),
                        DeptID= Convert.ToInt32(dr["DeptId"]),
                        salary = Convert.ToDecimal(dr["Salary"]),
                        WorkingPlace = Convert.ToString(dr["WorkingPlace"]),
                        AGE = Convert.ToInt32(dr["Age"]),
                        Gender = Convert.ToString(dr["Gender"])
              
                    });

            }
            return EmployeesList;
        }

        public bool UpdateEmployee(EmployeeModel objempmodel)
        {
            Connection();

            SqlCommand cmd = new SqlCommand("SP_UpdateEmpDetails", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", objempmodel.EMPId);
            cmd.Parameters.AddWithValue("@EmpName", objempmodel.EmpName);
            cmd.Parameters.AddWithValue("@DOJ", objempmodel.DOJ);
            cmd.Parameters.AddWithValue("@DeptID", objempmodel.DeptID);
            cmd.Parameters.AddWithValue("@Salary", objempmodel.salary);
            cmd.Parameters.AddWithValue("@WorkingPlace", objempmodel.WorkingPlace);
            cmd.Parameters.AddWithValue("@Age", objempmodel.AGE);
            cmd.Parameters.AddWithValue("@Gender", objempmodel.Gender);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee( int id)
        {
            Connection();
            SqlCommand com = new SqlCommand("SP_DeleteEmpById", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpID", id);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close ();
            if(i >= 1)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

        public bool GetEmployeeByID(EmployeeModel objEmpModel)
        {
            Connection();
            SqlCommand com = new SqlCommand("SP_GetEmpDetailsByID", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@EmpID",objEmpModel.EMPId);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}