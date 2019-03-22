namespace SisAg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Seleccionar_cultivo = new System.Windows.Forms.Label();
            this.comboBox_cultivos = new System.Windows.Forms.ComboBox();
            this.Mis_cultivos = new System.Windows.Forms.Button();
            this.label_fecha_siembra = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_terreno = new System.Windows.Forms.Label();
            this.textBox_terreno = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Seleccionar_cultivo
            // 
            this.Seleccionar_cultivo.AutoSize = true;
            this.Seleccionar_cultivo.Location = new System.Drawing.Point(46, 215);
            this.Seleccionar_cultivo.Name = "Seleccionar_cultivo";
            this.Seleccionar_cultivo.Size = new System.Drawing.Size(42, 13);
            this.Seleccionar_cultivo.TabIndex = 0;
            this.Seleccionar_cultivo.Text = "Cultivo:";
            // 
            // comboBox_cultivos
            // 
            this.comboBox_cultivos.FormattingEnabled = true;
            this.comboBox_cultivos.Items.AddRange(new object[] {
            "Maíz",
            "Jitomate",
            "Chile Serrano"});
            this.comboBox_cultivos.Location = new System.Drawing.Point(150, 212);
            this.comboBox_cultivos.Name = "comboBox_cultivos";
            this.comboBox_cultivos.Size = new System.Drawing.Size(200, 21);
            this.comboBox_cultivos.TabIndex = 1;
            // 
            // Mis_cultivos
            // 
            this.Mis_cultivos.Location = new System.Drawing.Point(52, 441);
            this.Mis_cultivos.Name = "Mis_cultivos";
            this.Mis_cultivos.Size = new System.Drawing.Size(298, 23);
            this.Mis_cultivos.TabIndex = 2;
            this.Mis_cultivos.Text = "Mis Cultivos";
            this.Mis_cultivos.UseVisualStyleBackColor = true;
            this.Mis_cultivos.Click += new System.EventHandler(this.Mis_cultivos_Click);
            // 
            // label_fecha_siembra
            // 
            this.label_fecha_siembra.AutoSize = true;
            this.label_fecha_siembra.Location = new System.Drawing.Point(46, 276);
            this.label_fecha_siembra.Name = "label_fecha_siembra";
            this.label_fecha_siembra.Size = new System.Drawing.Size(97, 13);
            this.label_fecha_siembra.TabIndex = 3;
            this.label_fecha_siembra.Text = "Fecha de siembra: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label_terreno
            // 
            this.label_terreno.AutoSize = true;
            this.label_terreno.Location = new System.Drawing.Point(46, 332);
            this.label_terreno.Name = "label_terreno";
            this.label_terreno.Size = new System.Drawing.Size(146, 13);
            this.label_terreno.TabIndex = 5;
            this.label_terreno.Text = "Dimensiones del terreno (m2):";
            // 
            // textBox_terreno
            // 
            this.textBox_terreno.Location = new System.Drawing.Point(201, 325);
            this.textBox_terreno.Name = "textBox_terreno";
            this.textBox_terreno.Size = new System.Drawing.Size(149, 20);
            this.textBox_terreno.TabIndex = 6;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(52, 399);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(298, 23);
            this.registrar.TabIndex = 7;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.textBox_terreno);
            this.Controls.Add(this.label_terreno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_fecha_siembra);
            this.Controls.Add(this.Mis_cultivos);
            this.Controls.Add(this.comboBox_cultivos);
            this.Controls.Add(this.Seleccionar_cultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sistema de Agricultura SisAg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Seleccionar_cultivo;
        private System.Windows.Forms.ComboBox comboBox_cultivos;
        private System.Windows.Forms.Button Mis_cultivos;
        private System.Windows.Forms.Label label_fecha_siembra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_terreno;
        private System.Windows.Forms.TextBox textBox_terreno;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

