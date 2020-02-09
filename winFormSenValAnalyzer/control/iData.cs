using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace winFormSenValAnalyzer.control
{
    public interface iShareData
    {
        DataTable myData { get; set; }
        UDP_Data commData { get; set; }
    }

    public interface iCommData
    {
        UDP_Data commData { get; set; }
    }


    
}
