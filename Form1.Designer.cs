﻿namespace ProyectoN1
{
    partial class Form1
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
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.txtcombo2 = new System.Windows.Forms.TextBox();
            this.txtcombo1 = new System.Windows.Forms.TextBox();
            this.BtnCargarEquipos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxPosicion = new System.Windows.Forms.ListBox();
            this.listBoxClub = new System.Windows.Forms.ListBox();
            this.listBoxJugados = new System.Windows.Forms.ListBox();
            this.listBoxPts = new System.Windows.Forms.ListBox();
            this.listBoxGanados = new System.Windows.Forms.ListBox();
            this.listBoxEmpates = new System.Windows.Forms.ListBox();
            this.listBoxPerdidos = new System.Windows.Forms.ListBox();
            this.listBoxGFavor = new System.Windows.Forms.ListBox();
            this.listBoxGContra = new System.Windows.Forms.ListBox();
            this.listBoxDGoles = new System.Windows.Forms.ListBox();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo1
            // 
            this.combo1.Enabled = false;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(12, 53);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(143, 28);
            this.combo1.TabIndex = 2;
            // 
            // combo2
            // 
            this.combo2.Enabled = false;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(245, 54);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(143, 28);
            this.combo2.TabIndex = 3;
            // 
            // txtcombo2
            // 
            this.txtcombo2.Enabled = false;
            this.txtcombo2.Location = new System.Drawing.Point(394, 55);
            this.txtcombo2.Name = "txtcombo2";
            this.txtcombo2.Size = new System.Drawing.Size(62, 27);
            this.txtcombo2.TabIndex = 4;
            // 
            // txtcombo1
            // 
            this.txtcombo1.Enabled = false;
            this.txtcombo1.Location = new System.Drawing.Point(161, 54);
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(78, 27);
            this.txtcombo1.TabIndex = 5;
            // 
            // BtnCargarEquipos
            // 
            this.BtnCargarEquipos.Location = new System.Drawing.Point(12, 12);
            this.BtnCargarEquipos.Name = "BtnCargarEquipos";
            this.BtnCargarEquipos.Size = new System.Drawing.Size(138, 35);
            this.BtnCargarEquipos.TabIndex = 6;
            this.BtnCargarEquipos.Text = "Cargar Equipos";
            this.BtnCargarEquipos.UseVisualStyleBackColor = true;
            this.BtnCargarEquipos.Click += new System.EventHandler(this.BtnCargarEquipos_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Club";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(245, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "J";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pts";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(338, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "G";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(387, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "E";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(436, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "P";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(485, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "GF";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(534, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "GC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(583, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "DG";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPosicion
            // 
            this.listBoxPosicion.FormattingEnabled = true;
            this.listBoxPosicion.ItemHeight = 20;
            this.listBoxPosicion.Location = new System.Drawing.Point(12, 194);
            this.listBoxPosicion.Name = "listBoxPosicion";
            this.listBoxPosicion.Size = new System.Drawing.Size(80, 184);
            this.listBoxPosicion.TabIndex = 17;
            // 
            // listBoxClub
            // 
            this.listBoxClub.FormattingEnabled = true;
            this.listBoxClub.ItemHeight = 20;
            this.listBoxClub.Location = new System.Drawing.Point(98, 194);
            this.listBoxClub.Name = "listBoxClub";
            this.listBoxClub.Size = new System.Drawing.Size(141, 184);
            this.listBoxClub.TabIndex = 18;
            // 
            // listBoxJugados
            // 
            this.listBoxJugados.FormattingEnabled = true;
            this.listBoxJugados.ItemHeight = 20;
            this.listBoxJugados.Location = new System.Drawing.Point(247, 194);
            this.listBoxJugados.Name = "listBoxJugados";
            this.listBoxJugados.Size = new System.Drawing.Size(36, 184);
            this.listBoxJugados.TabIndex = 19;
            // 
            // listBoxPts
            // 
            this.listBoxPts.FormattingEnabled = true;
            this.listBoxPts.ItemHeight = 20;
            this.listBoxPts.Location = new System.Drawing.Point(289, 194);
            this.listBoxPts.Name = "listBoxPts";
            this.listBoxPts.Size = new System.Drawing.Size(43, 184);
            this.listBoxPts.TabIndex = 20;
            // 
            // listBoxGanados
            // 
            this.listBoxGanados.FormattingEnabled = true;
            this.listBoxGanados.ItemHeight = 20;
            this.listBoxGanados.Location = new System.Drawing.Point(338, 194);
            this.listBoxGanados.Name = "listBoxGanados";
            this.listBoxGanados.Size = new System.Drawing.Size(43, 184);
            this.listBoxGanados.TabIndex = 21;
            // 
            // listBoxEmpates
            // 
            this.listBoxEmpates.FormattingEnabled = true;
            this.listBoxEmpates.ItemHeight = 20;
            this.listBoxEmpates.Location = new System.Drawing.Point(387, 194);
            this.listBoxEmpates.Name = "listBoxEmpates";
            this.listBoxEmpates.Size = new System.Drawing.Size(43, 184);
            this.listBoxEmpates.TabIndex = 22;
            // 
            // listBoxPerdidos
            // 
            this.listBoxPerdidos.FormattingEnabled = true;
            this.listBoxPerdidos.ItemHeight = 20;
            this.listBoxPerdidos.Location = new System.Drawing.Point(436, 194);
            this.listBoxPerdidos.Name = "listBoxPerdidos";
            this.listBoxPerdidos.Size = new System.Drawing.Size(43, 184);
            this.listBoxPerdidos.TabIndex = 23;
            // 
            // listBoxGFavor
            // 
            this.listBoxGFavor.FormattingEnabled = true;
            this.listBoxGFavor.ItemHeight = 20;
            this.listBoxGFavor.Location = new System.Drawing.Point(485, 194);
            this.listBoxGFavor.Name = "listBoxGFavor";
            this.listBoxGFavor.Size = new System.Drawing.Size(43, 184);
            this.listBoxGFavor.TabIndex = 24;
            // 
            // listBoxGContra
            // 
            this.listBoxGContra.FormattingEnabled = true;
            this.listBoxGContra.ItemHeight = 20;
            this.listBoxGContra.Location = new System.Drawing.Point(534, 194);
            this.listBoxGContra.Name = "listBoxGContra";
            this.listBoxGContra.Size = new System.Drawing.Size(43, 184);
            this.listBoxGContra.TabIndex = 25;
            // 
            // listBoxDGoles
            // 
            this.listBoxDGoles.FormattingEnabled = true;
            this.listBoxDGoles.ItemHeight = 20;
            this.listBoxDGoles.Location = new System.Drawing.Point(583, 194);
            this.listBoxDGoles.Name = "listBoxDGoles";
            this.listBoxDGoles.Size = new System.Drawing.Size(43, 184);
            this.listBoxDGoles.TabIndex = 26;
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(462, 55);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(143, 28);
            this.BtnResultado.TabIndex = 27;
            this.BtnResultado.Text = "Resultado";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 475);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.listBoxDGoles);
            this.Controls.Add(this.listBoxGContra);
            this.Controls.Add(this.listBoxGFavor);
            this.Controls.Add(this.listBoxPerdidos);
            this.Controls.Add(this.listBoxEmpates);
            this.Controls.Add(this.listBoxGanados);
            this.Controls.Add(this.listBoxPts);
            this.Controls.Add(this.listBoxJugados);
            this.Controls.Add(this.listBoxClub);
            this.Controls.Add(this.listBoxPosicion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCargarEquipos);
            this.Controls.Add(this.txtcombo1);
            this.Controls.Add(this.txtcombo2);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox combo1;
        private ComboBox combo2;
        private TextBox txtcombo2;
        private TextBox txtcombo1;
        private Button BtnCargarEquipos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox listBoxPosicion;
        private ListBox listBoxClub;
        private ListBox listBoxJugados;
        private ListBox listBoxPts;
        private ListBox listBoxGanados;
        private ListBox listBoxEmpates;
        private ListBox listBoxPerdidos;
        private ListBox listBoxGFavor;
        private ListBox listBoxGContra;
        private ListBox listBoxDGoles;
        private Button BtnResultado;
    }
}