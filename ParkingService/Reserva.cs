using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingService
{
    public partial class Reserva : Form
    { 
        string nombre;
        public Reserva()
        {
            InitializeComponent();
           
        }
        public Reserva(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.Text = "M" + nombre + " " + "parking ";
        }
        public string Lugar
        {
            get
            { return nombre; }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtTiempo.Enabled = false;
            txtTiempo.Text = DateTime.Now.ToString();
        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {
            if(txtTiempo.Text!="" && txtRegistro.Text!="" && txtDocumento.Text!="")
            {
                btnReserva.Enabled = true;
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtTiempo.Text != "" && txtRegistro.Text != "" && txtDocumento.Text != "")
            {
                btnReserva.Enabled = true;
            }
        }

        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (txtTiempo.Text != "" && txtRegistro.Text != "" && txtDocumento.Text != "")
            {
                btnReserva.Enabled = true;
            }
        }
       
        private void btnReserva_Click(object sender, EventArgs e)
        {
                  
            this.DialogResult = DialogResult.OK;
          
            
        }
        public override string ToString()
        {
            return "Lugar Numero " + Lugar + " Hora de llegada " + txtTiempo.Text + "\n" + " Registro: " + txtRegistro.Text + "\n" + "Tipo de Vehiculo: " + comboBox1.Text + "\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
