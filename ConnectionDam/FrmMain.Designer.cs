﻿namespace ConnectionDam
{
    partial class FrmMain
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
            this.btConectar = new System.Windows.Forms.Button();
            this.tbDerecha = new System.Windows.Forms.TextBox();
            this.tbIzquierda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(123, 105);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(75, 23);
            this.btConectar.TabIndex = 0;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // tbDerecha
            // 
            this.tbDerecha.Location = new System.Drawing.Point(98, 79);
            this.tbDerecha.Name = "tbDerecha";
            this.tbDerecha.Size = new System.Drawing.Size(100, 20);
            this.tbDerecha.TabIndex = 1;
            // 
            // tbIzquierda
            // 
            this.tbIzquierda.Location = new System.Drawing.Point(98, 53);
            this.tbIzquierda.Name = "tbIzquierda";
            this.tbIzquierda.Size = new System.Drawing.Size(100, 20);
            this.tbIzquierda.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIPLocal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btConectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDerecha);
            this.groupBox1.Controls.Add(this.tbIzquierda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IPs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vecino derecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vecino izquierda";
            // 
            // tbIPLocal
            // 
            this.tbIPLocal.Enabled = false;
            this.tbIPLocal.Location = new System.Drawing.Point(98, 27);
            this.tbIPLocal.Name = "tbIPLocal";
            this.tbIPLocal.Size = new System.Drawing.Size(100, 20);
            this.tbIPLocal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP Propia";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 202);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.TextBox tbDerecha;
        private System.Windows.Forms.TextBox tbIzquierda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIPLocal;
    }
}