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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        int i, dias, semanas, meses, cambio,tanque;

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            dias = 0;
            semanas = 0;
            meses = 0;
            cambio = 0;
            tanque = 0;
            progressBar1.Value = tanque;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tanque = 100;
            progressBar1.Value=(tanque);
            label6.Text = "Agua al 100%";
        }
        Boolean lluvia;
        private void button3_Click(object sender, EventArgs e)
        {
            lluvia = true;
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

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (txtInterval.Text == ""||txtHumedad.Text==""||txtph.Text=="")
            {
                MessageBox.Show("Faltan datos");
            }
            else if (tanque <= 0) { MessageBox.Show("tanque vacio"); }
            else if (Convert.ToInt32(txtph.Text) <= 5 ) { MessageBox.Show("pH bajo, la planta podria no brotar"); }
            else if (Convert.ToInt32(txtph.Text) >= 8) { MessageBox.Show("pH bajo, la planta podria no brotar"); }
            else {
                timer1.Start();
                timer1.Interval = Convert.ToInt32(txtInterval.Text);
                if (i == 0) {
                    pictureBoxCultivo.Image = imageList1.Images[0];
                }
                
            }
            
        }
        int aux;
        private void timer1_Tick(object sender, EventArgs e)     

        {
            label6.Text = "Agua al " + progressBar1.Value + "%";
            if (progressBar1.Value <= 0)
            {
                aux++;
                if (aux==1)
                {
                    MessageBox.Show("tanque Vacio!!!");
                    aux = 0;
                }
               
                timer1.Stop();
            }
            else
            {
                progressBar1.Value = tanque;
            }
            i++;
                label1.Text = i.ToString();
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
                int cond_sem = (7) * (semanas + 1);
                if (dias % 7 == 0 && dias >= cond_sem)
                {
                    semanas++;
                    label5.Text = "Semanas: " + semanas;
                }
                if (semanas % 2 != 0)
                {
                    pictureBoxVentilador.Visible = true;
                    tanque = tanque - 5;

                     
                 }
                else
                { 
                    pictureBoxVentilador.Visible = false; 
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
                    if (cambio == 7)
                    {
                        cambio = 0;
                        timer1.Enabled = false;
                        MessageBox.Show("a cosechar");
                    }
                    cambio++;
                }
          
            }
       

    }
}
