namespace Home
{
    partial class Nutrientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUbica = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_Cultivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Germinacion = new System.Windows.Forms.Button();
            this.Crecimiento = new System.Windows.Forms.Button();
            this.Floracion = new System.Windows.Forms.Button();
            this.Inconvenientes = new System.Windows.Forms.Button();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNutrientes = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nutri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.txtUbica);
            this.panel1.Controls.Add(this.txtNomb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName_Cultivo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 85);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUbica
            // 
            this.txtUbica.Location = new System.Drawing.Point(298, 23);
            this.txtUbica.Name = "txtUbica";
            this.txtUbica.Size = new System.Drawing.Size(166, 20);
            this.txtUbica.TabIndex = 7;
            // 
            // txtNomb
            // 
            this.txtNomb.Location = new System.Drawing.Point(101, 23);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(166, 20);
            this.txtNomb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubicacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Oficial:";
            // 
            // txtName_Cultivo
            // 
            this.txtName_Cultivo.AutoSize = true;
            this.txtName_Cultivo.Location = new System.Drawing.Point(87, 13);
            this.txtName_Cultivo.Name = "txtName_Cultivo";
            this.txtName_Cultivo.Size = new System.Drawing.Size(0, 13);
            this.txtName_Cultivo.TabIndex = 1;
            this.txtName_Cultivo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especie,
            this.Date,
            this.Estado,
            this.Nutri});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(319, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 287);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Germinacion
            // 
            this.Germinacion.BackColor = System.Drawing.Color.Peru;
            this.Germinacion.Location = new System.Drawing.Point(306, 398);
            this.Germinacion.Name = "Germinacion";
            this.Germinacion.Size = new System.Drawing.Size(114, 40);
            this.Germinacion.TabIndex = 2;
            this.Germinacion.Text = "Germinacion";
            this.Germinacion.UseVisualStyleBackColor = false;
            this.Germinacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crecimiento
            // 
            this.Crecimiento.BackColor = System.Drawing.Color.Sienna;
            this.Crecimiento.Location = new System.Drawing.Point(435, 398);
            this.Crecimiento.Name = "Crecimiento";
            this.Crecimiento.Size = new System.Drawing.Size(99, 40);
            this.Crecimiento.TabIndex = 3;
            this.Crecimiento.Text = "Crecimiento";
            this.Crecimiento.UseVisualStyleBackColor = false;
            // 
            // Floracion
            // 
            this.Floracion.BackColor = System.Drawing.Color.Sienna;
            this.Floracion.Location = new System.Drawing.Point(551, 398);
            this.Floracion.Name = "Floracion";
            this.Floracion.Size = new System.Drawing.Size(110, 40);
            this.Floracion.TabIndex = 4;
            this.Floracion.Text = "Floracion";
            this.Floracion.UseVisualStyleBackColor = false;
            // 
            // Inconvenientes
            // 
            this.Inconvenientes.BackColor = System.Drawing.Color.Peru;
            this.Inconvenientes.Location = new System.Drawing.Point(678, 398);
            this.Inconvenientes.Name = "Inconvenientes";
            this.Inconvenientes.Size = new System.Drawing.Size(110, 40);
            this.Inconvenientes.TabIndex = 5;
            this.Inconvenientes.Text = "Inconvenientes";
            this.Inconvenientes.UseVisualStyleBackColor = false;
            this.Inconvenientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(12, 116);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(254, 20);
            this.txtEspecie.TabIndex = 6;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(12, 177);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(254, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(12, 241);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(254, 20);
            this.txtEstado.TabIndex = 8;
            // 
            // txtNutrientes
            // 
            this.txtNutrientes.Location = new System.Drawing.Point(12, 310);
            this.txtNutrientes.Name = "txtNutrientes";
            this.txtNutrientes.Size = new System.Drawing.Size(254, 20);
            this.txtNutrientes.TabIndex = 9;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Sienna;
            this.btnPost.Location = new System.Drawing.Point(34, 367);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(213, 55);
            this.btnPost.TabIndex = 10;
            this.btnPost.Text = "Almacenar";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha Siembra";
            this.Date.Name = "Date";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Ultimo Estado Conocido";
            this.Estado.Name = "Estado";
            // 
            // Nutri
            // 
            this.Nutri.HeaderText = "Nutrientes";
            this.Nutri.Name = "Nutri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Especie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Siembra (dd/mm/aa): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado Actual:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nutrientes por Almacenar: ";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Maroon;
            this.Home.Location = new System.Drawing.Point(660, 1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(141, 81);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Nutrientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtNutrientes);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.Inconvenientes);
            this.Controls.Add(this.Floracion);
            this.Controls.Add(this.Crecimiento);
            this.Controls.Add(this.Germinacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Nutrientes";
            this.Text = "Registro de Nutri/Estados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtName_Cultivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Germinacion;
        private System.Windows.Forms.Button Crecimiento;
        private System.Windows.Forms.Button Floracion;
        private System.Windows.Forms.Button Inconvenientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.TextBox txtUbica;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNutrientes;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nutri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Home;
    }
}