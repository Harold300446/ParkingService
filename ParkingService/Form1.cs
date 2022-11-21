using ParkingService.Properties;
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
    public partial class ParkingService : Form
    {
        Boolen []niz=new Boolen[15];
     
        
        public ParkingService()
        {
            InitializeComponent();
            lblTiempo.Text = DateTime.Now.ToString();
           
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString();
        }

        private void SalidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParkingService_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach(Control ctrl in tableLayoutPanel1.Controls)
            {
                Button btn = (Button)ctrl;
                if(btn.Text==e.KeyChar.ToString())
                {
                  btn.PerformClick();
                }
            }
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                Button btn = (Button)ctrl;
                if (btn.Text == e.KeyChar.ToString())
                {
                    btn.PerformClick();
                }
            }
            
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Text file(*.txt)|*.txt";
            if(svd.ShowDialog()==DialogResult.OK)
            {
                rtbEntrada.SaveFile(svd.FileName, RichTextBoxStreamType.PlainText);

            }
        }

      

        private void ReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserva rs = new Reserva(btn_seleccionado.Text);
            DialogResult d = rs.ShowDialog();
            if(d==DialogResult.OK)
            {
                rtbEntrada.Text += rs.ToString();
                
            }
            
            btn_seleccionado.BackColor = Color.Red;
            Settings.Default.brMjesta = Settings.Default.brMjesta-1;
            lblReserva.Text = (Settings.Default.brMjesta).ToString();
            
            
            
            this.Show();
            
                    
                
          
            
        }
        public Button btn_seleccionado = null;
       
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Button btn=(Button)sender;
                btn_seleccionado=btn;
                
            }
                

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (btn_seleccionado.BackColor == Color.Red)
            {
                ReservaToolStripMenuItem.Enabled = false;
                CobroToolStripMenuItem.Enabled = true;
            }
            else
            {
                ReservaToolStripMenuItem.Enabled = true;
                CobroToolStripMenuItem.Enabled = false;
            }
        }

        private void CobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_seleccionado.BackColor = Color.Lime;
            rtbEntrada.Text += "Lugar Numero " + btn_seleccionado.Text + " Partida " + DateTime.Now.ToString();
            Settings.Default.brMjesta++;
            lblReserva.Text = Settings.Default.brMjesta.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtbEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
