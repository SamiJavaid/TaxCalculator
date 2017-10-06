using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        double iTax, iSubTotal, iTotal;

        private void Reset_Click(object sender, EventArgs e)
        {
            lblTax.BackColor = Color.White;
            lblSubTotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
            Quantity.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Sales Inventory System",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Total_Click_1(object sender, EventArgs e)
        {
            if (Quantity.Text == "")
            {
                MessageBox.Show("Enter Quantity", "Sales Inventory System",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Quantity.Focus();
            }
            else
            {
                TaxCal obj = new TaxCal();

                obj.item1 = double.Parse(Quantity.Text) * 4.5;

                iSubTotal = obj.GetAmount();
                iTax = obj.cFindTax(iSubTotal);

                iTotal = iSubTotal + iTax;

                lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
                lblTax.Text = String.Format("{0:C}", iTax);
                lblTotal.Text = String.Format("{0:C}", iTotal);

                lblTax.BackColor = Color.Azure;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        //private void Total_Click(object sender, EventArgs e)
        //{
        //    TaxCal obj = new TaxCal();

        //    obj.item1 = double.Parse(Quantity.Text)*4.5;

        //    iSubTotal = obj.GetAmount();
        //    iTax = obj.cFindTax(iSubTotal);

        //    iTotal = iSubTotal + iTax;

        //    lblSubTotal.Text = String.Format("{0:C}", iSubTotal);
        //    lblTax.Text = String.Format("{0:C}", iTax);
        //    lblTotal.Text = String.Format("{0:C}", iTotal);

        //    lblTax.BackColor = Color.Azure;
        //}
    }
}