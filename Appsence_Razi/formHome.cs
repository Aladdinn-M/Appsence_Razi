using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appsence_Razi
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }
        
        public void showPanelforms(Boolean v)
        {
            panelforms.Visible = v;
            panelhome.Visible = !v;
        }


        public void chargerform(Form f)
        {
            showPanelforms(true);
            panelforms.Controls.Clear();
            f.TopLevel = false;
            panelforms.Controls.Add(f);
            f.Show();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            showPanelforms(false);
            gunaAnimateWindow1.Start();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            showPanelforms(false);
        }

        private void btnabse_Click(object sender, EventArgs e)
        {
            formAbsence f=new formAbsence();
            chargerform(f);
            
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            formInfo f = new formInfo();
            chargerform(f);
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            formRecrut f = new formRecrut();
            chargerform(f);
        }

        private void btnBIG_Abs_Click(object sender, EventArgs e)
        {
            formAbsence f = new formAbsence();
            chargerform(f);
        }

        private void btnBIG_cv_Click(object sender, EventArgs e)
        {
            formRecrut f = new formRecrut();
            chargerform(f);
        }

        private void btnBIG_info_Click(object sender, EventArgs e)
        {
            formInfo f = new formInfo();
            chargerform(f);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            form_list_ABS f = new form_list_ABS();
            chargerform(f);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            formConnexion f = new formConnexion();
            this.Hide();
            f.ShowDialog();
        }

        private void btnBIG_Abs_Click_1(object sender, EventArgs e)
        {
            formAbsence f = new formAbsence();
            chargerform(f);
        }

        

        private void btnBIG_detaills_Click(object sender, EventArgs e)
        {
            form_list_ABS f = new form_list_ABS();
            chargerform(f);
        }

        private void btnBIG_info_Click_1(object sender, EventArgs e)
        {
            formInfo f = new formInfo();
            chargerform(f);
        }

        private void btnBIG_cv_Click_1(object sender, EventArgs e)
        {
            formRecrut f = new formRecrut();
            chargerform(f);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            form_admin f = new form_admin();
            chargerform(f);
        }
    }
}
