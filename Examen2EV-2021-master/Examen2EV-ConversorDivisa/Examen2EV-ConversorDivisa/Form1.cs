using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// María del Camren García Mora 
// Examen Entornos 20-21

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaramos la constante que convierte entre euros y dolares.
        // Constantes cambiadas con MCGM2021
        const double CONV1_MCGM2021 = 0.826;  // 1 dolar, 0,826 euros
        const double CONV2_MCGM2021 = 1.1485; // 1 libra, 1,1485 euros

        private void btDolaresAEuros_Click(object sender, EventArgs e)
        {
            double euros, dolares;

            dolares = double.Parse(tImporte.Text);
            euros = dolares * CONV1_MCGM2021;

            tResultado.Text = euros.ToString();
        }

        private void btEurosADolares_Click(object sender, EventArgs e)
        {
            double euros, dolares;

            euros = double.Parse(tImporte.Text);

            //Modificado a división
            dolares = euros / CONV1_MCGM2021;

            tResultado.Text = dolares.ToString();
        }

        private void btLibrasAEuros_Click(object sender, EventArgs e)
        {
            double euros, libras;

            libras = double.Parse(tImporte.Text);

            // Cambiada por la segunda constante
            euros = libras * CONV2_MCGM2021;

            tResultado.Text = euros.ToString();
        }

        private void btEurosALibras_Click(object sender, EventArgs e)
        {
            double euros, libras;

            euros = double.Parse(tResultado.Text);

            // Cambiada por la segunda constante
            libras = euros / CONV2_MCGM2021;

            tImporte.Text = libras.ToString();
        }
    }
}
