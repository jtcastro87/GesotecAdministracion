using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CapaNegocio;
using Common.Cache;

namespace CapaPresentacion.PanelPrincipal
{
    public partial class SolicitudesHD : SolicitudesBase
    {
        public SolicitudesHD()
        {
            InitializeComponent();
        }

        // Variables
        RequestsDA requestsDA;
        string radioSeleccionado = string.Empty;

        // Metodo que se ejecuta al cargar la ventana
        private void SolicitudesHD_Load(object sender, EventArgs e)
        {
            FillGridRequests();
            DisableColumnGrid();
            FillComboUsuarios();
            FillComboStatus();
        }

        // Muestra los datos del solicitante cuando es seleccionado en el grid
        public override void gridSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            string ticket = this.gridSolicitudes.CurrentRow.Cells[0].Value.ToString();
            GetNotesTicket(ticket);
            this.solNom.Text = this.gridSolicitudes.CurrentRow.Cells[1].Value.ToString();
            this.solArea.Text = this.gridSolicitudes.CurrentRow.Cells[2].Value.ToString();
            this.solDepartamento.Text = this.gridSolicitudes.CurrentRow.Cells[3].Value.ToString();
            this.solIP.Text = this.gridSolicitudes.CurrentRow.Cells[4].Value.ToString();           
            this.solPrioridad.Text = this.gridSolicitudes.CurrentRow.Cells[9].Value.ToString();
            this.solEstatus.Text = this.gridSolicitudes.CurrentRow.Cells[10].Value.ToString(); 
        }

        // Oculta colunmas en el Grid solicitudes
        public override void DisableColumnGrid()
        {
            this.gridSolicitudes.Columns[1].Visible = false;
            this.gridSolicitudes.Columns[2].Visible = false;
            this.gridSolicitudes.Columns[3].Visible = false;
            this.gridSolicitudes.Columns[4].Visible = false;
            this.gridSolicitudes.Columns[9].Visible = false;
            this.gridSolicitudes.Columns[10].Visible = false;
            this.gridSolicitudes.Columns[11].Visible = false;
            // Modifico los anchos de estas columnas
            this.gridSolicitudes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gridSolicitudes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gridSolicitudes.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.gridSolicitudes.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.gridSolicitudes.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        // Obtiene todas las solicitudes
        public override void FillGridRequests()
        {
            try
            {
                requestsDA = new RequestsDA();
                // Oculto estas columnas, los datos se muestran en los label
                this.gridSolicitudes.DataSource = requestsDA.FillGridRequests();
                DisableColumnGrid();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el grid de la solicitudes: {ex.Message}",
                    "Error",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        // Obtiene todos los usuarios
        public override void FillComboUsuarios()
        {
            try
            {
                requestsDA = new RequestsDA();
                this.cbAsignar.Items.Add("- Seleccionar -");
                foreach (var item in requestsDA.FillComboUsuarios())
                {
                    this.cbAsignar.Items.Add(item);
                }
                this.cbAsignar.SelectedIndex = 0;                

            }catch(Exception ex)
            {
                MessageBox.Show($"Error al obtener los usuarios: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtiene los Status
        public override void FillComboStatus()
        {
            try
            {
                requestsDA = new RequestsDA();
                cbStatus.Items.Add("- Seleccionar -");
                foreach(var item in requestsDA.FillComboStatus())
                {
                    this.cbStatus.Items.Add(item);
                }                
                this.cbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los status: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtiene las Notas o comentarios de los Tickets
        public override void GetNotesTicket(string ticket)
        {
            try
            {
                this.tbMuestraComentario.Text = String.Join(Environment.NewLine,requestsDA.GetNotesTicket(ticket));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las notas: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Para el evento del RadioButton Usuarios
        private void rbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbUsuarios.Checked)
            {
                radioSeleccionado = "Usuarios";
                try
                {
                    requestsDA = new RequestsDA();
                    this.cbFiltrado.Items.Clear();
                    this.cbFiltrado.Items.Add("- Seleccionar -");
                    foreach (var item in requestsDA.FillComboUsuarios())
                    {
                        this.cbFiltrado.Items.Add(item);
                    }
                    this.cbFiltrado.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los usuarios: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Para el evento del RadioButton Estatus
        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbStatus.Checked)
            {
                radioSeleccionado = "Estatus";
                try
                {
                    requestsDA = new RequestsDA();
                    cbFiltrado.Items.Clear();
                    cbFiltrado.Items.Add("- Seleccionar -");
                    foreach (var item in requestsDA.FillComboStatus())
                    {
                        this.cbFiltrado.Items.Add(item);
                    }
                    this.cbFiltrado.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los status: {ex.Message}",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
           
        }

        // Para el evento del boton filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Filtra por usuarios
            if (radioSeleccionado.Equals("Usuarios"))
            {
                if ((this.cbFiltrado.GetItemText(this.cbFiltrado.SelectedItem).ToString()) != "- Seleccionar -")
                {
                    try
                    {
                        requestsDA = new RequestsDA();
                        this.gridSolicitudes.DataSource = null;
                        this.gridSolicitudes.Rows.Clear();
                        int user = cbFiltrado.SelectedIndex;
                        this.gridSolicitudes.DataSource = requestsDA.FillGridRequestsPerUser(user+1);
                        DisableColumnGrid();
                        rbUsuarios.Checked = false;
                        cbFiltrado.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al filtrar los datos: {ex.Message}",
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Filtra por estatus
            else if(radioSeleccionado.Equals("Estatus"))
            {
                try
                {
                    requestsDA = new RequestsDA();
                    this.gridSolicitudes.DataSource = null;
                    this.gridSolicitudes.Rows.Clear();
                    int status = cbFiltrado.SelectedIndex;
                    this.gridSolicitudes.DataSource = requestsDA.GetRequestsForStatus(status);
                    DisableColumnGrid();
                    rbStatus.Checked = false;
                    cbFiltrado.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los datos: {ex.Message}",
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Llena el grid
            else
            {
                try
                {
                    this.gridSolicitudes.DataSource = null;
                    this.gridSolicitudes.Rows.Clear();
                    FillGridRequests();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al filtrar los datos: {ex.Message}",
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        // Para asignar un Tecnico a una Solicitud
        public void SetTechnicalToRequest(string ticket,string technical,string allocator)
        {
            try
            {
                requestsDA = new RequestsDA();                
                requestsDA.SetTechnicalToRequest(ticket, technical,allocator);
                this.cbAsignar.SelectedIndex = 0;
                FillGridRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al asignar tecnico: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Actualiza el Status de un ticket
        public void UpdateStatusRequest(string ticket,int statusID,int userID)
        {
            try
            {
                
                requestsDA.UpdateStatusRequest(ticket, statusID, userID);
                FillGridRequests();
                this.cbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al actualizar status: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obtiene un ticket mediante un numero
        public override void SearchTicket(string ticket)
        {
            requestsDA = new RequestsDA();

            try
            {
                if (String.IsNullOrEmpty(ticket))
                {
                    this.gridSolicitudes.DataSource = null;
                    this.gridSolicitudes.Rows.Clear();
                    FillGridRequests();
                }
                else
                {
                    this.gridSolicitudes.DataSource = null;
                    this.gridSolicitudes.Rows.Clear();
                    this.gridSolicitudes.DataSource = requestsDA.FillGridRequests(tbSearch.Text.Trim());
                    DisableColumnGrid();
                    this.tbSearch.Text = "";
                }
            }
            catch ( InvalidOperationException )
            {
                MessageBox.Show($"El ticket: {ticket} no existe.",
                    "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FillGridRequests();
                this.tbSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llenar el grid de la solicitudes: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        // Agrega un nuvo comentario a un ticket
        public void AddComment()
        {
            if (!String.IsNullOrEmpty(tbAgregaComentario.Text))
            {
                string ticket = this.gridSolicitudes.CurrentRow.Cells[0].Value.ToString();
                requestsDA.AddComment(ticket, tbAgregaComentario.Text, UserUp.UserFullName);
                GetNotesTicket(ticket);
                tbAgregaComentario.Text = "";
            }
        }

        // Evento del Boton Actualizar, llama al metodo de actualizar ticket
        public override void btnAsignar_Click(object sender, EventArgs e)
        {
            string ticket = this.gridSolicitudes.CurrentRow.Cells[0].Value.ToString();
            string technical = this.cbAsignar.GetItemText(this.cbAsignar.SelectedItem).ToString();
            if (!technical.Equals("- Seleccionar -"))                
                SetTechnicalToRequest(ticket,technical,UserUp.UserFullName);
        }

        // Evento del Boton Actualizar Estatus
        public override void btnActualizar_Click(object sender, EventArgs e)
        {
            string ticket = this.gridSolicitudes.CurrentRow.Cells[0].Value.ToString();
            string status = this.cbStatus.GetItemText(this.cbStatus.SelectedItem).ToString();
            int statusID = 0;
            if (!status.Equals("- Seleccionar -"))
            {
                statusID = this.cbStatus.SelectedIndex;
                UpdateStatusRequest(ticket,statusID,UserUp.UserID);
            }
            
        }

        // Evento del Boton Agregar Comentario
        public override void btnComentar_Click(object sender, EventArgs e)
        {
            AddComment();
        }

        // El envento del boton buscar llama al metodo buscar ticket
        public override void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchTicket(this.tbSearch.Text.Trim());
        }

       
    }
}
