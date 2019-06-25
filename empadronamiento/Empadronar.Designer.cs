namespace empadronamiento
{
    partial class Empadronar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DPI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.comboBoxmunicipio = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.DEPARTAMENTO = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(174, 470);
            this.textBoxDPI.MaxLength = 10;
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(274, 20);
            this.textBoxDPI.TabIndex = 31;
            this.textBoxDPI.TextChanged += new System.EventHandler(this.textBoxDPI_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "CUI (DPI):";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(174, 431);
            this.textBoxnombre.MaxLength = 25;
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(274, 20);
            this.textBoxnombre.TabIndex = 29;
            this.textBoxnombre.TextChanged += new System.EventHandler(this.textBoxnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre Completo:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(278, 576);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(149, 51);
            this.Cancelar.TabIndex = 35;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(65, 576);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(149, 51);
            this.Registrar.TabIndex = 34;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "EMPADRONAR";
            // 
            // DPI
            // 
            this.DPI.Location = new System.Drawing.Point(148, 171);
            this.DPI.MaxLength = 10;
            this.DPI.Name = "DPI";
            this.DPI.Size = new System.Drawing.Size(274, 20);
            this.DPI.TabIndex = 38;
            this.DPI.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "CUI (DPI):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "YA ESTOY EMPADRONADO";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(171, 243);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(149, 51);
            this.Aceptar.TabIndex = 40;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // comboBoxmunicipio
            // 
            this.comboBoxmunicipio.FormattingEnabled = true;
            this.comboBoxmunicipio.Items.AddRange(new object[] {
            "Guatemala",
            "Quetzaltenango",
            "Retalhuleu",
            "Sololá",
            "Suchitepéquez"});
            this.comboBoxmunicipio.Location = new System.Drawing.Point(176, 507);
            this.comboBoxmunicipio.Name = "comboBoxmunicipio";
            this.comboBoxmunicipio.Size = new System.Drawing.Size(272, 21);
            this.comboBoxmunicipio.TabIndex = 32;
            this.comboBoxmunicipio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(144, 382);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Departamento:";
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.FormattingEnabled = true;
            this.DEPARTAMENTO.Items.AddRange(new object[] {
            "Guatemala",
            "Quetzaltenango",
            "Retalhuleu",
            "Sololá",
            "Suchitepéquez"});
            this.DEPARTAMENTO.Location = new System.Drawing.Point(148, 209);
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.Size = new System.Drawing.Size(272, 21);
            this.DEPARTAMENTO.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::empadronamiento.Properties.Resources.object1828597693;
            this.pictureBox1.Location = new System.Drawing.Point(-26, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::empadronamiento.Properties.Resources._1492812;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(476, 643);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RbInsertar
            // 
            this.RbInsertar.AutoSize = true;
            this.RbInsertar.Location = new System.Drawing.Point(94, 126);
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.Size = new System.Drawing.Size(14, 13);
            this.RbInsertar.TabIndex = 45;
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged);
            // 
            // Empadronar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 643);
            this.Controls.Add(this.RbInsertar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DEPARTAMENTO);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxmunicipio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Empadronar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Empadronar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DPI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.ComboBox comboBoxmunicipio;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DEPARTAMENTO;
        private System.Windows.Forms.RadioButton RbInsertar;
        
    }
}

