using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDPCOMAPILib;
using AxRDPCOMAPILib;
using System.Runtime.InteropServices;

namespace RDAPP
{
    //Class to triger the methods 
    public class Triger
    {
        //return the astive windows
        public List<String> ActiveList(RDPSession currentSession)
        {
            RDPSRAPIWindowList WindowList =
                currentSession.ApplicationFilter.Windows;
            List<String> WindowNames = new List<string>();
            foreach (RDPSRAPIWindow item in WindowList)
            {
                WindowNames.Add(item.Name);
            }
            return WindowNames;
        }

    }
}
