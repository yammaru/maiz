
namespace Maiz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTemInterna = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbHumedaSuelo = new System.Windows.Forms.Label();
            this.lbPh = new System.Windows.Forms.Label();
            this.lbTecho = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtph = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.btnAcidez = new System.Windows.Forms.Button();
            this.btnAlcaloide = new System.Windows.Forms.Button();
            this.lbLitros = new System.Windows.Forms.Label();
            this.lbCosecha = new System.Windows.Forms.Label();
            this.pbLluvia = new System.Windows.Forms.PictureBox();
            this.pBLuzInterna = new System.Windows.Forms.PictureBox();
            this.pictureBoxVentilador = new System.Windows.Forms.PictureBox();
            this.pictureBoxSolLuna = new System.Windows.Forms.PictureBox();
            this.pictureBoxCultivo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLluvia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLuzInterna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentilador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolLuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCultivo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressBar1.Location = new System.Drawing.Point(173, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(152, 23);
            this.progressBar1.TabIndex = 51;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(97, 221);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 50;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(12, 221);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 49;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Dias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "maiz_1.jpg");
            this.imageList1.Images.SetKeyName(1, "maiz_2.jpg");
            this.imageList1.Images.SetKeyName(2, "maiz_3.jpg");
            this.imageList1.Images.SetKeyName(3, "maiz_4.jpg");
            this.imageList1.Images.SetKeyName(4, "maiz_5.jpg");
            this.imageList1.Images.SetKeyName(5, "maiz_6.jpg");
            this.imageList1.Images.SetKeyName(6, "maiz_cosecha tierna.jpg");
            this.imageList1.Images.SetKeyName(7, "maiz_maduro.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "luna.png");
            this.imageList2.Images.SetKeyName(1, "sol.png");
            // 
            // txtInterval
            // 
            this.txtInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInterval.Location = new System.Drawing.Point(69, 42);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 52;
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Intervalo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Plantar de nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 96);
            this.button2.TabIndex = 55;
            this.button2.Text = "Llenar Tanque";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tanque al ???%";
            // 
            // lbTemInterna
            // 
            this.lbTemInterna.AutoSize = true;
            this.lbTemInterna.BackColor = System.Drawing.Color.Red;
            this.lbTemInterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemInterna.Location = new System.Drawing.Point(261, 261);
            this.lbTemInterna.Name = "lbTemInterna";
            this.lbTemInterna.Size = new System.Drawing.Size(0, 20);
            this.lbTemInterna.TabIndex = 58;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(13, 325);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(242, 25);
            this.lbState.TabIndex = 59;
            this.lbState.Text = "Estado de la Tierra: ???";
            // 
            // lbHumedaSuelo
            // 
            this.lbHumedaSuelo.AutoSize = true;
            this.lbHumedaSuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumedaSuelo.Location = new System.Drawing.Point(10, 359);
            this.lbHumedaSuelo.Name = "lbHumedaSuelo";
            this.lbHumedaSuelo.Size = new System.Drawing.Size(245, 25);
            this.lbHumedaSuelo.TabIndex = 60;
            this.lbHumedaSuelo.Text = "Humedad del suelo: ???";
            // 
            // lbPh
            // 
            this.lbPh.AutoSize = true;
            this.lbPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPh.Location = new System.Drawing.Point(168, 257);
            this.lbPh.Name = "lbPh";
            this.lbPh.Size = new System.Drawing.Size(87, 25);
            this.lbPh.TabIndex = 61;
            this.lbPh.Text = "pH: ???";
            // 
            // lbTecho
            // 
            this.lbTecho.AutoSize = true;
            this.lbTecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTecho.Location = new System.Drawing.Point(420, 99);
            this.lbTecho.Name = "lbTecho";
            this.lbTecho.Size = new System.Drawing.Size(349, 25);
            this.lbTecho.TabIndex = 62;
            this.lbTecho.Text = "___________TECHO___________";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "Lluvia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "pH inicial:";
            // 
            // txtph
            // 
            this.txtph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtph.Location = new System.Drawing.Point(69, 69);
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(100, 20);
            this.txtph.TabIndex = 64;
            this.txtph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtph_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Humedad:";
            // 
            // txtHumedad
            // 
            this.txtHumedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHumedad.Location = new System.Drawing.Point(69, 96);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(63, 20);
            this.txtHumedad.TabIndex = 66;
            this.txtHumedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHumedad_KeyPress);
            // 
            // btnAcidez
            // 
            this.btnAcidez.Location = new System.Drawing.Point(12, 261);
            this.btnAcidez.Name = "btnAcidez";
            this.btnAcidez.Size = new System.Drawing.Size(75, 23);
            this.btnAcidez.TabIndex = 72;
            this.btnAcidez.Text = "+Acidez";
            this.btnAcidez.UseVisualStyleBackColor = true;
            this.btnAcidez.Click += new System.EventHandler(this.btnAcidez_Click);
            // 
            // btnAlcaloide
            // 
            this.btnAlcaloide.Location = new System.Drawing.Point(89, 261);
            this.btnAlcaloide.Name = "btnAlcaloide";
            this.btnAlcaloide.Size = new System.Drawing.Size(75, 23);
            this.btnAlcaloide.TabIndex = 73;
            this.btnAlcaloide.Text = "+Alcalinidad";
            this.btnAlcaloide.UseVisualStyleBackColor = true;
            this.btnAlcaloide.Click += new System.EventHandler(this.btnAlcaloide_Click);
            // 
            // lbLitros
            // 
            this.lbLitros.AutoSize = true;
            this.lbLitros.Location = new System.Drawing.Point(330, 77);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(45, 13);
            this.lbLitros.TabIndex = 74;
            this.lbLitros.Text = "??? Lts.";
            // 
            // lbCosecha
            // 
            this.lbCosecha.AutoSize = true;
            this.lbCosecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCosecha.Location = new System.Drawing.Point(37, 291);
            this.lbCosecha.Name = "lbCosecha";
            this.lbCosecha.Size = new System.Drawing.Size(218, 25);
            this.lbCosecha.TabIndex = 76;
            this.lbCosecha.Text = "Estado Cosecha: ???";
            // 
            // pbLluvia
            // 
            this.pbLluvia.Image = global::Maiz.Properties.Resources.rain_png;
            this.pbLluvia.Location = new System.Drawing.Point(586, 20);
            this.pbLluvia.Name = "pbLluvia";
            this.pbLluvia.Size = new System.Drawing.Size(130, 76);
            this.pbLluvia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLluvia.TabIndex = 77;
            this.pbLluvia.TabStop = false;
            // 
            // pBLuzInterna
            // 
            this.pBLuzInterna.Image = global::Maiz.Properties.Resources.Sol;
            this.pBLuzInterna.Location = new System.Drawing.Point(438, 128);
            this.pBLuzInterna.Name = "pBLuzInterna";
            this.pBLuzInterna.Size = new System.Drawing.Size(57, 45);
            this.pBLuzInterna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBLuzInterna.TabIndex = 75;
            this.pBLuzInterna.TabStop = false;
            // 
            // pictureBoxVentilador
            // 
            this.pictureBoxVentilador.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVentilador.Image = global::Maiz.Properties.Resources.Aspersor;
            this.pictureBoxVentilador.Location = new System.Drawing.Point(649, 332);
            this.pictureBoxVentilador.Name = "pictureBoxVentilador";
            this.pictureBoxVentilador.Size = new System.Drawing.Size(46, 38);
            this.pictureBoxVentilador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVentilador.TabIndex = 43;
            this.pictureBoxVentilador.TabStop = false;
            // 
            // pictureBoxSolLuna
            // 
            this.pictureBoxSolLuna.Image = global::Maiz.Properties.Resources.Sol;
            this.pictureBoxSolLuna.Location = new System.Drawing.Point(411, 9);
            this.pictureBoxSolLuna.Name = "pictureBoxSolLuna";
            this.pictureBoxSolLuna.Size = new System.Drawing.Size(84, 76);
            this.pictureBoxSolLuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSolLuna.TabIndex = 41;
            this.pictureBoxSolLuna.TabStop = false;
            // 
            // pictureBoxCultivo
            // 
            this.pictureBoxCultivo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCultivo.Image = global::Maiz.Properties.Resources.maiz_1;
            this.pictureBoxCultivo.Location = new System.Drawing.Point(567, 120);
            this.pictureBoxCultivo.Name = "pictureBoxCultivo";
            this.pictureBoxCultivo.Size = new System.Drawing.Size(51, 250);
            this.pictureBoxCultivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCultivo.TabIndex = 42;
            this.pictureBoxCultivo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 78;
            this.label8.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbLluvia);
            this.Controls.Add(this.lbCosecha);
            this.Controls.Add(this.pBLuzInterna);
            this.Controls.Add(this.lbLitros);
            this.Controls.Add(this.btnAlcaloide);
            this.Controls.Add(this.btnAcidez);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtHumedad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtph);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbTecho);
            this.Controls.Add(this.lbPh);
            this.Controls.Add(this.lbHumedaSuelo);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbTemInterna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxVentilador);
            this.Controls.Add(this.pictureBoxSolLuna);
            this.Controls.Add(this.pictureBoxCultivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLluvia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLuzInterna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentilador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolLuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCultivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxVentilador;
        private System.Windows.Forms.PictureBox pictureBoxSolLuna;
        private System.Windows.Forms.PictureBox pictureBoxCultivo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTemInterna;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbHumedaSuelo;
        private System.Windows.Forms.Label lbPh;
        private System.Windows.Forms.Label lbTecho;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtph;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.Button btnAcidez;
        private System.Windows.Forms.Button btnAlcaloide;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.PictureBox pBLuzInterna;
        private System.Windows.Forms.Label lbCosecha;
        private System.Windows.Forms.PictureBox pbLluvia;
        private System.Windows.Forms.Label label8;
    }
}

