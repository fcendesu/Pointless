using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1
    {   
            [DllImport("user32")]
            public static extern void LockWorkStation();   
    }
}
