using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormSenValAnalyzer.testing
{
    class cTestGraph
    {

        double valMax = 1.0;
        double valMin = -1.0;

        public cTestGraph()
        {

        }



        public void set_MinMax(double min, double max)
        {
            valMax = max;
            valMin = min;
        }



        public double get_simulation_data()
        {
            var random = new Random();

            double randomVal = random.NextDouble();

            if(randomVal >= 0.5)
            {
                randomVal -= randomVal;
                return randomVal * valMax * 2.0;
            }
            else
            {
                return randomVal * valMax * (2.0);
            }

            
        }




    }
}
