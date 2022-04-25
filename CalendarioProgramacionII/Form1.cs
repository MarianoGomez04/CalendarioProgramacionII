using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarioProgramacionII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            int Dias;
            int Mes1;
            int Mes2;
            int Mes3;
            int Mes4;
            int Mes5;
            int Mes6;
            int Mes7;
            int Mes8;
            int Mes9;
            int Mes10;
            int Mes11;
            int Mes12;
            int Año;

            Mes1 = 1;
            Mes2 = 2;
            Mes3 = 3;
            Mes4 = 4;
            Mes5 = 5;
            Mes6 = 6;
            Mes7 = 7;
            Mes8 = 8;
            Mes9 = 9;
            Mes10 = 10;
            Mes11 = 11;
            Mes12 = 12;


            lblMostrar.Text = System.Convert.ToString(txtFecha.Text) + "," + System.Convert.ToString(txtMes.Text) + "," + System.Convert.ToString(txtAño.Text);

            if (Mes1 == 1)
            {
                
                lblMostrar.Text = txtFecha.Text + "," + "de Enero" + "," + txtAño.Text;
            }

            if (Mes2 == 2)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Febrero" + "," + txtAño.Text;
            }
            if (Mes3 == 3)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Marzo" + "," + txtAño.Text;
            }
            if (Mes4 == 4)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Abril" + "," + txtAño.Text;
            }
            if (Mes5 == 5)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Mayo" + "," + txtAño.Text;
            }
            if (Mes6 == 6)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Junio" + "," + txtAño.Text;
            }
            if (Mes7 == 7)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Julio" + "," + txtAño.Text;
            }
            if (Mes8 == 8)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Agosto" + "," + txtAño.Text;
            }
            if (Mes9 == 9)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Septiembre" + "," + txtAño.Text;
            }
            if (Mes10 == 10)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Octubre" + "," + txtAño.Text;
            }
            if (Mes11 == 11)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Noviembre" + "," + txtAño.Text;
            }
            if (Mes12 == 12)
            {

                lblMostrar.Text = txtFecha.Text + "," + "de Diciembre" + "," + txtAño.Text;
            }






        }
    }
}
