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
        string filter;
        public form_printing(ReportClass r,DataSet ds,string filter="")
        {
            InitializeComponent();
            report = r;
            dataSet = ds;
            this.filter = filter;
        }
        public void chargingData()
        {
            report.SetDataSource(dataSet);
            try
            { report.SetParameterValue("chemain", Application.StartupPath + "\\pics\\");} catch{}
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.SelectionFormula = filter;
        }

        private void form_printing_Load(object sender, EventArgs e)
        {
            chargingData(); 
        }

        
    }
}
