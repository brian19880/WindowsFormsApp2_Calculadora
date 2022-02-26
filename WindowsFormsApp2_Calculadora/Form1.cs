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


       

        public int operacion;

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

            //txtbx_Entrada_Datos.Text = "0";
            //Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //txtbx_Entrada_Datos.Text = "";
            //txtbx_Entrada_Datos.Text = "2";
            //Valor_b = int.Parse(txtbx_Entrada_Datos.Text);

            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "2";
        }

        private void btn_Suma_Click(object sender, EventArgs e)
        {
            //Valor_r = Valor_a + Valor_b;
            operacion = 1;
            Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
            txtbx_Entrada_Datos.Text = "";


        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            //txtbx_Entrada_Datos.Text = Valor_r.ToString();

            switch (operacion)
            {

                case 1:
                    Valor_b = int.Parse(txtbx_Entrada_Datos.Text);
                    Valor_r=Valor_a+Valor_b;
                    txtbx_Entrada_Datos.Text = Valor_r.ToString();
                    break;

                case 2:
                    Valor_b = int.Parse(txtbx_Entrada_Datos.Text);
                    Valor_r = Valor_a - Valor_b;
                    txtbx_Entrada_Datos.Text = Valor_r.ToString();
                    break;
                case 3:
                    Valor_b = int.Parse(txtbx_Entrada_Datos.Text);
                    Valor_r = Valor_a * Valor_b;
                    txtbx_Entrada_Datos.Text = Valor_r.ToString();
                    break;
                case 4:
                    Valor_b = int.Parse(txtbx_Entrada_Datos.Text);
                    Valor_r = Valor_a / Valor_b;
                    txtbx_Entrada_Datos.Text = Valor_r.ToString();
                    break;
                    //default:
            }
            //Valor_r = Valor_a + Valor_b;
            //txtbx_Entrada_Datos.Text = Valor_r.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "3";
        }

        private void btn_Resta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
            txtbx_Entrada_Datos.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + "9";
        }

        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
            txtbx_Entrada_Datos.Text = "";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operacion = 4;
            Valor_a = int.Parse(txtbx_Entrada_Datos.Text);
            txtbx_Entrada_Datos.Text = "";
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            txtbx_Entrada_Datos.Text = "";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            //if (txtbx_Entrada_Datos.Text.Contains('.')==false)
            //{
            //    txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text + ".";
            //}

            txtbx_Entrada_Datos.Text = txtbx_Entrada_Datos.Text +"";
        }
    }
}
