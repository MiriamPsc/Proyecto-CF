﻿namespace _2P
{
    partial class Segundo
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
            this.C1 = new System.Windows.Forms.Button();
            this.M2 = new System.Windows.Forms.Button();
            this.E1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Republica Banana DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.SteelBlue;
            this.C1.Location = new System.Drawing.Point(291, 57);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(120, 63);
            this.C1.TabIndex = 7;
            this.C1.Text = "CONOCIMIENTO DEL MEDIO";
            this.C1.UseVisualStyleBackColor = true;
            // 
            // M2
            // 
            this.M2.Font = new System.Drawing.Font("Republica Banana DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2.ForeColor = System.Drawing.Color.SteelBlue;
            this.M2.Location = new System.Drawing.Point(151, 72);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(120, 30);
            this.M2.TabIndex = 6;
            this.M2.Text = "MATEMÁTICAS";
            this.M2.UseVisualStyleBackColor = true;
            // 
            // E1
            // 
            this.E1.Font = new System.Drawing.Font("Republica Banana DEMO", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E1.ForeColor = System.Drawing.Color.SteelBlue;
            this.E1.Location = new System.Drawing.Point(18, 72);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(104, 30);
            this.E1.TabIndex = 5;
            this.E1.Text = "ESPAÑOL";
            this.E1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sunday Best", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ELIGE LA MATERIA QUE QUIERES ESTUDIAR";
            // 
            // Segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 137);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.label1);
            this.Name = "Segundo";
            this.Text = "Segundo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Segundo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button M2;
        private System.Windows.Forms.Button E1;
        private System.Windows.Forms.Label label1;
    }
}