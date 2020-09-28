namespace TipCalculator
{
    partial class TipCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.totalAmount = new System.Windows.Forms.Label();
            this.totalBillBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(180, 83);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 23);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Total";
            // 
            // calcButton
            // 
            this.calcButton.Enabled = false;
            this.calcButton.ForeColor = System.Drawing.Color.Crimson;
            this.calcButton.Location = new System.Drawing.Point(120, 165);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(90, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate Tip";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Visible = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip %";
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(180, 125);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 23);
            this.tipBox.TabIndex = 4;
            this.tipBox.TextChanged += new System.EventHandler(this.tipBox_TextChanged);
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Location = new System.Drawing.Point(60, 250);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(51, 15);
            this.totalAmount.TabIndex = 5;
            this.totalAmount.Text = "Total Bill";
            // 
            // totalBillBox
            // 
            this.totalBillBox.Location = new System.Drawing.Point(180, 247);
            this.totalBillBox.Name = "totalBillBox";
            this.totalBillBox.ReadOnly = true;
            this.totalBillBox.Size = new System.Drawing.Size(100, 23);
            this.totalBillBox.TabIndex = 6;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(180, 205);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(100, 23);
            this.outputBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip Amount";
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalBillBox);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "TipCalculator";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.TextBox totalBillBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label3;
    }
}

