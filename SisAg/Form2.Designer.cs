namespace SisAg
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox_misCultivos = new System.Windows.Forms.ComboBox();
            this.label_misCultivos = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.cuanto_regar_Btn = new System.Windows.Forms.Button();
            this.textBox_CuantoRegar = new System.Windows.Forms.TextBox();
            this.cuanto_abonar_Btn = new System.Windows.Forms.Button();
            this.textBox_cuanto_abonar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_generar_reporte = new System.Windows.Forms.Button();
            this.label_exito_estimado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_misCultivos
            // 
            this.comboBox_misCultivos.FormattingEnabled = true;
            this.comboBox_misCultivos.Location = new System.Drawing.Point(99, 219);
            this.comboBox_misCultivos.Name = "comboBox_misCultivos";
            this.comboBox_misCultivos.Size = new System.Drawing.Size(119, 21);
            this.comboBox_misCultivos.TabIndex = 0;
            this.comboBox_misCultivos.SelectedIndexChanged += new System.EventHandler(this.comboBox_misCultivos_SelectedIndexChanged);
            // 
            // label_misCultivos
            // 
            this.label_misCultivos.AutoSize = true;
            this.label_misCultivos.Location = new System.Drawing.Point(42, 222);
            this.label_misCultivos.Name = "label_misCultivos";
            this.label_misCultivos.Size = new System.Drawing.Size(42, 13);
            this.label_misCultivos.TabIndex = 1;
            this.label_misCultivos.Text = "Cultivo:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(33, 271);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(395, 100);
            this.descripcion.TabIndex = 3;
            this.descripcion.Text = "";
            // 
            // cuanto_regar_Btn
            // 
            this.cuanto_regar_Btn.Location = new System.Drawing.Point(45, 413);
            this.cuanto_regar_Btn.Name = "cuanto_regar_Btn";
            this.cuanto_regar_Btn.Size = new System.Drawing.Size(132, 23);
            this.cuanto_regar_Btn.TabIndex = 4;
            this.cuanto_regar_Btn.Text = "¿Cuanto regar?";
            this.cuanto_regar_Btn.UseVisualStyleBackColor = true;
            this.cuanto_regar_Btn.Click += new System.EventHandler(this.cuanto_regar_Btn_Click);
            // 
            // textBox_CuantoRegar
            // 
            this.textBox_CuantoRegar.Location = new System.Drawing.Point(200, 416);
            this.textBox_CuantoRegar.Name = "textBox_CuantoRegar";
            this.textBox_CuantoRegar.Size = new System.Drawing.Size(216, 20);
            this.textBox_CuantoRegar.TabIndex = 5;
            // 
            // cuanto_abonar_Btn
            // 
            this.cuanto_abonar_Btn.Location = new System.Drawing.Point(45, 475);
            this.cuanto_abonar_Btn.Name = "cuanto_abonar_Btn";
            this.cuanto_abonar_Btn.Size = new System.Drawing.Size(132, 23);
            this.cuanto_abonar_Btn.TabIndex = 6;
            this.cuanto_abonar_Btn.Text = "¿Cuanto abonar?";
            this.cuanto_abonar_Btn.UseVisualStyleBackColor = true;
            this.cuanto_abonar_Btn.Click += new System.EventHandler(this.cuanto_abonar_Btn_Click);
            // 
            // textBox_cuanto_abonar
            // 
            this.textBox_cuanto_abonar.Location = new System.Drawing.Point(200, 478);
            this.textBox_cuanto_abonar.Name = "textBox_cuanto_abonar";
            this.textBox_cuanto_abonar.Size = new System.Drawing.Size(216, 20);
            this.textBox_cuanto_abonar.TabIndex = 7;
            this.textBox_cuanto_abonar.TextChanged += new System.EventHandler(this.textBox_cuanto_abonar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_generar_reporte
            // 
            this.button_generar_reporte.Location = new System.Drawing.Point(45, 523);
            this.button_generar_reporte.Name = "button_generar_reporte";
            this.button_generar_reporte.Size = new System.Drawing.Size(371, 23);
            this.button_generar_reporte.TabIndex = 11;
            this.button_generar_reporte.Text = "Generar reporte";
            this.button_generar_reporte.UseVisualStyleBackColor = true;
            // 
            // label_exito_estimado
            // 
            this.label_exito_estimado.AutoSize = true;
            this.label_exito_estimado.Location = new System.Drawing.Point(270, 222);
            this.label_exito_estimado.Name = "label_exito_estimado";
            this.label_exito_estimado.Size = new System.Drawing.Size(81, 13);
            this.label_exito_estimado.TabIndex = 12;
            this.label_exito_estimado.Text = "Éxito estimado: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 558);
            this.Controls.Add(this.label_exito_estimado);
            this.Controls.Add(this.button_generar_reporte);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_cuanto_abonar);
            this.Controls.Add(this.cuanto_abonar_Btn);
            this.Controls.Add(this.textBox_CuantoRegar);
            this.Controls.Add(this.cuanto_regar_Btn);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label_misCultivos);
            this.Controls.Add(this.comboBox_misCultivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Mis cultivos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_misCultivos;
        private System.Windows.Forms.Label label_misCultivos;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.Button cuanto_regar_Btn;
        private System.Windows.Forms.TextBox textBox_CuantoRegar;
        private System.Windows.Forms.Button cuanto_abonar_Btn;
        private System.Windows.Forms.TextBox textBox_cuanto_abonar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_generar_reporte;
        private System.Windows.Forms.Label label_exito_estimado;
    }
}