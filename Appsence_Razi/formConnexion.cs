using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Appsence_Razi
{
    public partial class formConnexion : Form
    {
        
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand comd_login;
        public formConnexion()
        {
            InitializeComponent();
        }

        private void formConnexion_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
        }

       

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string req = "select * from users where username = @login and [mot de passe]=@pswd ";
            comd_login = new SqlCommand(req,cn);
            comd_login.Parameters.Add(new SqlParameter("@login", txt_login.Text));
            comd_login.Parameters.Add(new SqlParameter("@pswd", txt_password.Text));

            SqlDataReader dr = comd_login.ExecuteReader();
            if (dr.Read())
            {
                Program.activeUser = dr[3].ToString();
                this.Hide();
                formHome f = new formHome();
                f.ShowDialog();
            }
            else
            {
                lbl_error.Text = "login ou mot de passe incorrecte...!";
                lbl_error.ForeColor = Color.Red;
            }
            cn.Close();

        }

        private void txt_login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_connect.PerformClick();
            
        }
        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btn_connect.PerformClick();
        }

        private void txt_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_error.Text = "";
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_error.Text = "";
        }

        
    }
}
