﻿using System;
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
    public partial class EmailView : UserControl
    {

        private static EmailView _instance;
        public static EmailView Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmailView();
                return _instance;

            }


        }
        public EmailView()
        {
            InitializeComponent();
        }
    }
}
