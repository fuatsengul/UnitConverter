﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UnitConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DarkUI.Config.Colors.LightMode = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
