namespace sayı_tutma_oyunu
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
            this.lblSkor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbasla = new System.Windows.Forms.Button();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKOR:";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(365, 120);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(25, 13);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tahminin nedir ?\r\n";
            // 
            // btnbasla
            // 
            this.btnbasla.Location = new System.Drawing.Point(303, 94);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(75, 23);
            this.btnbasla.TabIndex = 3;
            this.btnbasla.Text = " BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(303, 184);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(75, 23);
            this.btnTahminEt.TabIndex = 4;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(290, 158);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.TextBox txtTahmin;
    }
}

