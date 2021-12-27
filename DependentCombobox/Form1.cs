using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependentCombobox
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MY-PC;Initial Catalog=Practice_Demo;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=MY-PC;Initial Catalog=Practice_Demo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select State_Name from Demo_2", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_State.Items.Add(dr["State_Name"].ToString());
            }

            con.Close();
        }
       

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            if(tb_Name.Text != "" && cmb_State.Text != "" && cmb_District.Text != "" && cmb_Taluka.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Demo_1 (Name,State,District,Taluka) values ('"+ tb_Name.Text +"','"+ cmb_State.Text +"','"+ cmb_District.Text +"','"+ cmb_Taluka.Text +"')",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Saved Sucessfully");
                tb_Name.Text = "";
                cmb_State.Text = "";
                cmb_District.Text = "";
                cmb_Taluka.Text = "";
                tb_Name.Focus();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields");
                tb_Name.Text = "";
                cmb_State.Text = "";
                cmb_District.Text = "";
                cmb_Taluka.Text = "";
                tb_Name.Focus();
            }


            con.Close();
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_District.Text = "";
            cmb_District.Items.Clear();
            if(cmb_State.Text != null)
            {
                SqlConnection con = new SqlConnection("Data Source=MY-PC;Initial Catalog=Practice_Demo;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select State_ID from Demo_2 where State_Name = '" + cmb_State.Text + "'", con);
                con.Open();

                var id = cmd.ExecuteScalar();

                cmd = new SqlCommand("select District_Name from Demo_3 where State_ID = " + id + "", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_District.Items.Add(dr["District_Name"].ToString());
                }

                con.Close();
            }
            
        }

        private void cmb_District_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Taluka.Text = "";
            cmb_Taluka.Items.Clear();
            if (cmb_District.Text != null)
            {
                SqlConnection con = new SqlConnection("Data Source=MY-PC;Initial Catalog=Practice_Demo;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select District_ID from Demo_3 where District_Name = '" + cmb_District.Text + "'", con);
                con.Open();

                var id = cmd.ExecuteScalar();

                cmd = new SqlCommand("select Taluka_Name from Demo_4 where District_ID = " + id + "", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Taluka.Items.Add(dr["Taluka_Name"].ToString());
                }

                con.Close();
            }
        }
    }
}
