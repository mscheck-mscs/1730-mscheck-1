namespace mischeck1C1
{
    partial class frmFoodTruck
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
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBotxtHotDogSubTotal = new System.Windows.Forms.TextBox();
            this.txtHamburgersSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHamburgers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBoxPretaxtotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hot Dogs:";
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.Location = new System.Drawing.Point(164, 49);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(57, 22);
            this.txtHotDogs.TabIndex = 1;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "x $4.00 =";
            // 
            // txtBotxtHotDogSubTotal
            // 
            this.txtBotxtHotDogSubTotal.Location = new System.Drawing.Point(299, 44);
            this.txtBotxtHotDogSubTotal.Name = "txtBotxtHotDogSubTotal";
            this.txtBotxtHotDogSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtBotxtHotDogSubTotal.TabIndex = 3;
            this.txtBotxtHotDogSubTotal.TabStop = false;
            this.txtBotxtHotDogSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHamburgersSubTotal
            // 
            this.txtHamburgersSubTotal.Location = new System.Drawing.Point(299, 85);
            this.txtHamburgersSubTotal.Name = "txtHamburgersSubTotal";
            this.txtHamburgersSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtHamburgersSubTotal.TabIndex = 15;
            this.txtHamburgersSubTotal.TabStop = false;
            this.txtHamburgersSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "x $5.00 =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtHamburgers
            // 
            this.txtHamburgers.Location = new System.Drawing.Point(164, 85);
            this.txtHamburgers.Name = "txtHamburgers";
            this.txtHamburgers.Size = new System.Drawing.Size(57, 22);
            this.txtHamburgers.TabIndex = 13;
            this.txtHamburgers.Text = "0";
            this.txtHamburgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hamburgers:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 280);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 27);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBoxPretaxtotal
            // 
            this.txtBoxPretaxtotal.Location = new System.Drawing.Point(299, 129);
            this.txtBoxPretaxtotal.Name = "txtBoxPretaxtotal";
            this.txtBoxPretaxtotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPretaxtotal.TabIndex = 17;
            this.txtBoxPretaxtotal.TabStop = false;
            this.txtBoxPretaxtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(299, 170);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTax.TabIndex = 18;
            this.txtBoxTax.TabStop = false;
            this.txtBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(299, 213);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTotal.TabIndex = 19;
            this.txtBoxTotal.TabStop = false;
            this.txtBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pretax total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 27);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(308, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 27);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFoodTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 329);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxTax);
            this.Controls.Add(this.txtBoxPretaxtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHamburgersSubTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHamburgers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBotxtHotDogSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.label1);
            this.Name = "frmFoodTruck";
            this.Text = "mischeck1c1:Food Truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBotxtHotDogSubTotal;
        private System.Windows.Forms.TextBox txtHamburgersSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHamburgers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBoxPretaxtotal;
        private System.Windows.Forms.TextBox txtBoxTax;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

