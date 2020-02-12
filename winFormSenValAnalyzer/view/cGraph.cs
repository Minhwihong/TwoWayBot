using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using winFormSenValAnalyzer.control;


namespace winFormSenValAnalyzer
{
    partial class Form1 : iShareData
    {
        private const float CZoomScale = 4f;
        private int FZoomLevel = 0;


        private void grInit_graph()
        {
            
            // init Acc Graph
            grAcc.createGraph(ref chrtAcceleration, cGrName.GraphIMU, new string[] { cSeries.AccX, cSeries.AccY, cSeries.AccZ, cSeries.Roll, cSeries.Pitch, cSeries.Yaw });

            grAcc.setGraphType(ref chrtAcceleration, 0);

            chrtAcceleration.ChartAreas[0].AxisX.Minimum = 0;

            //chrtAcceleration.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            //chrtAcceleration.ChartAreas[0].AxisY2.MajorGrid.LineColor = System.Drawing.Color.Blue;

            chrtAcceleration.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chrtAcceleration.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chrtAcceleration.MouseWheel += chrtAcceleration_MouseWheel;

            

            grAcc.setGraph_Yaxis_MinMax(ref chrtAcceleration, minIMU_val, maxIMU_val);


            // init Gyro Graph
            grGyro.createGraph(ref chrtGyroscope, cGrName.GraphPID, new string[] { cSeries.CurrErr, cSeries.AccumErr, cSeries.TargetValue, cSeries.SensValue });
            grGyro.setGraphType(ref chrtGyroscope, 0);
            chrtGyroscope.ChartAreas[0].AxisX.Minimum = 0;
            grGyro.setGraph_Yaxis_MinMax(ref chrtGyroscope, minGyroVal, maxGyroVal);


            Chart_Series_ShowHide();
        }

        private void Chart_Series_ShowHide()
        {
            if(chbShowAccX.Checked == true)
                chrtAcceleration.Series[cSeries.AccX].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccX].Enabled = false;

            if (chbShowAccY.Checked == true)
                chrtAcceleration.Series[cSeries.AccY].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccY].Enabled = false;

            if (chbShowAccZ.Checked == true)
                chrtAcceleration.Series[cSeries.AccZ].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccZ].Enabled = false;



            if (chbShowGyroX.Checked == true)
                chrtAcceleration.Series[cSeries.Roll].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Roll].Enabled = false;

            if (chbShowGyroY.Checked == true)
                chrtAcceleration.Series[cSeries.Pitch].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Pitch].Enabled = false;

            if (chbShowGyroZ.Checked == true)
                chrtAcceleration.Series[cSeries.Yaw].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Yaw].Enabled = false;



            if (chbCurrErr.Checked == true)
                chrtGyroscope.Series[cSeries.CurrErr].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.CurrErr].Enabled = false;

            if (chbAccumErr.Checked == true)
                chrtGyroscope.Series[cSeries.AccumErr].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.AccumErr].Enabled = false;

            if (chbPID_target.Checked == true)
                chrtGyroscope.Series[cSeries.TargetValue].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.TargetValue].Enabled = false;

            if (chbPID_sensing.Checked == true)
                chrtGyroscope.Series[cSeries.SensValue].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.SensValue].Enabled = false;
        }





        private void chbShowAccX_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowAccX.Checked == true)
                chrtAcceleration.Series[cSeries.AccX].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccX].Enabled = false;
        }


        private void chbShowAccY_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowAccY.Checked == true)
                chrtAcceleration.Series[cSeries.AccY].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccY].Enabled = false;
        }


        private void chbShowAccZ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowAccZ.Checked == true)
                chrtAcceleration.Series[cSeries.AccZ].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.AccZ].Enabled = false;
        }


        private void chbShowGyroX_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowGyroX.Checked == true)
                chrtAcceleration.Series[cSeries.Roll].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Roll].Enabled = false;
        }


        private void chbShowGyroY_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowGyroY.Checked == true)
                chrtAcceleration.Series[cSeries.Pitch].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Pitch].Enabled = false;
        }


        private void chbShowGyroZ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowGyroZ.Checked == true)
                chrtAcceleration.Series[cSeries.Yaw].Enabled = true;
            else
                chrtAcceleration.Series[cSeries.Yaw].Enabled = false;
        }


        private void chbPID_target_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPID_target.Checked == true)
                chrtGyroscope.Series[cSeries.TargetValue].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.TargetValue].Enabled = false;
        }


        private void chbPID_sensing_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPID_sensing.Checked == true)
                chrtGyroscope.Series[cSeries.SensValue].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.SensValue].Enabled = false;
        }


        private void chbCurrErr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCurrErr.Checked == true)
                chrtGyroscope.Series[cSeries.CurrErr].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.CurrErr].Enabled = false;
        }


        private void chbAccumErr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAccumErr.Checked == true)
                chrtGyroscope.Series[cSeries.AccumErr].Enabled = true;
            else
                chrtGyroscope.Series[cSeries.AccumErr].Enabled = false;
        }



        private void chrtAcceleration_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Axis xAxis = chrtAcceleration.ChartAreas[0].AxisX;
                double xMin = xAxis.ScaleView.ViewMinimum;
                double xMax = xAxis.ScaleView.ViewMaximum;
                double xPixelPos = xAxis.PixelPositionToValue(e.Location.X);

                if (e.Delta < 0 && FZoomLevel > 0)
                {
                    // Scrolled down, meaning zoom out
                    if (--FZoomLevel <= 0)
                    {
                        FZoomLevel = 0;
                        xAxis.ScaleView.ZoomReset();
                    }
                    else
                    {
                        double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) * CZoomScale, 0);
                        double xEndPos = Math.Min(xStartPos + (xMax - xMin) * CZoomScale, xAxis.Maximum);
                        xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    }
                }
                else if (e.Delta > 0)
                {
                    // Scrolled up, meaning zoom in
                    double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) / CZoomScale, 0);
                    double xEndPos = Math.Min(xStartPos + (xMax - xMin) / CZoomScale, xAxis.Maximum);
                    xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    FZoomLevel++;
                }
            }
            catch { }
        }


    }

}


namespace winFormSenValAnalyzer.view
{
    class cGraphControl
    {
        //Chart mChart;
        public cGraphControl()
        {

        }

        public void createGraph(ref Chart inChart, string grName, string[] grSeries)
        {
            inChart.Series.Clear();

            for (int idx=0; idx < grSeries.Length; ++idx)
            {
                inChart.Series.Add(grSeries[idx]);
            }
            
        }

        public void setGraphType(ref Chart inChart, int mtype)
        {
            for(int idx=0; idx < inChart.Series.Count; ++idx)
            {
                switch (mtype)
                {
                    case 0:
                        inChart.Series[idx].ChartType = SeriesChartType.Line;
                        break;
                    case 1:
                        inChart.Series[idx].ChartType = SeriesChartType.Bar;
                        break;
                }
            }
            
        }

        public void setGraph_Xaxis_MinMax(ref Chart inChart, double minX, double maxY)
        {
            inChart.ChartAreas[0].AxisX.Minimum = minX;
            inChart.ChartAreas[0].AxisX.Minimum = maxY;
        }

        public void setGraph_Xaxis_MinMax(ref Chart inChart, double minX)
        {
            inChart.ChartAreas[0].AxisX.Minimum = minX;
        }


        public void setGraph_Yaxis_MinMax(ref Chart inChart, double minY, double maxY)
        {
            inChart.ChartAreas[0].AxisY.Minimum = minY;
            inChart.ChartAreas[0].AxisY.Maximum = maxY;
            
        }

        public void setGraph_Yaxis_MinMax(ref Chart inChart, double[] minY, double[] maxY)
        {

        }

        public void addPoint(ref Chart inChart, double valX, double[] valY)
        {
            for(int idx=0; idx < valY.Length; ++idx)
            {
                inChart.Series[idx].Points.AddXY(valX, valY[idx]);
            }
            
        }


        public void adjust_Yaxis_scale(ref Chart inChart, double[] inData)
        {

            for(int idx=0; idx < inData.Length; ++idx)
            {
                if (maxYAxis_Val <= inData[idx]) maxYAxis_Val = inData[idx];
            }

            for (int idx = 0; idx < inData.Length; ++idx)
            {
                if (minYAxis_Val >= inData[idx]) minYAxis_Val = inData[idx];
            }


            int maxY = (int)(maxYAxis_Val + 1.0);
            int minY = (int)(minYAxis_Val - 1.0);

            if (Math.Abs(maxY) > Math.Abs(minY)) minY = maxY * (-1);
            else maxY = minY * (-1);


            inChart.ChartAreas[0].AxisY.Maximum = maxY;
            inChart.ChartAreas[0].AxisY.Minimum = minY;
        }

        double maxYAxis_Val {  get;  set; }
        double minYAxis_Val { get; set; }


    }
}
