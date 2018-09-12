namespace mscheck1e1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.Average = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.BuCalculate = new System.Windows.Forms.Button();
            this.buClear = new System.Windows.Forms.Button();
            this.buExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Test 3:";
            // 
            // txtTest1
            // 
            this.txtTest1.AcceptsTab = true;
            this.txtTest1.Location = new System.Drawing.Point(167, 41);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(108, 22);
            this.txtTest1.TabIndex = 0;
            this.txtTest1.Text = "0";
            this.txtTest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2
            // 
            this.txtTest2.AcceptsTab = true;
            this.txtTest2.Location = new System.Drawing.Point(167, 92);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(108, 22);
            this.txtTest2.TabIndex = 1;
            this.txtTest2.Text = "0";
            this.txtTest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3
            // 
            this.txtTest3.AcceptsTab = true;
            this.txtTest3.Location = new System.Drawing.Point(167, 137);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(108, 22);
            this.txtTest3.TabIndex = 2;
            this.txtTest3.Text = "0";
            this.txtTest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average.Location = new System.Drawing.Point(45, 215);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(65, 18);
            this.Average.TabIndex = 9;
            this.Average.Text = "Average:";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(167, 211);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(108, 22);
            this.txtAverage.TabIndex = 10;
            this.txtAverage.Text = "0";
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BuCalculate
            // 
            this.BuCalculate.Location = new System.Drawing.Point(339, 48);
            this.BuCalculate.Name = "BuCalculate";
            this.BuCalculate.Size = new System.Drawing.Size(145, 32);
            this.BuCalculate.TabIndex = 3;
            this.BuCalculate.Text = "&Calculate";
            this.BuCalculate.UseVisualStyleBackColor = true;
            this.BuCalculate.Click += new System.EventHandler(this.BuCalculate_Click);
            // 
            // buClear
            // 
            this.buClear.Location = new System.Drawing.Point(339, 104);
            this.buClear.Name = "buClear";
            this.buClear.Size = new System.Drawing.Size(145, 32);
            this.buClear.TabIndex = 4;
            this.buClear.Text = "C&lear";
            this.buClear.UseVisualStyleBackColor = true;
            this.buClear.Click += new System.EventHandler(this.buClear_Click);
            // 
            // buExit
            // 
            this.buExit.Location = new System.Drawing.Point(339, 159);
            this.buExit.Name = "buExit";
            this.buExit.Size = new System.Drawing.Size(145, 34);
            this.buExit.TabIndex = 5;
            this.buExit.Text = "&Exit";
            this.buExit.UseVisualStyleBackColor = true;
            this.buExit.Click += new System.EventHandler(this.buExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 273);
            this.Controls.Add(this.buExit);
            this.Controls.Add(this.buClear);
            this.Controls.Add(this.BuCalculate);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "mscheck 1E";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button BuCalculate;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.Button buExit;
    }
}

