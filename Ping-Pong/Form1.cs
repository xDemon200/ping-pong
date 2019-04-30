using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnjugar_Click(object sender, EventArgs e)
        {
            VentanaJuego obj = new VentanaJuego();
            obj.Show(this);
            this.Hide();
            
            
        }
    }
}
