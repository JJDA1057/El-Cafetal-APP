using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Nutrientes : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public Nutrientes()
        {

            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Especie";
            dataGridView1.Columns[1].Name = "Fecha Siembra";
            dataGridView1.Columns[2].Name = "Ultimo Estado Conocido";
            dataGridView1.Columns[3].Name = "Nutrientes";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoCultiv_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            index goBack = new index();
            goBack.Show();
           
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
           
            dataGridView1 = new DataGridView();
            dataGridView1.Rows.Add(txtName_Cultivo.Text);

        }
    }
}
