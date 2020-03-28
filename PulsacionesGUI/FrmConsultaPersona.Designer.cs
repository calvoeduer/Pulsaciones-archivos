namespace PulsacionesGUI
{
    partial class FrmConsultaPersona
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
            this.TablaPersona = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.txtTotalPersonas = new System.Windows.Forms.TextBox();
            this.txtSumarPulsacionesHombres = new System.Windows.Forms.TextBox();
            this.txtSumarPulsaciones = new System.Windows.Forms.TextBox();
            this.txtTotalMujeres = new System.Windows.Forms.TextBox();
            this.txtSumarPulsacionesMujeres = new System.Windows.Forms.TextBox();
            this.txtTotalHombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaPersona
            // 
            this.TablaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPersona.Location = new System.Drawing.Point(12, 49);
            this.TablaPersona.Name = "TablaPersona";
            this.TablaPersona.Size = new System.Drawing.Size(606, 402);
            this.TablaPersona.TabIndex = 0;
            this.TablaPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPersona_CellContentClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(544, 12);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(74, 31);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // txtTotalPersonas
            // 
            this.txtTotalPersonas.Location = new System.Drawing.Point(833, 45);
            this.txtTotalPersonas.Name = "txtTotalPersonas";
            this.txtTotalPersonas.ReadOnly = true;
            this.txtTotalPersonas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPersonas.TabIndex = 2;
            this.txtTotalPersonas.TextChanged += new System.EventHandler(this.TxtTotalPersonas_TextChanged);
            // 
            // txtSumarPulsacionesHombres
            // 
            this.txtSumarPulsacionesHombres.Location = new System.Drawing.Point(833, 329);
            this.txtSumarPulsacionesHombres.Name = "txtSumarPulsacionesHombres";
            this.txtSumarPulsacionesHombres.ReadOnly = true;
            this.txtSumarPulsacionesHombres.Size = new System.Drawing.Size(100, 20);
            this.txtSumarPulsacionesHombres.TabIndex = 3;
            // 
            // txtSumarPulsaciones
            // 
            this.txtSumarPulsaciones.Location = new System.Drawing.Point(833, 258);
            this.txtSumarPulsaciones.Name = "txtSumarPulsaciones";
            this.txtSumarPulsaciones.ReadOnly = true;
            this.txtSumarPulsaciones.Size = new System.Drawing.Size(100, 20);
            this.txtSumarPulsaciones.TabIndex = 4;
            // 
            // txtTotalMujeres
            // 
            this.txtTotalMujeres.Location = new System.Drawing.Point(833, 187);
            this.txtTotalMujeres.Name = "txtTotalMujeres";
            this.txtTotalMujeres.ReadOnly = true;
            this.txtTotalMujeres.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMujeres.TabIndex = 5;
            // 
            // txtSumarPulsacionesMujeres
            // 
            this.txtSumarPulsacionesMujeres.Location = new System.Drawing.Point(833, 400);
            this.txtSumarPulsacionesMujeres.Name = "txtSumarPulsacionesMujeres";
            this.txtSumarPulsacionesMujeres.ReadOnly = true;
            this.txtSumarPulsacionesMujeres.Size = new System.Drawing.Size(100, 20);
            this.txtSumarPulsacionesMujeres.TabIndex = 6;
            // 
            // txtTotalHombres
            // 
            this.txtTotalHombres.Location = new System.Drawing.Point(833, 116);
            this.txtTotalHombres.Name = "txtTotalHombres";
            this.txtTotalHombres.ReadOnly = true;
            this.txtTotalHombres.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHombres.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Totalizar Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Totalizar Hombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Totalizar Mujeres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sumar Pulsaciones";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sumar Pulsaciones Hombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(642, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sumar Pulsaciones Mujeres";
            // 
            // FrmConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalHombres);
            this.Controls.Add(this.txtSumarPulsacionesMujeres);
            this.Controls.Add(this.txtTotalMujeres);
            this.Controls.Add(this.txtSumarPulsaciones);
            this.Controls.Add(this.txtSumarPulsacionesHombres);
            this.Controls.Add(this.txtTotalPersonas);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TablaPersona);
            this.Name = "FrmConsultaPersona";
            this.Text = "FrmConsultaPersona";
            ((System.ComponentModel.ISupportInitialize)(this.TablaPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaPersona;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox txtTotalPersonas;
        private System.Windows.Forms.TextBox txtSumarPulsacionesHombres;
        private System.Windows.Forms.TextBox txtSumarPulsaciones;
        private System.Windows.Forms.TextBox txtTotalMujeres;
        private System.Windows.Forms.TextBox txtSumarPulsacionesMujeres;
        private System.Windows.Forms.TextBox txtTotalHombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}