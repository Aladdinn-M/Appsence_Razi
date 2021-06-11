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
using Bunifu.UI.WinForms;
using Bunifu.Framework.UI;
using System.Globalization;



namespace Appsence_Razi
{
    public partial class formAbsence : Form
    {
        //========la declaration========//
        string cs = ConfigurationManager.ConnectionStrings["Appsence_razi"].ConnectionString;
        SqlConnection cn= new SqlConnection();
        SqlCommand comd_fonc;
        SqlCommand comd_perso;
        SqlCommand comd_typsABS;
        SqlCommand comd_ID;
        SqlCommand comd_markABS;

        private int get_IDfonction(string selected_text)
        {
            cn.Open();
            string req = "select ID_FANCTION from FONCTION where NOM_POST= '"+selected_text+"'";
            comd_ID = new SqlCommand(req,cn);
            int id= Convert.ToInt32(comd_ID.ExecuteScalar());
            cn.Close();
            return id;
            
        }
        private string IDtype()
        {
            if (Ddw_type.SelectedIndex == 0)
                return "1";
            else
                if (Ddw_type.SelectedIndex == 1)
                    return "2";
                else
                    if (Ddw_type.SelectedIndex == 2)
                        return "3";
                    else
                        return "-1";
        }


        private string get_Matricule(string selected_text)
        {
            cn.Open();
            string req = " select Matricule from PERSONNEL where NOM+' '+PRENOM ='"+selected_text+"'";
            comd_ID = new SqlCommand(req,cn);
            string id = comd_ID.ExecuteScalar().ToString();
            cn.Close();
            return id;
        }

        private string selected_DAY_date(string day)
        {
            string y = DateTime.Now.Year.ToString();
            string m = ddw_months.GetItemText(ddw_months.SelectedItem);

            return m + " " + day + "," + y;

        }
        private void checkABS(string req)
        {
            try
            {
                cn.Open();
                comd_markABS = new SqlCommand(req, cn);
                comd_markABS.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception){            }
            
        }
        private void verifier_check(BunifuCheckbox ch)
        {
            if (Ddw_fonction.SelectedIndex == -1)
                MessageBox.Show("selectionner la fonction !!! ");
            else
                        
            {
                ch.Enabled = true;
            }
        }
        
        
        private void rempli_DDW(string req ,SqlCommand comd , Bunifu.UI.WinForms.BunifuDropdown ddw)
        {
            comd = new SqlCommand(req,cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                ddw.Items.Add(dr[1]);
            }
            dr.Close();
            dr = null;
        }
        private void rempli_listPersonne(string req, SqlCommand comd, ListBox list)
        {
            list.Items.Clear();
            comd = new SqlCommand(req, cn);
            SqlDataReader dr = comd.ExecuteReader();
            while (dr.Read())
            {
                list.Items.Add(dr["Nom complete"]);
            }

            dr.Close();
            dr = null;
        }
        public void uncheckedAll()
        {
            j1.Checked = false; j2.Checked = false;
            j3.Checked = false; j4.Checked = false;
            j5.Checked = false; j6.Checked = false;
            j7.Checked = false; j8.Checked = false;
            j9.Checked = false; j10.Checked = false;
            j11.Checked = false; j12.Checked = false;
            j13.Checked = false; j14.Checked = false;
            j15.Checked = false; j16.Checked = false;
            j17.Checked = false; j18.Checked = false;
            j19.Checked = false; j20.Checked = false;
            j21.Checked = false; j22.Checked = false;
            j23.Checked = false; j24.Checked = false;
            j25.Checked = false; j26.Checked = false;
            j27.Checked = false; j28.Checked = false;
            j29.Checked = false; j30.Checked = false;
            j31.Checked = false;
        }

        public formAbsence()
        {
            InitializeComponent();
        }
        private void formAbsence_Load(object sender, EventArgs e)
        {
            var months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < months.Length; i++)
            {
                ddw_months.Items.Add(months[i]);
            }
            ddw_months.SelectedIndex = (DateTime.Now.Month)-1;


            cn = new SqlConnection(cs);
            cn.Open();
            rempli_DDW("select * from FONCTION", comd_fonc, Ddw_fonction);

            string req = "select NOM+' '+PRENOM  as [Nom complete] from PERSONNEL";
            rempli_listPersonne(req, comd_perso, list_personnel);

            rempli_DDW("select * from TYPE_ABS", comd_typsABS, Ddw_type);
            cn.Close();

            bunifuDataGridView1.Rows.Add();
            bunifuDataGridView2.Rows.Add();
            Ddw_fonction.SelectedIndex = 0;
        }
        private void Ddw_fonction_SelectedValueChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            string req = "select NOM+' '+PRENOM  as [Nom complete]  from PERSONNEL where ID_FANCTION in (select ID_FANCTION from FONCTION where NOM_POST = '"+ list_personnel.GetItemText( Ddw_fonction.SelectedItem)+"'); ";
            rempli_listPersonne(req, comd_perso, list_personnel);
           
            cn.Close();
        }

        private void j1_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j1.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j1.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j1.Checked = false;
            }
            else
            {
                string day = "1";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j1.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);
                }

            }


        }

        private void j2_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j2.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j2.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j2.Checked = false;
            }
            else
            {
                string day = "2";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j2.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j3_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j3.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j3.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j3.Checked = false;
            }
            else
            {
                string day = "3";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j3.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j4_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j4.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j4.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j4.Checked = false;
            }
            else
            {
                string day = "4";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j4.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j5_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j5.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j5.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j5.Checked = false;
            }
            else
            {
                string day = "5";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j5.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j6_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j6.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j6.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j6.Checked = false;
            }
            else
            {
                string day = "6";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j6.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j7_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j7.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j7.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j7.Checked = false;
            }
            else
            {
                string day = "7";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j7.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j8_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j8.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j8.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j8.Checked = false;
            }
            else
            {
                string day = "8";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j8.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j9_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j9.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j9.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j9.Checked = false;
            }
            else
            {
                string day = "9";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j9.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j10_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j10.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j10.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j10.Checked = false;
            }
            else
            {
                string day = "10";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j10.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j11_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j11.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j11.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j11.Checked = false;
            }
            else
            {
                string day = "11";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j11.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j12_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j12.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j12.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j12.Checked = false;
            }
            else
            {
                string day = "12";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j12.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j13_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j13.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j13.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j13.Checked = false;
            }
            else
            {
                string day = "13";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j13.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j14_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j14.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j14.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j14.Checked = false;
            }
            else
            {
                string day = "14";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j14.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j15_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j15.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j15.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j15.Checked = false;
            }
            else
            {
                string day = "15";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j15.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j16_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j16.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j16.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j16.Checked = false;
            }
            else
            {
                string day = "16";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j16.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j17_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j17.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j17.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j17.Checked = false;
            }
            else
            {
                string day = "17";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j17.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j18_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j18.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j18.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j18.Checked = false;
            }
            else
            {
                string day = "18";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j18.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j19_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j19.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j19.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j19.Checked = false;
            }
            else
            {
                string day = "19";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j19.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j20_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j20.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j20.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j20.Checked = false;
            }
            else
            {
                string day = "20";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j20.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j21_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j21.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j21.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j21.Checked = false;
            }
            else
            {
                string day = "21";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j21.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j22_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j22.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j22.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j22.Checked = false;
            }
            else
            {

                string day = "22";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j22.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j23_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j23.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j23.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j23.Checked = false;
            }
            else
            {
                string day = "23";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j23.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j24_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j24.Checked = false;
            }
            else
                    if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j24.Checked = false;
            }
            else
                if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j24.Checked = false;
            }
            else
            {
                string day = "24";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j24.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j25_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j25.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j25.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j25.Checked = false;
            }
            else
            {
                string day = "25";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j25.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j26_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j26.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j26.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j26.Checked = false;
            }
            else
            {
                string day = "26";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j26.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j27_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j27.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j27.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j27.Checked = false;
            }
            else
            {
                string day = "27";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j27.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);

                }
            }
        }

        private void j28_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j28.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j28.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j28.Checked = false;
            }
            else
            {
                string day = "28";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j28.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);
                }
            }
        }

        private void j29_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j29.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j29.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j29.Checked = false;
            }
            else
            {
                string day = "29";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j29.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);
                }
            }
        }

        private void j30_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j30.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j30.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j30.Checked = false;
            }
            else
            {
                string day = "30";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j30.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);
                }
            }
        }

        private void j31_OnChange(object sender, EventArgs e)
        {
            if (list_personnel.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner la personne !!!");
                j31.Checked = false;
            }
            else
                                if (Ddw_type.SelectedIndex == -1)
            {
                MessageBox.Show("selectionner le type d'absence !!!");
                j31.Checked = false;
            }
            else
                            if (a1.Text == "")
            {
                MessageBox.Show("ajouter un commentaire !!!");
                j31.Checked = false;
            }
            else
            {
                string day = "31";
                string mat = get_Matricule(list_personnel.GetItemText(list_personnel.SelectedItem));
                string type = IDtype();
                if (j31.Checked)
                {
                    string date = selected_DAY_date(day);
                    string req = "insert into ABSANCE values(" + mat + "," + type + ",'" + a1.Text + "','" + date + "')";
                    checkABS(req);
                }
                else
                {
                    string date = selected_DAY_date(day);
                    string req = "delete from ABSANCE where MATRICULE=" + mat + " and date_debut='" + date + "'";
                    checkABS(req);
                }
            }
        }

        private void list_personnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ddw_type.SelectedIndex = -1;
            a1.Text = "";
            uncheckedAll();
        }

        private void ddw_months_SelectedValueChanged(object sender, EventArgs e)
        {
            a1.Text = "";
            uncheckedAll();
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
