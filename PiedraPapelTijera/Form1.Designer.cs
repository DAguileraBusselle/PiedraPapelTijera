
namespace PiedraPapelTijera
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReintentar = new System.Windows.Forms.Button();
            this.pboxMaquina = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnTijera = new PiedraPapelTijera.RoundButton();
            this.btnPapel = new PiedraPapelTijera.RoundButton();
            this.btnPiedra = new PiedraPapelTijera.RoundButton();
            this.lblPuntosMaq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntosJugador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReintentar
            // 
            this.btnReintentar.Location = new System.Drawing.Point(165, 381);
            this.btnReintentar.Name = "btnReintentar";
            this.btnReintentar.Size = new System.Drawing.Size(217, 34);
            this.btnReintentar.TabIndex = 1;
            this.btnReintentar.Text = "REINTENTAR";
            this.btnReintentar.UseVisualStyleBackColor = true;
            this.btnReintentar.Click += new System.EventHandler(this.btnReintentar_Click);
            // 
            // pboxMaquina
            // 
            this.pboxMaquina.Location = new System.Drawing.Point(165, 26);
            this.pboxMaquina.Name = "pboxMaquina";
            this.pboxMaquina.Size = new System.Drawing.Size(217, 199);
            this.pboxMaquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMaquina.TabIndex = 2;
            this.pboxMaquina.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(93, 263);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(358, 73);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTijera
            // 
            this.btnTijera.Image = global::PiedraPapelTijera.Properties.Resources.tijera;
            this.btnTijera.Location = new System.Drawing.Point(399, 395);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(138, 138);
            this.btnTijera.TabIndex = 4;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Image = global::PiedraPapelTijera.Properties.Resources.papel;
            this.btnPapel.Location = new System.Drawing.Point(200, 469);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(138, 138);
            this.btnPapel.TabIndex = 3;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPiedra
            // 
            this.btnPiedra.Image = global::PiedraPapelTijera.Properties.Resources.piedra;
            this.btnPiedra.Location = new System.Drawing.Point(12, 395);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(138, 138);
            this.btnPiedra.TabIndex = 0;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // lblPuntosMaq
            // 
            this.lblPuntosMaq.AutoSize = true;
            this.lblPuntosMaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosMaq.Location = new System.Drawing.Point(63, 95);
            this.lblPuntosMaq.Name = "lblPuntosMaq";
            this.lblPuntosMaq.Size = new System.Drawing.Size(30, 31);
            this.lblPuntosMaq.TabIndex = 6;
            this.lblPuntosMaq.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "PUNTOS MAQUINA:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(401, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 59);
            this.label2.TabIndex = 8;
            this.label2.Text = "PUNTOS JUGADOR:";
            // 
            // lblPuntosJugador
            // 
            this.lblPuntosJugador.AutoSize = true;
            this.lblPuntosJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosJugador.Location = new System.Drawing.Point(449, 95);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(30, 31);
            this.lblPuntosJugador.TabIndex = 9;
            this.lblPuntosJugador.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 631);
            this.Controls.Add(this.lblPuntosJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntosMaq);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.pboxMaquina);
            this.Controls.Add(this.btnReintentar);
            this.Controls.Add(this.btnPiedra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaquina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton btnPiedra;
        private System.Windows.Forms.Button btnReintentar;
        private System.Windows.Forms.PictureBox pboxMaquina;
        private RoundButton btnPapel;
        private RoundButton btnTijera;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPuntosMaq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntosJugador;
    }
}

