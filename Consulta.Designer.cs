namespace HOTEL
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSencilla = new System.Windows.Forms.Label();
            this.lblDoble = new System.Windows.Forms.Label();
            this.labelVIP = new System.Windows.Forms.Label();
            this.lblVipDoble = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(476, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Habitaciones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.button1.Location = new System.Drawing.Point(1064, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 255);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblSencilla
            // 
            this.lblSencilla.BackColor = System.Drawing.Color.Lime;
            this.lblSencilla.Location = new System.Drawing.Point(592, 172);
            this.lblSencilla.Name = "lblSencilla";
            this.lblSencilla.Size = new System.Drawing.Size(77, 30);
            this.lblSencilla.TabIndex = 4;
            this.lblSencilla.Text = "Habitacion Sencilla";
            // 
            // lblDoble
            // 
            this.lblDoble.BackColor = System.Drawing.Color.Lime;
            this.lblDoble.Location = new System.Drawing.Point(519, 172);
            this.lblDoble.Name = "lblDoble";
            this.lblDoble.Size = new System.Drawing.Size(67, 30);
            this.lblDoble.TabIndex = 5;
            this.lblDoble.Text = "Habitacion Doble";
            // 
            // labelVIP
            // 
            this.labelVIP.BackColor = System.Drawing.Color.Lime;
            this.labelVIP.Location = new System.Drawing.Point(446, 172);
            this.labelVIP.Name = "labelVIP";
            this.labelVIP.Size = new System.Drawing.Size(67, 30);
            this.labelVIP.TabIndex = 6;
            this.labelVIP.Text = "Habitacion VIP";
            // 
            // lblVipDoble
            // 
            this.lblVipDoble.BackColor = System.Drawing.Color.Lime;
            this.lblVipDoble.Location = new System.Drawing.Point(592, 312);
            this.lblVipDoble.Name = "lblVipDoble";
            this.lblVipDoble.Size = new System.Drawing.Size(67, 30);
            this.lblVipDoble.TabIndex = 7;
            this.lblVipDoble.Text = "VIP Doble";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(730, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Disponible";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1151, 493);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVipDoble);
            this.Controls.Add(this.labelVIP);
            this.Controls.Add(this.lblDoble);
            this.Controls.Add(this.lblSencilla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label6;
        public Label lblSencilla;
        public Label lblDoble;
        public Label labelVIP;
        public Label lblVipDoble;
    }
}