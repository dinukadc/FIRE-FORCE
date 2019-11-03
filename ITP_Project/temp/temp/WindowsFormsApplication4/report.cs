using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class report : UserControl
    {


        private static report _instance;
        public static report Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new report();
                return _instance;

            }


        }

        public report()
        {
            InitializeComponent();
        }
    }
}
