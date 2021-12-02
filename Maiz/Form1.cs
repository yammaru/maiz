using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = false;
            pbLluvia.Visible = false;
            lbTecho.Visible = false;
            pBLuzInterna.Visible = false;
            pictureBoxVentilador.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        int i, dias, semanas, meses, cambio,ph,humedad,tanque;
     

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            dias = 0;
            semanas = 0;
            meses = 0;
            cambio = 0;
            tanque = 0;
            progressBar1.Value =tanque;
            ph = Convert.ToInt32(txtph.Text);
            humedad = Convert.ToInt32(txtHumedad.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tanque = 100;
          
            progressBar1.Value=tanque;
            label6.Text = "Tanque al 100%";
            lbLitros.Text = "100 Lts.";
        }
        Boolean lluvia,TECHO,LUZINTERNA;int ll=0;

        private void btnAlcaloide_Click(object sender, EventArgs e)
        {
            ph++; lbPh.Text = "pH: " + ph;
        }

        private void btnAcidez_Click(object sender, EventArgs e)
        {
            ph--; lbPh.Text = "pH: " + ph;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ll==0)
            {
                lluvia = true;
                pbLluvia.Visible = true;
                lbTecho.Visible = true;
                pBLuzInterna.Visible = true;
                ll++;
            }
            else {
                ll = 0;
                lluvia = false;
                pbLluvia.Visible = false;
                lbTecho.Visible = false;
                pBLuzInterna.Visible = false;
            }
           
        }

        private void txtph_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            e.Handled = validacion_numerico(letra);
        }
       
        Boolean validacion_numerico(char e)
        {
            if ((e >= 32 && e <= 47) || (e >= 58 && e <= 255))
            {
                if (e != 127)
                {
                    MessageBox.Show("no es un numero!!!");
                   
                    return true;
                }
             
            }
          return false; 
        }

        private void txtHumedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            e.Handled=validacion_numerico(letra);
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            e.Handled = validacion_numerico(letra);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        void validacion_empesar()
        {
            timer1.Start();
            timer1.Interval = Convert.ToInt32(txtInterval.Text);
            ph = Convert.ToInt32(txtph.Text);
            humedad = Convert.ToInt32(txtHumedad.Text);
            progressBar1.Value = tanque;
            if (i == 0)
            {
                pictureBoxCultivo.Image = imageList1.Images[0];
                lbState.Text = "Estado de la Tierra: " + "Apta";
                lbCosecha.Text = "Estado Cosecha: " + "aun no";
            }
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (txtInterval.Text == "" || txtHumedad.Text == "" || txtph.Text == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else if (tanque <= 0)
            {
                MessageBox.Show("tanque vacio"); if (i != 0)
                { validacion_empesar(); }
            }
            else if (Convert.ToInt32(txtph.Text) <= 5) { MessageBox.Show("pH bajo, la planta podria no brotar"); }
            else if (Convert.ToInt32(txtph.Text) >= 8) { MessageBox.Show("pH alto, la planta podria no brotar"); }
            else
            {
                validacion_empesar();
            }
                
            
           
        }

        int aux,aux2;
        private void timer1_Tick(object sender, EventArgs e)
        {


            i++;
            label1.Text = i.ToString();
            if (ph <= 5) { lbTemInterna.Text = "pH bajo, la planta podria morir o no brotar"; } 
            else if (ph >7) {  lbTemInterna.Text = "pH alto, la planta podria morir no brotar"; }
            else
            {
                lbTemInterna.Text = ""; }
            lbPh.Text = "pH: " + ph;
            lbHumedaSuelo.Text = "Humedad del suelo: " + humedad;
            label6.Text = "Tanque al " + progressBar1.Value + "%";
            lbLitros.Text = progressBar1.Value + " Lts.";
            if (aux == 0|| progressBar1.Value != 0)
                {
            if (progressBar1.Value <= 0)
                {
                    timer1.Stop();
                    aux++;aux2++;
                    if (aux==1)
                    {
                     DialogResult result = MessageBox.Show("Desea seguir la simulacion?", "Tanque Vacio!!!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    { 
                        timer1.Start();
                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("el Simulador se a Destenido");
                    }
                        aux2=0;
                    }
                
                   

            }
            else
            {
                progressBar1.Value = tanque;
            }
            
            }
            if (i % 1 == 0)
            {
                if (label3.Text == "dia")
                {
                    label3.Text = "noche";
                    pictureBoxSolLuna.Image = imageList2.Images[0];
                    dias++;
                    label4.Text = "Dia: " + dias;
                }
                else
                {
                    pictureBoxSolLuna.Image = imageList2.Images[1];
                    label3.Text = "dia";
                }

            }
            if (tanque <=0)
            {
                if (dias % 2 == 0)
                {
                    ph++;
                }
                if (ph>=8) 
                {
                    humedad--;
                    lbState.Text = "Estado de la Tierra: " + "No Apta, secandoce";
                    lbHumedaSuelo.Text = "Humedad del suelo: " + humedad;
                }
            }

            if (humedad>=50)
            {
                timer1.Stop();
                MessageBox.Show("el Simulador se a Destenido, la panta se ahogo");
            }
            else if (humedad<=0)
            {
                timer1.Stop();
                MessageBox.Show("el Simulador se a Destenido, la panta se seco");
            }
            if (lluvia == true)
            {
                humedad++;
                if (dias % 2 == 0)
                {
                    ph--;
                }
                if (ph <= 5)
                {
                    humedad++;
                    lbState.Text = "Estado de la Tierra: " + "No Apta, Acidandoce";
                    lbHumedaSuelo.Text = "Humedad del suelo: " + humedad +"%";
                }
                if (dias % 10 == 0)
                {
                    pictureBoxVentilador.Visible = true;
                    tanque--;
                }
            }
            else
            {
                pictureBoxVentilador.Visible = false;
                if (dias % 4 == 0)
                {
                    pictureBoxVentilador.Visible = true;
                    //tanque--;
                    tanque = tanque - 4;
                }
                else
                {
                    pictureBoxVentilador.Visible = false;
                }
            }

            int cond_sem = (7) * (semanas + 1);
            if (dias % 7 == 0 && dias >= cond_sem)
            {
                semanas++;
                label5.Text = "Semanas: " + semanas;
            }
              
          

            int cond_mes = (4) * (meses + 1);
                if (semanas % 4 == 0 && semanas >= cond_mes)
                {
                    meses++;
                    label7.Text = "Mes: " + meses;
                }
                int cond_cam = 2 * (cambio + 1);
                if (semanas % 2 == 0 && semanas >= cond_cam)
                {

                    pictureBoxCultivo.Image = imageList1.Images[cambio];
                if (cambio == 5)
                {
                    lbCosecha.Text = "Estado Cosecha: " + "Joven";
                }
                if (cambio==6)
                {
                    lbCosecha.Text = "Estado Cosecha: " + "Tierna";
                }
                    if (cambio == 7)
                    {
                        cambio = 0;
                        timer1.Enabled = false;
                    lbCosecha.Text = "Estado Cosecha: " + "Madura";
                    MessageBox.Show("a cosechar");
                    }
                    cambio++;
                }
          
            }
       

    }
}
