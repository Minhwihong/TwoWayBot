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
    public partial class frmTable : Form
    {
        private iShareData frmMain = null;
        DataTable sensingData;
       

        public frmTable(iShareData frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            //frmMain.
            sensingData = frmMain.myData;
            grvIMU_Raw.DataSource = sensingData;
            grvIMU_Raw.AutoResizeColumns();
        }




        private void grvIMU_Raw_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            grvIMU_Raw.Rows[e.RowCount].Selected = true;
        }

    }
}
