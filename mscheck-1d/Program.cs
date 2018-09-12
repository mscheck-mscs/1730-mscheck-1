﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck_1d
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
private void AustraliaTextChanged(object sender, EventArgs e)
{
    txtUSDAus.Text = (
        Convert.ToDecimal(txtAmountAus.Text) * Convert.ToDecimal(txtRateAus.Text)
        ).ToString("0.00");
}

private void usdTextChange(object sender, EventArgs e)
{

}

private void txtUSDBhu_TextChanged(object sender, EventArgs e)
{
    txtUSDBhu.Text = (
       Convert.ToDecimal(txtAmountBhu.Text) * Convert.ToDecimal(txtRateBhu.Text)
       ).ToString("0.00");

}

private void txtUSDCanada_TextChanged(object sender, EventArgs e)
{
    txtUSDCanada.Text = (
       Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
       ).ToString("0.00");
}

private void txtUSDJapan_TextChanged(object sender, EventArgs e)
{
    txtUSDJapan.Text = (
       Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
       ).ToString("0.00");
}

private void BhuTextChanged(object sender, EventArgs e)
{
    txtUSDBhu.Text = (
    Convert.ToDecimal(txtAmountBhu.Text) * Convert.ToDecimal(txtRateBhu.Text)
    ).ToString("0.00");

}

private void CanadaTextChange(object sender, EventArgs e)
{
    txtUSDCanada.Text = (
     Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
     ).ToString("0.00");
}

private void JapanTextChange(object sender, EventArgs e)
{
    txtUSDJapan.Text = (
       Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
       ).ToString("0.00");
}

private void usdTextChanged(object sender, EventArgs e)
{
    txtTotal.Text = (
      Convert.ToDecimal(txtUSDAus.Text) + Convert.ToDecimal(txtUSDBhu.Text) + Convert.ToDecimal(txtUSDCanada.Text)
      + Convert.ToDecimal(txtUSDJapan.Text)

      ).ToString("0.00");
}

private void button1_Click(object sender, EventArgs e)
{
    txtAmountAus.Text = "0.00";
    txtRateAus.Text = "0.7179760";
    txtAmountBhu.Text = "0.00";
    txtRateBhu.Text = "0.0139831";
    txtAmountCanada.Text = "0.00";
    txtRateCanada.Text = "0.759883";
    txtAmountJapan.Text = "0.00";
    txtRateJapan.Text = "0.00900094";
}

private void buttonExit_Click(object sender, EventArgs e)
{
    Close();



