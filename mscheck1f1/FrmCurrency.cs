using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAus.BackgroundImage = picAus.Image;
            btnBhu.BackgroundImage = picBhuDim.Image;
            btnCan.BackgroundImage = picCanDim.Image;
            btnJap.BackgroundImage = picJapDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAus.Text + ":";
            txtUS.Text = "0.00";
            txtTotal.Text = "0.00";

        }

        private void btnAus_Click(object sender, EventArgs e)
        {
            btnAus.BackgroundImage = picAus.Image;
            btnBhu.BackgroundImage = picBhuDim.Image;
            btnCan.BackgroundImage = picCanDim.Image;
            btnJap.BackgroundImage = picJapDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAus.Text + ":";
        }

        private void btnBhu_Click(object sender, EventArgs e)
        {
            btnBhu.BackgroundImage = picBhu.Image;
            btnCan.BackgroundImage = picCanDim.Image;
            btnJap.BackgroundImage = picJapDim.Image;
            btnAus.BackgroundImage = picAusDim.Image;
            txtRate.Text = "0.0139831";
            lblCurrency.Text = btnBhu.Text + ":";
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            btnCan.BackgroundImage = picCan.Image;
            btnJap.BackgroundImage = picJapDim.Image;
            btnAus.BackgroundImage = picAusDim.Image;
            btnBhu.BackgroundImage = picBhuDim.Image;
            txtRate.Text = "0.759883";
            lblCurrency.Text = btnCan.Text + ":";
        }

        private void btnJap_Click(object sender, EventArgs e)
        {
            btnJap.BackgroundImage = picJap.Image;
            btnAus.BackgroundImage = picAusDim.Image;
            btnBhu.BackgroundImage = picBhuDim.Image;
            btnCan.BackgroundImage = picCanDim.Image;
            txtRate.Text = "0.00900094";
            lblCurrency.Text = btnJap.Text + ":";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUS.Text = ((Convert.ToDecimal(txtCurrency.Text)) * (Convert.ToDecimal(txtRate.Text))
                   ).ToString("0.00");
           
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (
              (Convert.ToDecimal(txtTotal.Text)) + (Convert.ToDecimal(txtUS.Text))
             ).ToString("0.00");
          

          lblEquation.Text = lblEquation.Text + " + " + txtTotal.Text;

          

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
            txtTotal.Text = "";
           
        }

        private void txtUS_TextChanged(object sender, EventArgs e)
        {
            txtUS.Text = ((Convert.ToDecimal(txtCurrency.Text)) * (Convert.ToDecimal(txtRate.Text))
                ).ToString("0.00");
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void lblEquation_Click(object sender, EventArgs e)
        {

        }
    }
}
