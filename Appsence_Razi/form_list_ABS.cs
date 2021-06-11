using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;
using System.Data.SqlClient;


namespace Appsence_Razi
{
    public partial class form_list_ABS : Form
    {
        //========la declaration========//
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn = new SqlConnection();
        SqlCommand comd_fonc;
        SqlCommand comd_perso;
        SqlCommand comd_ID;
        SqlCommand comd_dates;
        SqlCommand comd_NBabs;
        SqlCommand comd_ABSdetails;
        SqlCommand comd_PersoDetails;

        private string get_Matricule(string selected_text)
        {
            
            string req = " select Matricule from PERSONNEL where NOM+' '+PRENOM ='" + selected_text + "'";
            comd_ID = new SqlCommand(req, cn);
            string id = comd_ID.ExecuteScalar().ToString();
            
            return id;
        }

        private void rempli_DDW(string req, SqlCommand comd, Bunifu.UI.WinForms.BunifuDropdown ddw)
        {
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                ddw.Items.Add(dr[1]);
            }
            dr.Close();
            dr = null;
        }
        private void rempli_list(string req, SqlCommand comd, ListBox list)
        {
            list.Items.Clear();
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                list.Items.Add(dr[0]);
            }

            dr.Close();
            dr = null;
        }
        public form_list_ABS()
        {
            InitializeComponent();
        }

        private void form_list_ABS_Load(object sender, EventArgs e)
        {
            var months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < months.Length; i++)
            {
                ddw_months.Items.Add(months[i]);
            }
            cn = new SqlConnection(cs);
            cn.Open();
            rempli_DDW("select * from FONCTION", comd_fonc, Ddw_fonction);
            string req1 = "select distinct NOM+' '+PRENOM  as [Nom complete] from PERSONNEL p inner join ABSANCE a on p.MATRICULE=a.MATRICULE";
            rempli_list(req1, comd_perso, list_personnel);
            Ddw_fonction.SelectedIndex = 0;
            cn.Close();
        }

        

        private void list_personnel_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                ddw_months.SelectedIndex = -1;
                cn = new SqlConnection(cs);
                cn.Open();
                string req = "select date_debut from ABSANCE where matricule =" + get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem)) + ";";
                rempli_list(req, comd_dates, list_date);
                

                req= "select count(*) from ABSANCE where MATRICULE ="+ get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem)) + ";";
                comd_NBabs = new SqlCommand(req,cn);
                txt_NBabs.Text= comd_NBabs.ExecuteScalar().ToString();
                if (int.Parse(txt_NBabs.Text) > 10)
                {
                    txt_NBabs.ForeColor = Color.White;
                    txt_NBabs.BackColor = Color.FromArgb(255, 128, 128);

                }
                else
                if (int.Parse(txt_NBabs.Text) > 6)
                {
                    txt_NBabs.ForeColor = Color.White;
                    txt_NBabs.BackColor = Color.FromArgb(255, 192, 128);
                }
                else
                if (int.Parse(txt_NBabs.Text) > 2)
                {
                    txt_NBabs.ForeColor = Color.White;
                    txt_NBabs.BackColor = Color.PaleGreen;
                }
                else
                    txt_NBabs.BackColor = Color.Transparent;
                    txt_NBabs.ForeColor = Color.FromArgb(72, 130, 158);


                string req2 = "select * from PERSONNEL where matricule =" + get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem)) ;
                comd_PersoDetails = new SqlCommand(req2, cn);
                SqlDataReader dr = comd_PersoDetails.ExecuteReader();
                while (dr.Read())
                {
                    txt_cin.Text = dr[2].ToString();
                    txt_cnss.Text = dr[5].ToString();
                    txt_matricule.Text = dr[0].ToString();
                }
                cn.Close();
                txt_commmentaire.Text = "";
                txt_type_abs.Text = "";

            }
            catch (Exception)
            {
            }

        }

        private void Ddw_fonction_SelectedValueChanged(object sender, EventArgs e)
        {
            ddw_months.SelectedIndex = -1;
            if (list_personnel.SelectedIndex == -1)
            {
                list_date.Items.Clear();
            }
            cn = new SqlConnection(cs);
            cn.Open();
            string req = "select distinct NOM+' '+PRENOM  as [Nom complete] from PERSONNEL p inner join ABSANCE a on p.MATRICULE=a.MATRICULE  where ID_FANCTION in (select ID_FANCTION from FONCTION where NOM_POST = '" + list_personnel.GetItemText(Ddw_fonction.SelectedItem) + "');";
            rempli_list(req, comd_perso, list_personnel);
            cn.Close();
            txt_NBabs.Text = "";
        }

        private void ddw_months_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_type_abs.Text = "";
            txt_commmentaire.Text ="";
            cn = new SqlConnection(cs);
            cn.Open();
            string req = "select date_debut from ABSANCE where matricule =" + get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem)) + "and Datename(MONTH,date_debut)='"+ddw_months.GetItemText(ddw_months.SelectedItem)+"';";
            rempli_list(req, comd_dates, list_date);
            cn.Close();

        }
        
        private void list_date_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_type_abs.Text = "";
            txt_commmentaire.Text = "";
            cn = new SqlConnection(cs);
            cn.Open();
            string req = "select LIB_TYPE ,COMMENTAIRE from ABSANCE a inner join TYPE_ABS t on a.ID_TYPEABS=t.ID_TYPEABS where a.date_debut='"+list_date.GetItemText(list_date.SelectedItem)+"' and   MATRICULE=" + get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem)) ;
            comd_ABSdetails = new SqlCommand(req, cn);
            SqlDataReader dr = comd_ABSdetails.ExecuteReader();

            while (dr.Read())
            {
                txt_type_abs.Text = dr[0].ToString();
                txt_commmentaire.Text = dr[1].ToString();
            }

            cn.Close();
        }

        
    }
}
