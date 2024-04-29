using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ado.Net_WebFrom
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "server = SUNITATHAKKAR; Initial Catalog = HRM; Integrated Security=true ";
            SqlConnection sqlcon = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Sp_GetEmpDetails", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlcon.Close();
        }

        protected void Unnamed1_SelectionChanged(object sender, EventArgs e)
        {
            lblDOJ.Text = "You Selected: " + DOJ.SelectedDate.ToString("D");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "server = SUNITATHAKKAR; Initial Catalog = HRM; Integrated Security=true ";
            SqlConnection sqlcon = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("SP_InsertUpdateDeleteEmp", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Insert");
            cmd.Parameters.AddWithValue("@EmpName", TextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@DOJ", DOJ.SelectedDate.ToString());
            cmd.Parameters.AddWithValue("@DeptID", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(TextBox3.Text.ToString()));
            cmd.Parameters.AddWithValue("@WorkingPlace", TextBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@Age", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Gender", TextBox6.Text.ToString());
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            LabelSave.Visible = true;
            LabelSave.Text = "Records are Submitted Successfully";
        }

        protected void Button_Update(object sender, EventArgs e)
        {
            string str = "server = SUNITATHAKKAR; Initial Catalog = HRM; Integrated Security=true ";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            int id = int.Parse(TextBox7.Text.ToString());
            SqlCommand cmd = new SqlCommand("SP_InsertUpdateDeleteEmp", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Action", "Update");
            cmd.Parameters.AddWithValue("@EmpName", TextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@DOJ", DOJ.SelectedDate.ToString());
            cmd.Parameters.AddWithValue("@DeptID", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Salary", int.Parse(TextBox3.Text.ToString()));
            cmd.Parameters.AddWithValue("@WorkingPlace", TextBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@Age", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Gender", TextBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@EmpID", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Sp_GetEmpDetails", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlcon.Close();
        }
    }
}

