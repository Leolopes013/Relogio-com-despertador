using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Despertador
{
	public partial class Form1 : Form
	{
		public Form1() //construtor da Classe Form1 - Despertador
		{
			InitializeComponent();
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString().ToString();
            if (chkAtivar.Checked)
            {

                if (lblHoraAtual.Text == mskDespertar.Text)
                {
                    MessageBox.Show("Hora de Despertar!");
                }
            }
        }

        private void mskDespertar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
