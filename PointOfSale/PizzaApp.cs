using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Alex Mack 
 * Program: Pizza App
 * Date/Time: 10/12/2014 @ 8:35 PM
 * Modified Date/Time: 1/20/2015 @ 1:33 AM
 * 
 */

namespace PointOfSale
{
    public partial class PizzaApp : Form
    {
        public PizzaApp()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double taxAmt;
            double total;
            double cost = 0;
            int count = 0;

            if (radioSm.Checked)
                cost += 4.00;
            else if (radioMed.Checked)
                cost += 6.00;
            else if (radioLg.Checked)
                cost += 8.00;

            if (cbAnchovy.Checked)
                count++;
            if (cbBeef.Checked)
                count++;
            if (cbCheese.Checked)
                count++;
            if (cbHam.Checked)
                count++;
            if (cbPep.Checked)
                count++;
            if (cbPork.Checked)
                count++;

            if (count == 2)
                cost += 1.00;
            else if (count == 3)
                     cost += 1.50;
            else if (count > 3)
                    cost += 2.50;
            else
                cost += 0.50;


            if (cmbDrinks.SelectedItem.Equals("Sprite"))
                cost += 1.25;
            else if (cmbDrinks.SelectedItem.Equals("Coke"))
                cost += 1.25;
            else if (cmbDrinks.SelectedItem.Equals("Dr. Pepper"))
                cost += 1.25;
            else if (cmbDrinks.SelectedItem.Equals("Sierra Mist"))
                cost += 1.25;
            else if (cmbDrinks.SelectedItem.Equals("Mountain Dew"))
                cost += 1.25;
            else
                cost += 0;

            
            taxAmt = cost * 0.10;
            total = taxAmt + cost;

            txtTaxAmt.Text = taxAmt.ToString();
            txtTotal.Text = total.ToString();
            



        }

       
    }
}
