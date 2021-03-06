﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck_1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUSDAus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountAus_TextChanged(object sender, EventArgs e)
        {
            txtUSDAus.Text = (
              Convert.ToDecimal(txtAmountAus.Text) * Convert.ToDecimal(txtRateAus.Text)
              ).ToString("0.00");
        }

        private void txtRateAus_TextChanged(object sender, EventArgs e)
        {
            txtUSDAus.Text = (
              Convert.ToDecimal(txtAmountAus.Text) * Convert.ToDecimal(txtRateAus.Text)
              ).ToString("0.00");
        }

        private void txtAmountBhu_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhu.Text = (
          Convert.ToDecimal(txtAmountBhu.Text) * Convert.ToDecimal(txtRateBhu.Text)
          ).ToString("0.00");
        }

        private void txtRateBhu_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhu.Text = (
          Convert.ToDecimal(txtAmountBhu.Text) * Convert.ToDecimal(txtRateBhu.Text)
          ).ToString("0.00");

        }

        private void txtAmountCanada_TextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
            Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
            ).ToString("0.00");
        }

        private void txtRateCanada_TextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
           Convert.ToDecimal(txtAmountCanada.Text) * Convert.ToDecimal(txtRateCanada.Text)
           ).ToString("0.00");
        }

        private void txtAmountJapan_TextChanged(object sender, EventArgs e)
        {
            txtUSDJapan.Text = (
             Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
             ).ToString("0.00");
        }

        private void txtRateJapan_TextChanged(object sender, EventArgs e)
        {
            txtUSDJapan.Text = (
              Convert.ToDecimal(txtAmountJapan.Text) * Convert.ToDecimal(txtRateJapan.Text)
              ).ToString("0.00");
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (
               (Convert.ToDecimal(txtUSDAus.Text)) + (Convert.ToDecimal(txtUSDJapan.Text)) +
               (Convert.ToDecimal(txtUSDCanada.Text)) + (Convert.ToDecimal(txtUSDBhu.Text))
               ).ToString("0.00");

        }
        private void buttonReset_Click(object sender, EventArgs e)
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
    }
}