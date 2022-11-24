
namespace CapaPresentacion.PanelPrincipal
{
    partial class SolicitudesHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesHD));
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cbFiltrado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.ImageList(this.components);
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnComentar
            // 
            this.btnComentar.FlatAppearance.BorderSize = 0;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFiltrar.Location = new System.Drawing.Point(201, 153);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(91, 16);
            this.lblFiltrar.TabIndex = 48;
            this.lblFiltrar.Text = "Mostrar por:";
            // 
            // cbFiltrado
            // 
            this.cbFiltrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrado.FormattingEnabled = true;
            this.cbFiltrado.Location = new System.Drawing.Point(474, 151);
            this.cbFiltrado.Name = "cbFiltrado";
            this.cbFiltrado.Size = new System.Drawing.Size(170, 24);
            this.cbFiltrado.TabIndex = 49;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ImageKey = "filled-filter-512.png";
            this.btnFiltrar.ImageList = this.filter;
            this.btnFiltrar.Location = new System.Drawing.Point(648, 148);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(34, 30);
            this.btnFiltrar.TabIndex = 50;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // filter
            // 
            this.filter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("filter.ImageStream")));
            this.filter.TransparentColor = System.Drawing.Color.Transparent;
            this.filter.Images.SetKeyName(0, "filled-filter-512.png");
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbUsuarios.Location = new System.Drawing.Point(300, 152);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(88, 20);
            this.rbUsuarios.TabIndex = 51;
            this.rbUsuarios.TabStop = true;
            this.rbUsuarios.Text = "Usuarios";
            this.rbUsuarios.UseVisualStyleBackColor = true;
            this.rbUsuarios.CheckedChanged += new System.EventHandler(this.rbUsuarios_CheckedChanged);
            // 
            // rbStatus
            // 
            this.rbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStatus.AutoSize = true;
            this.rbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbStatus.Location = new System.Drawing.Point(394, 152);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(77, 20);
            this.rbStatus.TabIndex = 52;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "Estatus";
            this.rbStatus.UseVisualStyleBackColor = true;
            this.rbStatus.CheckedChanged += new System.EventHandler(this.rbStatus_CheckedChanged);
            // 
            // SolicitudesHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1059, 509);
            this.Controls.Add(this.rbStatus);
            this.Controls.Add(this.rbUsuarios);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbFiltrado);
            this.Controls.Add(this.lblFiltrar);
            this.DoubleBuffered = true;
            this.Name = "SolicitudesHD";
            this.Text = "SolicitudesHD";
            this.Load += new System.EventHandler(this.SolicitudesHD_Load);
            this.Controls.SetChildIndex(this.lblFiltrar, 0);
            this.Controls.SetChildIndex(this.solNom, 0);
            this.Controls.SetChildIndex(this.solArea, 0);
            this.Controls.SetChildIndex(this.solDepartamento, 0);
            this.Controls.SetChildIndex(this.solIP, 0);
            this.Controls.SetChildIndex(this.solEstatus, 0);
            this.Controls.SetChildIndex(this.solPrioridad, 0);
            this.Controls.SetChildIndex(this.cbAsignar, 0);
            this.Controls.SetChildIndex(this.cbStatus, 0);
            this.Controls.SetChildIndex(this.tbSearch, 0);
            this.Controls.SetChildIndex(this.tbMuestraComentario, 0);
            this.Controls.SetChildIndex(this.tbAgregaComentario, 0);
            this.Controls.SetChildIndex(this.btnComentar, 0);
            this.Controls.SetChildIndex(this.cbFiltrado, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.rbUsuarios, 0);
            this.Controls.SetChildIndex(this.rbStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ImageList filter;
        private System.Windows.Forms.RadioButton rbUsuarios;
        private System.Windows.Forms.RadioButton rbStatus;
    }
}