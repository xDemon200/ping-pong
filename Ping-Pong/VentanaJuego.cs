using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;//para dibujar

namespace Ping_Pong
{
    public partial class VentanaJuego : Form
    {
        public VentanaJuego()
        {
            InitializeComponent();
        }

        int Velocidad = 5;
        int Contador = 0;//Puntuaje
        int Puntuaje = 0;
        bool Arriba, Izquierda;

        private void VentanaJuego_Load(object sender, EventArgs e)
        {
            this.Text = "Puntuaje :";
            Random Obj3 = new Random();
            Bola.Location = new Point(0, Obj3.Next(this.Height));
            Arriba = true;
            Izquierda = true;
            timer1.Enabled = true;
            Puntuaje = 0;

        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (menuToolStripMenuItem.Enabled)
            {

                Form1 Obj2 = new Form1();
                Obj2.Show();
                this.Hide();
            }
        }

        private void VentanaJuego_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Top = e.Y;





        }

        private void VentanaJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Bola.Left > pictureBox2.Left)//estoes cuando la bola sobrepaso el limite ose cabas de perder
            {
                timer1.Enabled = false;
                MessageBox.Show("Puntuaje es :" + Puntuaje.ToString());
                Puntuaje = 0;
                Velocidad = 5;
                Contador = 0;
            }
            //if neceserario del rebote de la pelota
            if(Bola .Left+Bola.Width>=pictureBox2.Left&&//verifica que este dentro del rango de izquierda a derevha)
                Bola.Left+Bola.Width<=pictureBox2.Left+pictureBox2.Width&&//
                Bola.Top+Bola.Height>=pictureBox2.Top&&//verifica que no se pase de la paarte de arriba de la imagen 2
                Bola.Top+Bola.Height<=pictureBox2.Top+pictureBox2.Height)
                
            {

                Izquierda = false;
                Puntuaje += 1;
                this.Text = "Puntuacion  " + Puntuaje.ToString();
                Contador+=1;
                if(Contador>10)
                {

                    Velocidad += 1;
                    Contador = 0;
                
                }

            
            
            }

            #region Movimiento Bola
            if (Izquierda)
            {
                Bola.Left += Velocidad; //va para la derecha

            }
            else 
            {

                Bola.Left -= Velocidad;//va para la izquierda
            }

            if (Arriba)

            {
                Bola.Top += Velocidad;//va para abajo
            }

            else

            {

                Bola.Top -= Velocidad;//va para arriba
            }
            
            if(Bola.Top >=this.Height -150)//pegando en la pared de abajo
            {

                Arriba = false;

            
            }
            if(Bola.Top <=0)//pegando en la pared de arriba
            {

                Arriba = true;
            }

            if(Bola .Left <=0)//si pega en la pared de la izquierda
            {
                Izquierda = true;
            
            }
            
           


            #endregion
        }
    }
}
