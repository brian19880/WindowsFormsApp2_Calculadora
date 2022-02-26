using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Calculadora
{
    public partial class Form1 : Form
    {
        public int Valor_a = 0;
        public int Valor_b = 0;
        public int Valor_r = 0;

        public string aux_val_a= "";
        public string aux_val_b = "";
        public string aux_val_r = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola mundo");

            txtbx_Entrada_Datos.Text = "0";
            Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = "";
            txtbx_Entrada_Datos.Text = "2";
            Valor_b = int.Parse(txtbx_Entrada_Datos.Text);
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            Valor_r = Valor_a + Valor_b;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = Valor_r.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "1";
        }
    }
}
