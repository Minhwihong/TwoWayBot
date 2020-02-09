using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using winFormSenValAnalyzer.control;



namespace winFormSenValAnalyzer
{
    partial class Form1 :  iShareData
    {
        private void tbAdd_6axit_data(double AxisX, sIMU6 sensing)
        {
            DataRow rowMeas;

            rowMeas = tbMeas.NewRow();

            rowMeas["time(ms)"]    = AxisX;
            rowMeas["AccX"]        = sensing.AccX;
            rowMeas["AccY"]        = sensing.AccY;
            rowMeas["AccZ"]        = sensing.AccZ;
            rowMeas["GyroX"]       = sensing.Roll;
            rowMeas["GyroY"]       = sensing.Pitch;
            rowMeas["GyroZ"]       = sensing.Yaw;

            tbMeas.Rows.Add(rowMeas);
        }


        private void tbInit_tables()
        {
            tbMeas  = new DataTable("IMU9255");
            


            tbMeas.Columns.Add("time(ms)", typeof(int));
            tbMeas.Columns.Add("AccX", typeof(float));
            tbMeas.Columns.Add("AccY", typeof(float));
            tbMeas.Columns.Add("AccZ", typeof(float));
            tbMeas.Columns.Add("Theta", typeof(float));
            tbMeas.Columns.Add("GyroX", typeof(float));
            tbMeas.Columns.Add("GyroY", typeof(float));
            tbMeas.Columns.Add("GyroZ", typeof(float));



            tbMonitor = new DataTable("Monitor");

            tbMonitor.Columns.Add("time(ms)", typeof(int));
            tbMonitor.Columns.Add("AccX", typeof(int));
            tbMonitor.Columns.Add("AccY", typeof(int));
            tbMonitor.Columns.Add("AccZ", typeof(int));
            tbMonitor.Columns.Add("Roll", typeof(int));
            tbMonitor.Columns.Add("Pitch", typeof(int));
            tbMonitor.Columns.Add("Yaw", typeof(int));
            tbMonitor.Columns.Add("Theta1", typeof(int));
            tbMonitor.Columns.Add("Theta2", typeof(int));
            tbMonitor.Columns.Add("Theta3", typeof(int));

            DataRow rowMonitor;

            rowMonitor = tbMonitor.NewRow();

            rowMonitor["time(ms)"] = 0;
            rowMonitor["AccX"] = 0.0;
            rowMonitor["AccY"] = 0.0;
            rowMonitor["AccZ"] = 0.0;
            rowMonitor["Roll"] = 0.0;
            rowMonitor["Pitch"] = 0.0;
            rowMonitor["Yaw"] = 0.0;
            rowMonitor["Theta1"] = 0.0;
            rowMonitor["Theta2"] = 0.0;
            rowMonitor["Theta3"] = 0.0;

            tbMonitor.Rows.Add(rowMonitor);


            grvMonitor.DataSource = tbMonitor;

            tbMonitor.Rows[0]["time(ms)"] = 0;
            tbMonitor.Rows[0]["AccX"] = 0;
            tbMonitor.Rows[0]["AccY"] = 0;
            tbMonitor.Rows[0]["AccZ"] = 0;
            tbMonitor.Rows[0]["Roll"] = 0;
            tbMonitor.Rows[0]["Pitch"] = 0;
            tbMonitor.Rows[0]["Yaw"] = 0;
            tbMonitor.Rows[0]["Theta1"] = 0;


            grvMonitor.AutoResizeColumns();

        }

        private void tbUpdateMonitor()
        {


        }


    }
}

