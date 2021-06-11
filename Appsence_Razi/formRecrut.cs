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
using System.Diagnostics;

namespace Appsence_Razi
{
    public partial class formRecrut : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn = new SqlConnection();

        DataSet ds = new DataSet();

        SqlCommand comdspecialite;
        SqlDataAdapter daspecialite;
        BindingSource bsSpecialite = new BindingSource();


        SqlCommand comdrecrut;
        SqlDataAdapter darecrut;
        BindingSource bsrecrut = new BindingSource();

        SqlCommandBuilder combuildrecrut;
        SqlCommandBuilder combuildspecialite;

        Boolean modPic = false;
        public formRecrut()
        {
            InitializeComponent();
        }
        public void activatmod(Boolean v)
        {
            txt_nom.Enabled = v;
            txt_prenom.Enabled = v;
            txt_niveauS.Enabled = v;
            txt_Recherch.Enabled = !v;

            btn_showCV.Visible = !v;
            btn_cv.Visible = v;
            btn_add.Visible = !v;
            btn_edit.Visible = !v;
            btn_delete.Visible = !v;

            btn_validate.Visible = v;
            btn_cancel.Visible = v;
            list_recrute.Enabled = !v;
            Ddw_specialite.Enabled = !v;
        }

        private void formRecrut_Load(object sender, EventArgs e)
        {
            modPic = false;
            cn.ConnectionString = cs;
            cn.Open();

            string req1 = "select * from SPESIALITE";
            comdspecialite = new SqlCommand(req1, cn);
            daspecialite = new SqlDataAdapter(comdspecialite);
            daspecialite.Fill(ds, "SPESIALITE");

            bsSpecialite.DataSource = ds;
            bsSpecialite.DataMember = "SPESIALITE";
            Ddw_specialite.DataSource = bsSpecialite;
            Ddw_specialite.DisplayMember = "LIB_SPECIALITE";
            Ddw_specialite.ValueMember = "ID_SPECIALITE";
            string req2 = "SELECT NOM_RECRUT+' '+PRENOM_RECRUT as [Nom complete],* FROM  RECRUTEMENT";
            comdrecrut = new SqlCommand(req2, cn);
            darecrut = new SqlDataAdapter(comdrecrut);

            combuildrecrut = new SqlCommandBuilder(darecrut);
            combuildspecialite = new SqlCommandBuilder(daspecialite);

            darecrut.Fill(ds, "RECRUTEMENT");
            DataColumn clmFonct = ds.Tables["SPESIALITE"].Columns["ID_SPECIALITE"];
            DataColumn clmPerso = ds.Tables["RECRUTEMENT"].Columns["ID_SPECIALITE"];
            DataRelation relPerso_Fonct = new DataRelation("fk_recrutement_spesialite", clmFonct, clmPerso);
            ds.Relations.Add(relPerso_Fonct);
            bsrecrut.DataSource = bsSpecialite;
            bsrecrut.DataMember = "fk_recrutement_spesialite";
            list_recrute.DataSource = bsrecrut;
            list_recrute.DisplayMember = "Nom complete";
            list_recrute.ValueMember = "ID_RECRUT";

            txt_cv.DataBindings.Add("text", bsrecrut, "CV", true);
            txt_niveauS.DataBindings.Add("text", bsrecrut, "NIVEAU_SCOLAIRE", true);
            txt_nom.DataBindings.Add("text", bsrecrut, "NOM_RECRUT", true);
            txt_prenom.DataBindings.Add("text", bsrecrut, "PRENOM_RECRUT", true);
            DP_dateNaiss.DataBindings.Add("value", bsrecrut, "DATE_NAISSANCE_RECRUT", true);

            
            activatmod(false);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            activatmod(true);
            bsrecrut.AddNew();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            activatmod(true);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer cette personne...! ", "supprission", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bsrecrut.RemoveCurrent();
                darecrut.Update(ds, "RECRUTEMENT");
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "")
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
                  bsrecrut.EndEdit();
                  darecrut.Update(ds, "RECRUTEMENT");
                  activatmod(false);
                }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            bsrecrut.CancelEdit();
            activatmod(false);
        }

        private void DP_dateNaiss_onValueChanged(object sender, EventArgs e)
        {
            lbl_age.Text ="( " +(DateTime.Now.Year-DP_dateNaiss.Value.Year).ToString()+" )";
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            bsrecrut.Filter = "NOM_RECRUT like '"+txt_Recherch.Text+"%' or PRENOM_RECRUT LIKE '"+txt_Recherch.Text+"%' ";
        }

        private void move_first_Click(object sender, EventArgs e)
        {
            bsrecrut.MoveFirst();

        }

        private void move_perview_Click(object sender, EventArgs e)
        {
            if (list_recrute.SelectedIndex == 0)
                bsrecrut.MoveLast();
            else
                bsrecrut.MovePrevious();

        }

        private void move_next_Click(object sender, EventArgs e)
        {
            if (list_recrute.SelectedIndex == list_recrute.Items.Count - 1)
                bsrecrut.MoveFirst();
            else
                bsrecrut.MoveNext();
        }

        private void move_last_Click(object sender, EventArgs e)
        {
            bsrecrut.MoveLast();
        }

        private void btn_cv_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Fname = openFileDialog1.FileName;
                
                txt_cv.Text = Fname;
                modPic = true;
            }
        }

        private void btn_showCV_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"" + txt_cv.Text + "");
            }
            catch (Exception)
            {
            }
            
        }
    }
}
