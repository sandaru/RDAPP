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

        ////Import DLLs for get the size of current desktop
        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        ////Structure for display position
        //[StructLayout(LayoutKind.Sequential)]
        //private struct RECT
        //{
        //    public int Left;        // x position of upper-left corner
        //    public int Top;         // y position of upper-left corner
        //    public int Right;      // x position of lower-right corner
        //    public int Bottom;      // y position of lower-right corner
        //}

        ////Get the current active window
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        ////return the current Desktop rectangle
        public List<String> DesktopRectangle()
        {
            // //*****************
            //IntPtr now = GetActiveWindow();
            //RECT rct;
            //if (!GetWindowRect(new HandleRef(now, (new Form1()).Handle), out rct))
            //{
                return null;
            //}
            ////MessageBox.Show("Left:"+rct.Left+" Right:"+rct.Right+" Top:"+rct.Top+" Bottom"+rct.Bottom);
            ////x.SetDesktopSharedRect(rct.Left, rct.Top, rct.Right, rct.Bottom);//Set Desktop Size
            //return new List<string> 
            //{rct.Left.ToString(),rct.Right.ToString(),
            //    rct.Top.ToString(),rct.Bottom.ToString()};
        }
    }
}
