namespace Home
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.Entrar = new System.Windows.Forms.Button();
            this.txtN_cultivo = new System.Windows.Forms.TextBox();
            this.txtN_Prop = new System.Windows.Forms.TextBox();
            this.txtUbi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK_Fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmk_Fecha = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Peru;
            this.Entrar.Location = new System.Drawing.Point(186, 508);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(176, 51);
            this.Entrar.TabIndex = 0;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN_cultivo
            // 
            this.txtN_cultivo.Location = new System.Drawing.Point(164, 267);
            this.txtN_cultivo.Name = "txtN_cultivo";
            this.txtN_cultivo.Size = new System.Drawing.Size(240, 20);
            this.txtN_cultivo.TabIndex = 1;
            this.txtN_cultivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtN_Prop
            // 
            this.txtN_Prop.Location = new System.Drawing.Point(164, 321);
            this.txtN_Prop.Name = "txtN_Prop";
            this.txtN_Prop.Size = new System.Drawing.Size(240, 20);
            this.txtN_Prop.TabIndex = 2;
            this.txtN_Prop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUbi
            // 
            this.txtUbi.Location = new System.Drawing.Point(164, 377);
            this.txtUbi.Name = "txtUbi";
            this.txtUbi.Size = new System.Drawing.Size(240, 20);
            this.txtUbi.TabIndex = 3;
            this.txtUbi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Lote: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMK_Fecha
            // 
            this.txtMK_Fecha.Location = new System.Drawing.Point(164, 439);
            this.txtMK_Fecha.Name = "txtMK_Fecha";
            this.txtMK_Fecha.Size = new System.Drawing.Size(240, 20);
            this.txtMK_Fecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Propietario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ubicacion: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmk_Fecha
            // 
            this.lblmk_Fecha.AutoSize = true;
            this.lblmk_Fecha.Location = new System.Drawing.Point(161, 423);
            this.lblmk_Fecha.Name = "lblmk_Fecha";
            this.lblmk_Fecha.Size = new System.Drawing.Size(103, 13);
            this.lblmk_Fecha.TabIndex = 9;
            this.lblmk_Fecha.Text = "Fecha de Creacion: ";
            this.lblmk_Fecha.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.Sienna;
            this.btnVaciar.Location = new System.Drawing.Point(436, 12);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(109, 37);
            this.btnVaciar.TabIndex = 10;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbxRol
            // 
            this.cbxRol.BackColor = System.Drawing.Color.SaddleBrown;
            this.cbxRol.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "Supervisor",
            "Proveedor",
            "Agricultor",
            "Admin"});
            this.cbxRol.Location = new System.Drawing.Point(12, 12);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(116, 30);
            this.cbxRol.TabIndex = 11;
            this.cbxRol.Text = "Cargo...";
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.lblmk_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMK_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUbi);
            this.Controls.Add(this.txtN_Prop);
            this.Controls.Add(this.txtN_cultivo);
            this.Controls.Add(this.Entrar);
            this.Name = "index";
            this.Text = "Creacion de Cultivos";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox txtN_cultivo;
        private System.Windows.Forms.TextBox txtN_Prop;
        private System.Windows.Forms.TextBox txtUbi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK_Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmk_Fecha;
        public System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}