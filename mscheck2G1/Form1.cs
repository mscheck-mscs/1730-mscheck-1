using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck2G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            //1a) Switch -with no default
            resultSwitch01textBox.Text = Ex2gCalculations.Switch01(input1aTextBox.Text);
            //1b) Separate 'if' statement
            resultIf01textBox.Text = Ex2gCalculations.IF01(input1aTextBox.Text);
            //1c) if elseif
            resultElseIf01textBox.Text = Ex2gCalculations.ElseIF01(input1aTextBox.Text);
            //1d) Nested if-else
            resultNestedIf01textBox.Text = Ex2gCalculations.NestedIF01(input1aTextBox.Text);

            //with default
            //1e) Switch 
            resultSwitchDefault01textBox.Text = Ex2gCalculations.SwitchDefault01(input1aTextBox.Text);
            //2b) Separate 'if' statement w/catch
            resultIf02textBox.Text = Ex2gCalculations.IF02(input1aTextBox.Text);
            //2d) Nested if-else w/catch
            resultNestedIf02textBox.Text = Ex2gCalculations.NestedIF02(input1aTextBox.Text);
            //2c) if elseif
            resultElseIf02textBox.Text = Ex2gCalculations.ElseIF02(input1aTextBox.Text);

            //(9 to 12)
            // 2a) 'Switch' with no default
            resultSwitch02textBox.Text = Ex2gCalculations.Switch02(input2aTextBox.Text);
            // 2b) Separate 'if' statements
            resultIf2textBox.Text = Ex2gCalculations.If2(input2aTextBox.Text);
            // 2c) if elseif
            resultElseIf2textBox.Text = Ex2gCalculations.ElseIf2(input2aTextBox.Text);
            // 2d) Nested if-else
            resultNestedIf2textBox.Text = Ex2gCalculations.NestedIfElse2(input2aTextBox.Text);
        }

    }
}
