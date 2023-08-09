namespace ExamenProgra5Csharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.G = new System.Windows.Forms.Panel();
            this.labelJug1 = new System.Windows.Forms.Label();
            this.labelJug2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Jugador1 = new System.Windows.Forms.TextBox();
            this.Jugador2 = new System.Windows.Forms.TextBox();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jugar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelJuego.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(331, 12);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(484, 484);
            this.G.TabIndex = 0;
            // 
            // labelJug1
            // 
            this.labelJug1.AutoSize = true;
            this.labelJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJug1.ForeColor = System.Drawing.Color.Blue;
            this.labelJug1.Location = new System.Drawing.Point(127, 122);
            this.labelJug1.Name = "labelJug1";
            this.labelJug1.Size = new System.Drawing.Size(36, 37);
            this.labelJug1.TabIndex = 3;
            this.labelJug1.Text = "0";
            // 
            // labelJug2
            // 
            this.labelJug2.AutoSize = true;
            this.labelJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJug2.ForeColor = System.Drawing.Color.Red;
            this.labelJug2.Location = new System.Drawing.Point(939, 435);
            this.labelJug2.Name = "labelJug2";
            this.labelJug2.Size = new System.Drawing.Size(36, 37);
            this.labelJug2.TabIndex = 4;
            this.labelJug2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(846, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jugador 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jugador 1";
            // 
            // Jugador1
            // 
            this.Jugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Jugador1.Location = new System.Drawing.Point(169, 36);
            this.Jugador1.Name = "Jugador1";
            this.Jugador1.Size = new System.Drawing.Size(113, 35);
            this.Jugador1.TabIndex = 7;
            this.Jugador1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jugador1_KeyPress);
            // 
            // Jugador2
            // 
            this.Jugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Jugador2.Location = new System.Drawing.Point(995, 349);
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.Size = new System.Drawing.Size(113, 35);
            this.Jugador2.TabIndex = 8;
            this.Jugador2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Jugador1_KeyPress);
            // 
            // PanelJuego
            // 
            this.PanelJuego.BackColor = System.Drawing.Color.Gold;
            this.PanelJuego.Controls.Add(this.panel1);
            this.PanelJuego.Controls.Add(this.label4);
            this.PanelJuego.Controls.Add(this.labelw);
            this.PanelJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelJuego.Location = new System.Drawing.Point(0, 0);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(1116, 517);
            this.PanelJuego.TabIndex = 0;
            this.PanelJuego.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Jugar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 517);
            this.panel1.TabIndex = 2;
            // 
            // Jugar
            // 
            this.Jugar.AutoSize = true;
            this.Jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar.ForeColor = System.Drawing.Color.GreenYellow;
            this.Jugar.Location = new System.Drawing.Point(481, 213);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(124, 46);
            this.Jugar.TabIndex = 0;
            this.Jugar.Text = "Jugar";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jugar de nuevo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelw
            // 
            this.labelw.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.labelw.ForeColor = System.Drawing.Color.White;
            this.labelw.Location = new System.Drawing.Point(252, 149);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(607, 111);
            this.labelw.TabIndex = 0;
            this.labelw.Text = "Ganaste";
            this.labelw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(851, 422);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 517);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.Jugador2);
            this.Controls.Add(this.Jugador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJug2);
            this.Controls.Add(this.labelJug1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damas chinas";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Help_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelJuego.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelJug1;
        private System.Windows.Forms.Label labelJug2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Jugador1;
        private System.Windows.Forms.TextBox Jugador2;
        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jugar;
    }
}

