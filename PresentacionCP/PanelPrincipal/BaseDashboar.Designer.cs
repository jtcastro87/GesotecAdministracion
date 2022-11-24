
namespace CapaPresentacion.PanelPrincipal
{
    partial class BaseDashboar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDashboar));
            this.lblTitel = new System.Windows.Forms.Label();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.imgListDash = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotalProceso = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTotalEspera = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotalFinalizados = new System.Windows.Forms.Label();
            this.lblFinalizados = new System.Windows.Forms.Label();
            this.logoHome = new System.Windows.Forms.PictureBox();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitel.Location = new System.Drawing.Point(323, 132);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(350, 31);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Gestión de Soporte Técnico";
            // 
            // panelTicket
            // 
            this.panelTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTicket.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTicket.Controls.Add(this.pictureBox1);
            this.panelTicket.Controls.Add(this.lblCantidad);
            this.panelTicket.Controls.Add(this.lblTotalTicket);
            this.panelTicket.Location = new System.Drawing.Point(10, 10);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(200, 84);
            this.panelTicket.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(4, 3);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(37, 39);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "0";
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTicket.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTicket.Location = new System.Drawing.Point(4, 56);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(95, 24);
            this.lblTotalTicket.TabIndex = 3;
            this.lblTotalTicket.Text = "Si Asignar";
            // 
            // imgListDash
            // 
            this.imgListDash.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDash.ImageStream")));
            this.imgListDash.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDash.Images.SetKeyName(0, "process-w.png");
            this.imgListDash.Images.SetKeyName(1, "user2-w.png");
            this.imgListDash.Images.SetKeyName(2, "email-w.png");
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTotalProceso);
            this.panel1.Controls.Add(this.lblProcess);
            this.panel1.Location = new System.Drawing.Point(218, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 84);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.process_w;
            this.pictureBox2.Location = new System.Drawing.Point(162, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotalProceso
            // 
            this.lblTotalProceso.AutoSize = true;
            this.lblTotalProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProceso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalProceso.Location = new System.Drawing.Point(5, 3);
            this.lblTotalProceso.Name = "lblTotalProceso";
            this.lblTotalProceso.Size = new System.Drawing.Size(37, 39);
            this.lblTotalProceso.TabIndex = 4;
            this.lblTotalProceso.Text = "0";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcess.Location = new System.Drawing.Point(4, 56);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(108, 24);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "En proceso";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblTotalEspera);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(426, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 84);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.stop_w;
            this.pictureBox3.Location = new System.Drawing.Point(155, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblTotalEspera
            // 
            this.lblTotalEspera.AutoSize = true;
            this.lblTotalEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEspera.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalEspera.Location = new System.Drawing.Point(4, 3);
            this.lblTotalEspera.Name = "lblTotalEspera";
            this.lblTotalEspera.Size = new System.Drawing.Size(37, 39);
            this.lblTotalEspera.TabIndex = 4;
            this.lblTotalEspera.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "En espera";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblTotalFinalizados);
            this.panel3.Controls.Add(this.lblFinalizados);
            this.panel3.Location = new System.Drawing.Point(634, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 84);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(155, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotalFinalizados
            // 
            this.lblTotalFinalizados.AutoSize = true;
            this.lblTotalFinalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFinalizados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalFinalizados.Location = new System.Drawing.Point(4, 4);
            this.lblTotalFinalizados.Name = "lblTotalFinalizados";
            this.lblTotalFinalizados.Size = new System.Drawing.Size(37, 39);
            this.lblTotalFinalizados.TabIndex = 4;
            this.lblTotalFinalizados.Text = "0";
            // 
            // lblFinalizados
            // 
            this.lblFinalizados.AutoSize = true;
            this.lblFinalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFinalizados.Location = new System.Drawing.Point(4, 56);
            this.lblFinalizados.Name = "lblFinalizados";
            this.lblFinalizados.Size = new System.Drawing.Size(105, 24);
            this.lblFinalizados.TabIndex = 3;
            this.lblFinalizados.Text = "Finalizados";
            // 
            // logoHome
            // 
            this.logoHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoHome.Image = ((System.Drawing.Image)(resources.GetObject("logoHome.Image")));
            this.logoHome.Location = new System.Drawing.Point(306, 166);
            this.logoHome.Name = "logoHome";
            this.logoHome.Size = new System.Drawing.Size(409, 313);
            this.logoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoHome.TabIndex = 1;
            this.logoHome.TabStop = false;
            // 
            // BaseDashboar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1059, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.logoHome);
            this.Controls.Add(this.lblTitel);
            this.Name = "BaseDashboar";
            this.Text = "BaseDashboar";
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitel;
        public System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.ImageList imgListDash;
        public System.Windows.Forms.Panel panelTicket;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblProcess;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lblFinalizados;
        public System.Windows.Forms.Label lblTotalProceso;
        public System.Windows.Forms.Label lblTotalEspera;
        public System.Windows.Forms.Label lblTotalFinalizados;
        public System.Windows.Forms.Label lblCantidad;
        public System.Windows.Forms.Label lblTotalTicket;
    }
}