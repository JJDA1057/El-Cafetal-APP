using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home
{
    public partial class index : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public index()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nutrientes newLink = new Nutrientes();
            newLink.Show();

            string cultivo = txtN_cultivo.Text;
            string dueño = txtN_Prop.Text;
                string ubicat = txtUbi.Text;
                string Date = txtMK_Fecha.Text;

            if (string.IsNullOrWhiteSpace(cultivo) ||
            string.IsNullOrWhiteSpace(dueño) ||
            string.IsNullOrWhiteSpace(ubicat) ||
            string.IsNullOrWhiteSpace(Date))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (ValidarRolSeleccionado())
            {
               
                txtN_cultivo.Text = "";
                txtN_Prop.Text = "";
                txtUbi.Text = "";
                txtMK_Fecha.Text = "";

                MessageBox.Show("Lote creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtN_cultivo.Text="";
            txtN_Prop.Text = "";
            txtUbi.Text = "";
            txtMK_Fecha.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarRolSeleccionado()
        {
            if (cbxRol.SelectedIndex <= 0)
            {
                errorProvider.SetError(cbxRol, "Debe especificar su cargo: ");
                MessageBox.Show("Debe tener un cargo administrativo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string rol = cbxRol.SelectedItem.ToString();
            if (rol == "Supervisor" || rol == "Proveedor")
            {
                errorProvider.SetError(cbxRol, "Usted no tiene permisos para crear lotes");
                MessageBox.Show($"El señor '{txtN_Prop.Text}' no tiene permisos para crear lotes.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            errorProvider.SetError(cbxRol, "");
            return true;
        }

    }
}
