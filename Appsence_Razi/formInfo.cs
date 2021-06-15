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
using System.Configuration;
using System.IO;

namespace Appsence_Razi
{
    public partial class formInfo : Form
    {
        //========la declaration========//
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn = new SqlConnection();

        DataSet ds = new DataSet();

        SqlCommand comdfonction;
        SqlDataAdapter dafonction;
        BindingSource bsfonction = new BindingSource();


        SqlCommand comdpersonnel;
        SqlDataAdapter daPersonnel;
        BindingSource bspersonnel = new BindingSource();

        SqlCommandBuilder combuildperso;
        SqlCommandBuilder combuildfoncti;

        Boolean modPic=false;
        private string randomName()
        {
            string name;
            Random R = new Random();
            string p2 = R.Next().ToString();

            string p1 = DateTime.Now.ToString("ddMMyyyhhmmss");
            name = p1 + p2;
            return name;
        }

        public void activatMod(Boolean v)
        {
            
            txt_cin.Enabled = v;
            txt_cnss.Enabled = v;
            txt_matricule.Enabled = v;
            txt_nom.Enabled = v;
            txt_prenom.Enabled = v;
            txt_sexe.Enabled = v;
            txt_enfants.Enabled = v;

            btn_add.Visible = !v;
            btn_edit.Visible = !v;
            btn_delete.Visible = !v;
            btn_print.Visible = !v;
            btn_printAll.Visible = !v;

            btn_validate.Visible = v;
            btn_cancel.Visible = v;

            Ddw_fonction.Enabled = !v;
            list_personnel.Enabled = !v;
            btn_printAll.Visible = !v;
            btn_browse.Visible = v;
        } 
       
        public formInfo()
        {
            InitializeComponent();
        }

        private void formInfo_Load(object sender, EventArgs e)
        {
            modPic = false;
            cn.ConnectionString = cs;
            cn.Open();
            
            string req1 = "SELECT * FROM dbo.FONCTION";
            comdfonction = new SqlCommand(req1, cn);
            dafonction = new SqlDataAdapter(comdfonction);
            dafonction.Fill(ds, "FONCTION");

            bsfonction.DataSource = ds;
            bsfonction.DataMember = "FONCTION";
            Ddw_fonction.DataSource = bsfonction;
            Ddw_fonction.DisplayMember = "NOM_POST";
            Ddw_fonction.ValueMember = "ID_FANCTION";
            string req2 = "select PRENOM+' '+NOM as [Nom complete], * from PERSONNEL";
            comdpersonnel = new SqlCommand(req2, cn);
            daPersonnel = new SqlDataAdapter(comdpersonnel);

            combuildperso = new SqlCommandBuilder(daPersonnel);
            combuildfoncti = new SqlCommandBuilder(dafonction);

            daPersonnel.Fill(ds, "PERSONNEL");
            DataColumn clmFonct = ds.Tables["FONCTION"].Columns["ID_FANCTION"];
            DataColumn clmPerso = ds.Tables["PERSONNEL"].Columns["ID_FANCTION"];
            DataRelation relPerso_Fonct = new DataRelation("fk_fonnction_personnel", clmFonct, clmPerso);
            ds.Relations.Add(relPerso_Fonct);
            bspersonnel.DataSource = bsfonction;
            bspersonnel.DataMember = "fk_fonnction_personnel";
            list_personnel.DataSource = bspersonnel;
            list_personnel.DisplayMember = "Nom complete";
            list_personnel.ValueMember = "MATRICULE";

            txt_cin.DataBindings.Add("text",bspersonnel,"CIN",true);
            txt_cnss.DataBindings.Add("text",bspersonnel,"CNSS", true);
            txt_matricule.DataBindings.Add("text",bspersonnel,"MATRICULE", true);
            txt_nom.DataBindings.Add("text",bspersonnel,"NOM", true);
            txt_prenom.DataBindings.Add("text",bspersonnel,"PRENOM", true);
            txt_sexe.DataBindings.Add("text",bspersonnel,"SEXE", true);
            DP_dateNaiss.DataBindings.Add("value",bspersonnel,"DATE_NAISSANCE_PERSO", true);
            DP_dateRecrut.DataBindings.Add("value",bspersonnel,"DATE_RECRUTMENT", true);
            txt_enfants.DataBindings.Add("text",bspersonnel,"ENFANTS", true);
            txt_pic.DataBindings.Add("text",bspersonnel,"IMAGE_PERSO", true);
            txt_idFonction.DataBindings.Add("text",bspersonnel,"ID_FANCTION", true);
            txt_autre.DataBindings.Add("text",bspersonnel,"AUTRE", true);

            try {PICBOX.Load(@"pics\"+txt_pic.Text); } catch { PICBOX.Load(@"pics\shadow-profile.jpg"); }           
            activatMod(false);
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            activatMod(true);
            bspersonnel.AddNew();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            activatMod(true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (modPic == true)
            {
                PICBOX.Load(@"pics\shadow-profile.jpg");
                File.Delete(@"pics\" + txt_pic.Text); 
            }
           
            activatMod(false);
            bspersonnel.CancelEdit();
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (txt_matricule.Text == "")
            {
                txt_matricule.Text = "Ce champ est requis";
            }   
            else
                if(txt_nom.Text=="")
                {
                    txt_nom.Text = "Ce champ est requis";
                }
                else
                    if (txt_prenom.Text == "")
                    {
                        txt_prenom.Text = "Ce champ est requis";
                    }
                    else
                    {
                        bspersonnel.EndEdit();
                        daPersonnel.Update(ds, "PERSONNEL");

                        activatMod(false);
                        modPic = false;
                    }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try { PICBOX.Load(@"pics\" + txt_pic.Text); } catch { PICBOX.Load(@"pics\shadow-profile.jpg"); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer ce persnn...! ", "supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PICBOX.Load(@"pics\shadow-profile.jpg");
                File.Delete(@"pics\" + txt_pic.Text);
                bspersonnel.RemoveCurrent();
                bspersonnel.EndEdit();
                daPersonnel.Update(ds, "PERSONNEL");
            }
                      
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(openFileDialog1.FileName);
                string Fname = randomName()+ext;
                File.Copy(openFileDialog1.FileName, @"pics\" + Fname);
                txt_pic.Text = Fname;
                modPic = true;
            }
        }

        private void move_first_Click(object sender, EventArgs e)
        {
            bspersonnel.MoveFirst();
        }

        private void move_perview_Click(object sender, EventArgs e)
        {

            if (list_personnel.SelectedIndex == 0)
                bspersonnel.MoveLast();
            else
                bspersonnel.MovePrevious();
        }

        private void move_next_Click(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == list_personnel.Items.Count-1)
                bspersonnel.MoveFirst();
            else
                bspersonnel.MoveNext();
        }

        private void move_last_Click(object sender, EventArgs e)
        {
            bspersonnel.MoveLast();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            person_report r = new person_report();
            string filter = "{PERSONNEL.MATRICULE} = " + list_personnel.SelectedValue.ToString();
            PICBOX.Load(@"pics\shadow-profile.jpg");
            form_printing f = new form_printing(r, ds,filter);
            f.ShowDialog();
        }

        private void btn_printAll_Click(object sender, EventArgs e)
        {
             report_all r = new report_all();
            form_printing f = new form_printing(r, ds);
            f.ShowDialog();
        }

        private void DP_dateRecrut_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
