
namespace CapaPresentacion.PanelPrincipal
{
    partial class TechnicalDashboar
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
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(284, 151);
            // 
            // logoHome
            // 
            this.logoHome.Location = new System.Drawing.Point(336, 220);
            // 
            // lblProcess
            // 
            this.lblProcess.Size = new System.Drawing.Size(109, 24);
            this.lblProcess.Text = "En Proceso";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.Text = "En Espera";
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.Size = new System.Drawing.Size(139, 24);
            this.lblTotalTicket.Text = "Asignados a Mi";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TechnicalDashboar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1059, 581);
            this.Name = "TechnicalDashboar";
            this.Text = "TechnicalDashboar";
            this.Load += new System.EventHandler(this.TechnicalDashboar_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.TechnicalDashboar_GiveFeedback);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}