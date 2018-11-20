namespace mscheck2G1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.resultSwitch01textBox = new System.Windows.Forms.TextBox();
            this.input1aTextBox = new System.Windows.Forms.TextBox();
            this.calcbutton = new System.Windows.Forms.Button();
            this.resultIf01textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultElseIf01textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultNestedIf01textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultSwitchDefault01textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultIf02textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultNestedIf02textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultElseIf02textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resultNestedIf2textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resultElseIf2textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resultIf2textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.input2aTextBox = new System.Windows.Forms.TextBox();
            this.resultSwitch02textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Switch R/C";
            // 
            // resultSwitch01textBox
            // 
            this.resultSwitch01textBox.Location = new System.Drawing.Point(276, 34);
            this.resultSwitch01textBox.Name = "resultSwitch01textBox";
            this.resultSwitch01textBox.ReadOnly = true;
            this.resultSwitch01textBox.Size = new System.Drawing.Size(60, 22);
            this.resultSwitch01textBox.TabIndex = 1;
            this.resultSwitch01textBox.TabStop = false;
            // 
            // input1aTextBox
            // 
            this.input1aTextBox.Location = new System.Drawing.Point(163, 34);
            this.input1aTextBox.Name = "input1aTextBox";
            this.input1aTextBox.Size = new System.Drawing.Size(64, 22);
            this.input1aTextBox.TabIndex = 2;
            this.input1aTextBox.Text = "R";
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(130, 420);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(112, 30);
            this.calcbutton.TabIndex = 3;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // resultIf01textBox
            // 
            this.resultIf01textBox.Location = new System.Drawing.Point(276, 63);
            this.resultIf01textBox.Name = "resultIf01textBox";
            this.resultIf01textBox.ReadOnly = true;
            this.resultIf01textBox.Size = new System.Drawing.Size(60, 22);
            this.resultIf01textBox.TabIndex = 5;
            this.resultIf01textBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "2) if R/C";
            // 
            // resultElseIf01textBox
            // 
            this.resultElseIf01textBox.Location = new System.Drawing.Point(276, 92);
            this.resultElseIf01textBox.Name = "resultElseIf01textBox";
            this.resultElseIf01textBox.ReadOnly = true;
            this.resultElseIf01textBox.Size = new System.Drawing.Size(60, 22);
            this.resultElseIf01textBox.TabIndex = 7;
            this.resultElseIf01textBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "3)Else if R/C";
            // 
            // resultNestedIf01textBox
            // 
            this.resultNestedIf01textBox.Location = new System.Drawing.Point(276, 123);
            this.resultNestedIf01textBox.Name = "resultNestedIf01textBox";
            this.resultNestedIf01textBox.ReadOnly = true;
            this.resultNestedIf01textBox.Size = new System.Drawing.Size(60, 22);
            this.resultNestedIf01textBox.TabIndex = 9;
            this.resultNestedIf01textBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "4)Nested if-Else";
            // 
            // resultSwitchDefault01textBox
            // 
            this.resultSwitchDefault01textBox.Location = new System.Drawing.Point(276, 153);
            this.resultSwitchDefault01textBox.Name = "resultSwitchDefault01textBox";
            this.resultSwitchDefault01textBox.ReadOnly = true;
            this.resultSwitchDefault01textBox.Size = new System.Drawing.Size(60, 22);
            this.resultSwitchDefault01textBox.TabIndex = 11;
            this.resultSwitchDefault01textBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "5)Switch w/default";
            // 
            // resultIf02textBox
            // 
            this.resultIf02textBox.Location = new System.Drawing.Point(276, 179);
            this.resultIf02textBox.Name = "resultIf02textBox";
            this.resultIf02textBox.ReadOnly = true;
            this.resultIf02textBox.Size = new System.Drawing.Size(60, 22);
            this.resultIf02textBox.TabIndex = 13;
            this.resultIf02textBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "6) if R/C";
            // 
            // resultNestedIf02textBox
            // 
            this.resultNestedIf02textBox.Location = new System.Drawing.Point(276, 210);
            this.resultNestedIf02textBox.Name = "resultNestedIf02textBox";
            this.resultNestedIf02textBox.ReadOnly = true;
            this.resultNestedIf02textBox.Size = new System.Drawing.Size(60, 22);
            this.resultNestedIf02textBox.TabIndex = 15;
            this.resultNestedIf02textBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "7)Nested if-Else";
            // 
            // resultElseIf02textBox
            // 
            this.resultElseIf02textBox.Location = new System.Drawing.Point(276, 239);
            this.resultElseIf02textBox.Name = "resultElseIf02textBox";
            this.resultElseIf02textBox.ReadOnly = true;
            this.resultElseIf02textBox.Size = new System.Drawing.Size(60, 22);
            this.resultElseIf02textBox.TabIndex = 17;
            this.resultElseIf02textBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "8)Else if R/C";
            // 
            // resultNestedIf2textBox
            // 
            this.resultNestedIf2textBox.Location = new System.Drawing.Point(276, 360);
            this.resultNestedIf2textBox.Name = "resultNestedIf2textBox";
            this.resultNestedIf2textBox.ReadOnly = true;
            this.resultNestedIf2textBox.Size = new System.Drawing.Size(60, 22);
            this.resultNestedIf2textBox.TabIndex = 26;
            this.resultNestedIf2textBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "12)Nested if-Else";
            // 
            // resultElseIf2textBox
            // 
            this.resultElseIf2textBox.Location = new System.Drawing.Point(276, 329);
            this.resultElseIf2textBox.Name = "resultElseIf2textBox";
            this.resultElseIf2textBox.ReadOnly = true;
            this.resultElseIf2textBox.Size = new System.Drawing.Size(60, 22);
            this.resultElseIf2textBox.TabIndex = 24;
            this.resultElseIf2textBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "11)Else if R/C";
            // 
            // resultIf2textBox
            // 
            this.resultIf2textBox.Location = new System.Drawing.Point(276, 300);
            this.resultIf2textBox.Name = "resultIf2textBox";
            this.resultIf2textBox.ReadOnly = true;
            this.resultIf2textBox.Size = new System.Drawing.Size(60, 22);
            this.resultIf2textBox.TabIndex = 22;
            this.resultIf2textBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "10) if R/C";
            // 
            // input2aTextBox
            // 
            this.input2aTextBox.Location = new System.Drawing.Point(163, 271);
            this.input2aTextBox.Name = "input2aTextBox";
            this.input2aTextBox.Size = new System.Drawing.Size(64, 22);
            this.input2aTextBox.TabIndex = 20;
            this.input2aTextBox.Text = "R";
            // 
            // resultSwitch02textBox
            // 
            this.resultSwitch02textBox.Location = new System.Drawing.Point(276, 271);
            this.resultSwitch02textBox.Name = "resultSwitch02textBox";
            this.resultSwitch02textBox.ReadOnly = true;
            this.resultSwitch02textBox.Size = new System.Drawing.Size(60, 22);
            this.resultSwitch02textBox.TabIndex = 19;
            this.resultSwitch02textBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "9) Switch R/C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 462);
            this.Controls.Add(this.resultNestedIf2textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultElseIf2textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultIf2textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.input2aTextBox);
            this.Controls.Add(this.resultSwitch02textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.resultElseIf02textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultNestedIf02textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultIf02textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultSwitchDefault01textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultNestedIf01textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultElseIf01textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultIf01textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.input1aTextBox);
            this.Controls.Add(this.resultSwitch01textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "mscheck 1g1 Switch, if-else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultSwitch01textBox;
        private System.Windows.Forms.TextBox input1aTextBox;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.TextBox resultIf01textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultElseIf01textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultNestedIf01textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultSwitchDefault01textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultIf02textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultNestedIf02textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultElseIf02textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultNestedIf2textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resultElseIf2textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resultIf2textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox input2aTextBox;
        private System.Windows.Forms.TextBox resultSwitch02textBox;
        private System.Windows.Forms.Label label12;
    }
}

