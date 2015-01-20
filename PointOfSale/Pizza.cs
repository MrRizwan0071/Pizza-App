using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
 * Alex Mack 
 * Program: Pizza App
 * 10/12/2014 @ 8:35 PM
 * Modified Date/Time: 1/20/2015 @ 1:33 AM
 * 
 */

namespace PointOfSale
{
    static class Pizza
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PizzaApp());
        }
    }
}
