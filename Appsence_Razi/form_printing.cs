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
using CrystalDecisions.ReportSource;


namespace Appsence_Razi
{
    public partial class form_printing : Form
    {
        ReportClass report;
        DataSet dataSet;
        public form_printing(ReportClass r,DataSet ds)
        {
            InitializeComponent();
            report = r;
            dataSet = ds;
        }

        private void form_printing_Load(object sender, EventArgs e)
        {
            report.SetDataSource(dataSet);
            try
            {
                report.SetParameterValue("chemain", Application.StartupPath + "\\pics\\");
            }
            catch { }

            crystalReportViewer1.ReportSource = report;


        }
    }
}
