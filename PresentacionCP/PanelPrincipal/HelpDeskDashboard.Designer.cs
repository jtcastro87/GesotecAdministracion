
namespace CapaPresentacion.PanelPrincipal
{
    partial class HelpDeskDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTotalOnlieUser = new System.Windows.Forms.Label();
            this.lblUsuariosOnline = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(335, 134);
            // 
            // logoHome
            // 
            this.logoHome.Location = new System.Drawing.Point(320, 168);
            // 
            // panelTicket
            // 
            this.panelTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(153, 7);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Location = new System.Drawing.Point(219, 11);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(161, 7);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(427, 11);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(154, 7);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Location = new System.Drawing.Point(636, 11);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.check_w;
            this.pictureBox4.Location = new System.Drawing.Point(152, 7);
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.Size = new System.Drawing.Size(108, 24);
            this.lblTotalTicket.Text = "Por Asignar";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.lblTotalOnlieUser);
            this.panel4.Controls.Add(this.lblUsuariosOnline);
            this.panel4.Location = new System.Drawing.Point(845, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 84);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CapaPresentacion.Properties.Resources.user2_w;
            this.pictureBox5.Location = new System.Drawing.Point(152, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // lblTotalOnlieUser
            // 
            this.lblTotalOnlieUser.AutoSize = true;
            this.lblTotalOnlieUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOnlieUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalOnlieUser.Location = new System.Drawing.Point(4, 4);
            this.lblTotalOnlieUser.Name = "lblTotalOnlieUser";
            this.lblTotalOnlieUser.Size = new System.Drawing.Size(37, 39);
            this.lblTotalOnlieUser.TabIndex = 4;
            this.lblTotalOnlieUser.Text = "0";
            // 
            // lblUsuariosOnline
            // 
            this.lblUsuariosOnline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuariosOnline.AutoSize = true;
            this.lblUsuariosOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosOnline.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuariosOnline.Location = new System.Drawing.Point(4, 56);
            this.lblUsuariosOnline.Name = "lblUsuariosOnline";
            this.lblUsuariosOnline.Size = new System.Drawing.Size(155, 24);
            this.lblUsuariosOnline.TabIndex = 3;
            this.lblUsuariosOnline.Text = "Usuarios en linea";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // HelpDeskDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 545);
            this.Controls.Add(this.panel4);
            this.Name = "HelpDeskDashboard";
            this.Text = "HelpDeskDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelpDeskDashboard_FormClosing);
            this.Load += new System.EventHandler(this.HelpDeskDashboard_Load);
            this.Controls.SetChildIndex(this.lblTitel, 0);
            this.Controls.SetChildIndex(this.logoHome, 0);
            this.Controls.SetChildIndex(this.panelTicket, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblUsuariosOnline;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTotalOnlieUser;
    }
}