namespace EgyptionCurrancy
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
            this.txtEgypt = new System.Windows.Forms.TextBox();
            this.txtdollar = new System.Windows.Forms.TextBox();
            this.txteuro = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEgypt
            // 
            this.txtEgypt.Location = new System.Drawing.Point(69, 38);
            this.txtEgypt.Name = "txtEgypt";
            this.txtEgypt.Size = new System.Drawing.Size(143, 20);
            this.txtEgypt.TabIndex = 0;
            this.txtEgypt.TextChanged += new System.EventHandler(this.txtEgypt_TextChanged);
            // 
            // txtdollar
            // 
            this.txtdollar.Enabled = false;
            this.txtdollar.Location = new System.Drawing.Point(69, 89);
            this.txtdollar.Name = "txtdollar";
            this.txtdollar.Size = new System.Drawing.Size(143, 20);
            this.txtdollar.TabIndex = 1;
            // 
            // txteuro
            // 
            this.txteuro.Enabled = false;
            this.txteuro.Location = new System.Drawing.Point(69, 149);
            this.txteuro.Name = "txteuro";
            this.txteuro.Size = new System.Drawing.Size(143, 20);
            this.txteuro.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.GrayText;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(79, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Egyption pound";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "U.S.Dollar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Euro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "S.A.R";
            // 
            // txtsar
            // 
            this.txtsar.Enabled = false;
            this.txtsar.Location = new System.Drawing.Point(69, 204);
            this.txtsar.Name = "txtsar";
            this.txtsar.Size = new System.Drawing.Size(143, 20);
            this.txtsar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtsar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txteuro);
            this.Controls.Add(this.txtdollar);
            this.Controls.Add(this.txtEgypt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEgypt;
        private System.Windows.Forms.TextBox txtdollar;
        private System.Windows.Forms.TextBox txteuro;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsar;
    }
}

