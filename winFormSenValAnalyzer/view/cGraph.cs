using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using winFormSenValAnalyzer.control;

namespace winFormSenValAnalyzer
{
    partial class Form1 : iShareData
    {
        private void grInit_graph()
        {
            // init Acc Graph
            grAcc.createGraph(ref chrtAcceleration, "Acceleration", new string[] { "AccX", "AccY", "AccZ" });
            grAcc.setGraphType(ref chrtAcceleration, 0);
            chrtAcceleration.ChartAreas[0].AxisX.Minimum = 0;
            grAcc.setGraph_Yaxis_MinMax(ref chrtAcceleration, minAccVal, maxAccVal);


            // init Gyro Graph
            grGyro.createGraph(ref chrtGyroscope, "Gyroscope", new string[] { "GyroX", "GyroY", "GyroZ" });
            grGyro.setGraphType(ref chrtGyroscope, 0);
            chrtGyroscope.ChartAreas[0].AxisX.Minimum = 0;
            grGyro.setGraph_Yaxis_MinMax(ref chrtGyroscope, minGyroVal, maxGyroVal);


            // init Angle(degree) Graph
            chrtDegree.Series.Clear();
            chrtDegree.Series.Add("DgrNormal");
            chrtDegree.Series.Add("Filtered");
            chrtDegree.Series["DgrNormal"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrtDegree.Series["Filtered"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chrtDegree.ChartAreas[0].AxisY.Minimum = -16;
            chrtDegree.ChartAreas[0].AxisY.Maximum = 16;
            chrtDegree.ChartAreas[0].AxisX.Minimum = 0;
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
