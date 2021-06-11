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
    public partial class form_admin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn = new SqlConnection();

        DataSet ds = new DataSet();

        SqlCommand comduser;
        SqlDataAdapter da_user;
        BindingSource bs_user = new BindingSource();
        SqlCommandBuilder cmd_builder ;


        public form_admin()
        {
            InitializeComponent();
        }
        public void activatmod(Boolean v)
        {
            txt_login.Enabled = v;
            txt_password.Enabled = v;
            txt_type.Enabled = v;
            
            btn_add.Visible = !v;
            btn_edit.Visible = !v;
            btn_delete.Visible = !v;

            btn_validate.Visible = v;
            btn_cancel.Visible = v;
            list_users.Enabled = !v;
        }
        private void form_admin_Load(object sender, EventArgs e)
        {
            
            cn.ConnectionString = cs;
            cn.Open();

            string req1 = "select * from users";
            comduser = new SqlCommand(req1, cn);
            da_user = new SqlDataAdapter(comduser);
            da_user.Fill(ds, "users");

            bs_user.DataSource = ds;
            bs_user.DataMember = "users";
            list_users.DataSource = bs_user;
            list_users.DisplayMember = "username";
            list_users.ValueMember = "id";
            cmd_builder = new SqlCommandBuilder(da_user);
            txt_login.DataBindings.Add("text", bs_user, "username",true);
            txt_password.DataBindings.Add("text", bs_user, "mot de passe",true);
            txt_type.DataBindings.Add("text", bs_user, "type_user",true);

            activatmod(false);


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            activatmod(true);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            activatmod(true);
            bs_user.AddNew();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer cet utilisateur...! ", "supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bs_user.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            bs_user.EndEdit();
            activatmod(false);
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "")
            {
                txt_login.Text = "Ce champ est requis";
            }
            else
                   if (txt_password.Text == "")
            {
                txt_password.Text = "Ce champ est requis";
            }
            else
            {
                bs_user.EndEdit();
                da_user.Update(ds,"users");
                activatmod(false);
            }
        }

        private void move_first_Click(object sender, EventArgs e)
        {
            bs_user.MoveFirst();
        }

        private void move_perview_Click(object sender, EventArgs e)
        {
            bs_user.MoveLast();
        }

        private void move_next_Click(object sender, EventArgs e)
        {
            bs_user.MoveNext();
        }

        private void move_last_Click(object sender, EventArgs e)
        {
            bs_user.MoveLast();
        }


    }
}
