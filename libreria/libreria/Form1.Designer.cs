namespace libreria
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
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.boton_subirfoto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_descargar = new System.Windows.Forms.Button();
            this.txt_rutaArchivo = new System.Windows.Forms.TextBox();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(136, 33);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(121, 20);
            this.txt_titulo.TabIndex = 0;
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(136, 93);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(121, 20);
            this.txt_descrip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imagen";
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(136, 375);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(121, 23);
            this.boton_guardar.TabIndex = 6;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Terror",
            "Drama",
            "Psicología"});
            this.cb_categoria.Location = new System.Drawing.Point(136, 63);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 7;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(56, 156);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(201, 156);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 8;
            this.pb_foto.TabStop = false;
            // 
            // boton_subirfoto
            // 
            this.boton_subirfoto.Location = new System.Drawing.Point(136, 121);
            this.boton_subirfoto.Name = "boton_subirfoto";
            this.boton_subirfoto.Size = new System.Drawing.Size(121, 23);
            this.boton_subirfoto.TabIndex = 9;
            this.boton_subirfoto.Text = "Seleccionar";
            this.boton_subirfoto.UseVisualStyleBackColor = true;
            this.boton_subirfoto.Click += new System.EventHandler(this.boton_subirfoto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 359);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(289, 8);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 12;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(208, 7);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(136, 7);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(30, 20);
            this.id.TabIndex = 14;
            this.id.Text = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(563, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(161, 20);
            this.txt_buscar.TabIndex = 16;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(730, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 23);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 194);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(353, 443);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(407, 194);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btn_descargar
            // 
            this.btn_descargar.Location = new System.Drawing.Point(154, 643);
            this.btn_descargar.Name = "btn_descargar";
            this.btn_descargar.Size = new System.Drawing.Size(75, 23);
            this.btn_descargar.TabIndex = 20;
            this.btn_descargar.Text = "Descargar";
            this.btn_descargar.UseVisualStyleBackColor = true;
            this.btn_descargar.Click += new System.EventHandler(this.btn_descargar_Click);
            // 
            // txt_rutaArchivo
            // 
            this.txt_rutaArchivo.Location = new System.Drawing.Point(136, 349);
            this.txt_rutaArchivo.Name = "txt_rutaArchivo";
            this.txt_rutaArchivo.Size = new System.Drawing.Size(121, 20);
            this.txt_rutaArchivo.TabIndex = 21;
            this.txt_rutaArchivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(136, 320);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(121, 23);
            this.btn_archivo.TabIndex = 22;
            this.btn_archivo.Text = "Examinar";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_archivo);
            this.Controls.Add(this.txt_rutaArchivo);
            this.Controls.Add(this.btn_descargar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton_subirfoto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.txt_titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button boton_subirfoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_descargar;
        private System.Windows.Forms.TextBox txt_rutaArchivo;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

