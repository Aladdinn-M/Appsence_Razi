using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Appsence_Razi
{
    public partial class form_printing2 : Form
    {
        ReportClass report;
        string filter;
        public form_printing2(ReportClass r,string filter="")
        {
            InitializeComponent();
            report = r;
            this.filter = filter;
        }

        private void aBSANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aBSANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appsence_RAZIDataSet);

        }

        private void form_printing2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'appsence_RAZIDataSet.TYPE_ABS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tYPE_ABSTableAdapter.Fill(this.appsence_RAZIDataSet.TYPE_ABS);
            // TODO: cette ligne de code charge les données dans la table 'appsence_RAZIDataSet.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.pERSONNELTableAdapter.Fill(this.appsence_RAZIDataSet.PERSONNEL);
            // TODO: cette ligne de code charge les données dans la table 'appsence_RAZIDataSet.FONCTION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fONCTIONTableAdapter.Fill(this.appsence_RAZIDataSet.FONCTION);
            // TODO: cette ligne de code charge les données dans la table 'appsence_RAZIDataSet.ABSANCE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.aBSANCETableAdapter.Fill(this.appsence_RAZIDataSet.ABSANCE);

            report.SetDataSource(this.appsence_RAZIDataSet);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.SelectionFormula = filter;
        }
    }
}
