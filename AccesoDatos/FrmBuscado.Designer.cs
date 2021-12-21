
namespace AccesoDatos
{
    partial class FrmBuscado
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
            this.CmbPersonas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFeNa = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaNaci = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sellecione la persona";
            // 
            // CmbPersonas
            // 
            this.CmbPersonas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbPersonas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbPersonas.FormattingEnabled = true;
            this.CmbPersonas.Location = new System.Drawing.Point(170, 41);
            this.CmbPersonas.Name = "CmbPersonas";
            this.CmbPersonas.Size = new System.Drawing.Size(643, 21);
            this.CmbPersonas.TabIndex = 1;
            this.CmbPersonas.SelectedIndexChanged += new System.EventHandler(this.CmbPersonas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFechaNaci);
            this.groupBox1.Controls.Add(this.TxtFeNa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LAS PERSONAS";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(353, 274);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(301, 20);
            this.txtPeso.TabIndex = 22;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(353, 191);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(301, 20);
            this.txtNombres.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(353, 149);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(301, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(353, 108);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(301, 20);
            this.txtCedula.TabIndex = 19;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Peso en kilogramos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cédula de identidad";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(843, 33);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(88, 47);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // TxtFeNa
            // 
            this.TxtFeNa.Location = new System.Drawing.Point(353, 317);
            this.TxtFeNa.Name = "TxtFeNa";
            this.TxtFeNa.Size = new System.Drawing.Size(301, 20);
            this.TxtFeNa.TabIndex = 25;
            // 
            // TxtFechaNaci
            // 
            this.TxtFechaNaci.Location = new System.Drawing.Point(353, 233);
            this.TxtFechaNaci.Name = "TxtFechaNaci";
            this.TxtFechaNaci.ReadOnly = true;
            this.TxtFechaNaci.Size = new System.Drawing.Size(301, 20);
            this.TxtFechaNaci.TabIndex = 26;
            // 
            // FrmBuscado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbPersonas);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscado";
            this.Text = "Busqueda de Información";
            this.Load += new System.EventHandler(this.FrmBuscado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPersonas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtFechaNaci;
        private System.Windows.Forms.DateTimePicker TxtFeNa;
        private System.Windows.Forms.Label label7;
    }
}