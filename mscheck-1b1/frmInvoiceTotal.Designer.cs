namespace mscheck_1b1
{
    partial class frmInvoiceTotal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btncalucalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Subtotal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount percent:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(210, 94);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(158, 22);
            this.txtDiscountPercent.TabIndex = 3;
            this.txtDiscountPercent.TabStop = false;
            this.txtDiscountPercent.Text = "5";
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount amount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(210, 146);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(158, 22);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TabStop = false;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 22);
            this.textBox4.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(210, 44);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(158, 22);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(210, 191);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(158, 22);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btncalucalculate
            // 
            this.btncalucalculate.Location = new System.Drawing.Point(122, 241);
            this.btncalucalculate.Name = "btncalucalculate";
            this.btncalucalculate.Size = new System.Drawing.Size(90, 30);
            this.btncalucalculate.TabIndex = 4;
            this.btncalucalculate.Text = "&Calculate";
            this.btncalucalculate.UseVisualStyleBackColor = true;
            this.btncalucalculate.Click += new System.EventHandler(this.btncalucalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(227, 241);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(86, 30);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(72, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "&Subtotal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmInvoiceTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 294);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalucalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoiceTotal";
            this.Text = "mscheck1b1:Invoice Total Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btncalucalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label5;
    }
}

