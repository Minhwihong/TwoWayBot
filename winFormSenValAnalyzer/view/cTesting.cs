using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using winFormSenValAnalyzer.control;
using winFormSenValAnalyzer.testing;


namespace winFormSenValAnalyzer
{
    partial class Form1 : iShareData
    {

        // test mode
        cTestGraph iTestGraph = new cTestGraph();

        void initTestMode(double min, double max)
        {
            iTestGraph.set_MinMax(min, max);

        }

        double getRandomValue()
        {
            return iTestGraph.get_simulation_data();

        }



    }
}
