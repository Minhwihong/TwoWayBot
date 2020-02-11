using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winFormSenValAnalyzer.control;


namespace winFormSenValAnalyzer.form
{
    public partial class frmTestSetting : Form, iTestData
    {
        int currTestMode;
        private iTestData frmMain = null;

        int iTestData.Mode
        {
            get { return this.currTestMode; }
            set { this.currTestMode = value; }
        }


        public frmTestSetting(iTestData frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;

        }

        private void rdbtnNormalMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNormalMode.Checked == true)
                frmMain.Mode = cProgramMode.NORMAL;
        }

        private void rdbtnTestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTestMode.Checked == true)
                frmMain.Mode = cProgramMode.TEST;
        }

        private void frmTestSetting_Load(object sender, EventArgs e)
        {
            if (frmMain.Mode == cProgramMode.TEST)
                rdbtnTestMode.Checked = true;
            else
                rdbtnNormalMode.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
