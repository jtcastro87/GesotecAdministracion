
namespace CapaPresentacion.PanelPrincipal
{
    partial class SolicitudesBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudesBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.solNom = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.solArea = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.solDepartamento = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.solIP = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.solEstatus = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.solPrioridad = new System.Windows.Forms.Label();
            this.buttonImg = new System.Windows.Forms.ImageList(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblCambiarEstatus = new System.Windows.Forms.Label();
            this.cbAsignar = new System.Windows.Forms.ComboBox();
            this.lblAsignarSeleccionado = new System.Windows.Forms.Label();
            this.gridSolicitudes = new System.Windows.Forms.DataGridView();
            this.lblSolicitudes = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.tbMuestraComentario = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.tbAgregaComentario = new System.Windows.Forms.TextBox();
            this.btnComentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSolicitante.Location = new System.Drawing.Point(21, 14);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 16);
            this.lblSolicitante.TabIndex = 0;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // solNom
            // 
            this.solNom.AccessibleName = "solNom";
            this.solNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solNom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solNom.Location = new System.Drawing.Point(21, 40);
            this.solNom.Name = "solNom";
            this.solNom.Size = new System.Drawing.Size(298, 24);
            this.solNom.TabIndex = 1;
            this.solNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArea.Location = new System.Drawing.Point(376, 14);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 16);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // solArea
            // 
            this.solArea.AccessibleName = "solArea";
            this.solArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solArea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solArea.Location = new System.Drawing.Point(379, 39);
            this.solArea.Name = "solArea";
            this.solArea.Size = new System.Drawing.Size(298, 24);
            this.solArea.TabIndex = 3;
            this.solArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDepartamento.Location = new System.Drawing.Point(725, 14);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 4;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // solDepartamento
            // 
            this.solDepartamento.AccessibleName = "solDepartamento";
            this.solDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solDepartamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solDepartamento.Location = new System.Drawing.Point(728, 40);
            this.solDepartamento.Name = "solDepartamento";
            this.solDepartamento.Size = new System.Drawing.Size(298, 24);
            this.solDepartamento.TabIndex = 5;
            this.solDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblExtension.Location = new System.Drawing.Point(17, 74);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(85, 16);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Estension IP:";
            // 
            // solIP
            // 
            this.solIP.AccessibleName = "solIP";
            this.solIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solIP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solIP.Location = new System.Drawing.Point(21, 98);
            this.solIP.Name = "solIP";
            this.solIP.Size = new System.Drawing.Size(298, 24);
            this.solIP.TabIndex = 7;
            this.solIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEstatus.Location = new System.Drawing.Point(376, 74);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(55, 16);
            this.lblEstatus.TabIndex = 8;
            this.lblEstatus.Text = "Estatus:";
            // 
            // solEstatus
            // 
            this.solEstatus.AccessibleName = "solEstatus";
            this.solEstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solEstatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solEstatus.Location = new System.Drawing.Point(379, 98);
            this.solEstatus.Name = "solEstatus";
            this.solEstatus.Size = new System.Drawing.Size(298, 24);
            this.solEstatus.TabIndex = 9;
            this.solEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrioridad.Location = new System.Drawing.Point(725, 74);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(66, 16);
            this.lblPrioridad.TabIndex = 10;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // solPrioridad
            // 
            this.solPrioridad.AccessibleName = "solPrioridad";
            this.solPrioridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.solPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solPrioridad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.solPrioridad.Location = new System.Drawing.Point(728, 98);
            this.solPrioridad.Name = "solPrioridad";
            this.solPrioridad.Size = new System.Drawing.Size(298, 24);
            this.solPrioridad.TabIndex = 11;
            this.solPrioridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonImg
            // 
            this.buttonImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImg.ImageStream")));
            this.buttonImg.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImg.Images.SetKeyName(0, "comment.png");
            this.buttonImg.Images.SetKeyName(1, "search-w.png");
            this.buttonImg.Images.SetKeyName(2, "updates-512.png");
            this.buttonImg.Images.SetKeyName(3, "plus-7-512.png");
            this.buttonImg.Images.SetKeyName(4, "telegram-w.png");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageKey = "search-w.png";
            this.btnBuscar.ImageList = this.buttonImg;
            this.btnBuscar.Location = new System.Drawing.Point(644, 437);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 30);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBuscar.Location = new System.Drawing.Point(469, 419);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 16);
            this.lblBuscar.TabIndex = 39;
            this.lblBuscar.Text = "Buscar ticket:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(470, 440);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(170, 24);
            this.tbSearch.TabIndex = 38;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(243, 439);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(170, 24);
            this.cbStatus.TabIndex = 36;
            // 
            // lblCambiarEstatus
            // 
            this.lblCambiarEstatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCambiarEstatus.AutoSize = true;
            this.lblCambiarEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarEstatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCambiarEstatus.Location = new System.Drawing.Point(243, 418);
            this.lblCambiarEstatus.Name = "lblCambiarEstatus";
            this.lblCambiarEstatus.Size = new System.Drawing.Size(116, 16);
            this.lblCambiarEstatus.TabIndex = 35;
            this.lblCambiarEstatus.Text = "Actualizar Estatus:";
            // 
            // cbAsignar
            // 
            this.cbAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAsignar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAsignar.FormattingEnabled = true;
            this.cbAsignar.Location = new System.Drawing.Point(18, 439);
            this.cbAsignar.Name = "cbAsignar";
            this.cbAsignar.Size = new System.Drawing.Size(170, 24);
            this.cbAsignar.TabIndex = 34;
            // 
            // lblAsignarSeleccionado
            // 
            this.lblAsignarSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAsignarSeleccionado.AutoSize = true;
            this.lblAsignarSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarSeleccionado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAsignarSeleccionado.Location = new System.Drawing.Point(18, 418);
            this.lblAsignarSeleccionado.Name = "lblAsignarSeleccionado";
            this.lblAsignarSeleccionado.Size = new System.Drawing.Size(68, 16);
            this.lblAsignarSeleccionado.TabIndex = 33;
            this.lblAsignarSeleccionado.Text = "Asignar a:";
            // 
            // gridSolicitudes
            // 
            this.gridSolicitudes.AllowUserToAddRows = false;
            this.gridSolicitudes.AllowUserToDeleteRows = false;
            this.gridSolicitudes.AllowUserToResizeColumns = false;
            this.gridSolicitudes.AllowUserToResizeRows = false;
            this.gridSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSolicitudes.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridSolicitudes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridSolicitudes.Location = new System.Drawing.Point(18, 180);
            this.gridSolicitudes.Name = "gridSolicitudes";
            this.gridSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSolicitudes.Size = new System.Drawing.Size(659, 225);
            this.gridSolicitudes.TabIndex = 32;
            this.gridSolicitudes.SelectionChanged += new System.EventHandler(this.gridSolicitudes_SelectionChanged);
            // 
            // lblSolicitudes
            // 
            this.lblSolicitudes.AutoSize = true;
            this.lblSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSolicitudes.Location = new System.Drawing.Point(15, 159);
            this.lblSolicitudes.Name = "lblSolicitudes";
            this.lblSolicitudes.Size = new System.Drawing.Size(77, 16);
            this.lblSolicitudes.TabIndex = 31;
            this.lblSolicitudes.Text = "Solicitudes:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ImageKey = "updates-512.png";
            this.btnActualizar.ImageList = this.buttonImg;
            this.btnActualizar.Location = new System.Drawing.Point(417, 436);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(34, 30);
            this.btnActualizar.TabIndex = 41;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ImageKey = "plus-7-512.png";
            this.btnAsignar.ImageList = this.buttonImg;
            this.btnAsignar.Location = new System.Drawing.Point(192, 436);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(34, 30);
            this.btnAsignar.TabIndex = 42;
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // tbMuestraComentario
            // 
            this.tbMuestraComentario.AcceptsReturn = true;
            this.tbMuestraComentario.AcceptsTab = true;
            this.tbMuestraComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMuestraComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMuestraComentario.Location = new System.Drawing.Point(728, 180);
            this.tbMuestraComentario.Multiline = true;
            this.tbMuestraComentario.Name = "tbMuestraComentario";
            this.tbMuestraComentario.ReadOnly = true;
            this.tbMuestraComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMuestraComentario.Size = new System.Drawing.Size(298, 181);
            this.tbMuestraComentario.TabIndex = 44;
            // 
            // lblComentarios
            // 
            this.lblComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblComentarios.Location = new System.Drawing.Point(725, 159);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 16);
            this.lblComentarios.TabIndex = 45;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // tbAgregaComentario
            // 
            this.tbAgregaComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAgregaComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAgregaComentario.Location = new System.Drawing.Point(728, 368);
            this.tbAgregaComentario.Multiline = true;
            this.tbAgregaComentario.Name = "tbAgregaComentario";
            this.tbAgregaComentario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbAgregaComentario.Size = new System.Drawing.Size(298, 61);
            this.tbAgregaComentario.TabIndex = 46;
            // 
            // btnComentar
            // 
            this.btnComentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComentar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComentar.ImageKey = "telegram-w.png";
            this.btnComentar.ImageList = this.buttonImg;
            this.btnComentar.Location = new System.Drawing.Point(728, 435);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(298, 30);
            this.btnComentar.TabIndex = 47;
            this.btnComentar.Text = "Agregar comentario";
            this.btnComentar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComentar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // SolicitudesBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(126)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1059, 509);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.tbAgregaComentario);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.tbMuestraComentario);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblCambiarEstatus);
            this.Controls.Add(this.cbAsignar);
            this.Controls.Add(this.lblAsignarSeleccionado);
            this.Controls.Add(this.gridSolicitudes);
            this.Controls.Add(this.lblSolicitudes);
            this.Controls.Add(this.solPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.solEstatus);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.solIP);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.solDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.solArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.solNom);
            this.Controls.Add(this.lblSolicitante);
            this.Name = "SolicitudesBase";
            this.Text = "BaseSolicitudes";
            ((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ImageList buttonImg;
        public System.Windows.Forms.Label solNom;
        public System.Windows.Forms.Label solArea;
        public System.Windows.Forms.Label solDepartamento;
        public System.Windows.Forms.Label solIP;
        public System.Windows.Forms.Label solEstatus;
        public System.Windows.Forms.Label solPrioridad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        public System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblCambiarEstatus;
        public System.Windows.Forms.ComboBox cbAsignar;
        private System.Windows.Forms.Label lblAsignarSeleccionado;
        public System.Windows.Forms.DataGridView gridSolicitudes;
        private System.Windows.Forms.Label lblSolicitudes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblComentarios;
        public System.Windows.Forms.TextBox tbMuestraComentario;
        public System.Windows.Forms.TextBox tbAgregaComentario;
        public System.Windows.Forms.Button btnComentar;
    }
}