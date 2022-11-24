using System.Windows.Forms;
using Common.Cache;
using CapaNegocio;


namespace CapaPresentacion.PanelPrincipal
{
    public partial class PrincipalCP : Form
    {
        
        // Constructor sin parametros, se eleiminara luego
        public PrincipalCP()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        DomainCD domainCD;

        // Este metodo load llama al metodo que valida el usuario logeado
        private void Principal_Load(object sender, System.EventArgs e)
        {
            //VerifyUser();
            OpenChildFormDashboard();
            lblRol.Text = UserUp.UserRol;
            lblFullName.Text = UserUp.UserFullName;
            lblUserUp.Text = UserUp.UserLogin;
            lblEmail.Text = UserUp.UserMail;
        }
        
        // Metodo que ejecuta el boton Dashboar
        private void OpenChildFormDashboard()
        {
            this.lblTituloTop.Text = btnDashboard.Text;
            if (UserUp.UserRol == Position.Soporte)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                TechnicalDashboar td = new TechnicalDashboar();
                td.FormBorderStyle = FormBorderStyle.None;
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                td.TopLevel = false;
                td.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(td);
                this.centralPanel.Tag = td;
                td.Show();
            }
            else if (UserUp.UserRol == Position.HelpDesk)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                HelpDeskDashboard hd = new HelpDeskDashboard();
                hd.FormBorderStyle = FormBorderStyle.None;
                hd.TopLevel = false;
                hd.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(hd);
                this.centralPanel.Tag = hd;
                hd.Show();
            }
            else if (UserUp.UserRol == Position.Administrator)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                HelpDeskDashboard hd = new HelpDeskDashboard();
                hd.FormBorderStyle = FormBorderStyle.None;
                hd.TopLevel = false;
                hd.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(hd);
                this.centralPanel.Tag = hd;
                hd.Show();
            }
        }

        // Metodo que ejecuta el boton Solicitudes
        private void OpenFromSolicitudes()
        {
            this.lblTituloTop.Text = btnSolicitudes.Text;
            if (UserUp.UserRol == Position.Soporte)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                SolicitudesTS solicitudesTS = new SolicitudesTS();
                solicitudesTS.FormBorderStyle = FormBorderStyle.None;
                solicitudesTS.TopLevel = false;
                solicitudesTS.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(solicitudesTS);
                this.centralPanel.Tag = solicitudesTS;
                solicitudesTS.Show();
            }
            else if (UserUp.UserRol == Position.HelpDesk)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                btnUsuarios.Enabled = false;
                btnReportes.Enabled = false;
                SolicitudesHD solicitudesHD = new SolicitudesHD();
                solicitudesHD.FormBorderStyle = FormBorderStyle.None;
                solicitudesHD.TopLevel = false;
                solicitudesHD.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(solicitudesHD);
                this.centralPanel.Tag = solicitudesHD;
                solicitudesHD.Show();
            }
            else if (UserUp.UserRol == Position.Administrator)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                SolicitudesHD solicitudesHD = new SolicitudesHD();
                solicitudesHD.FormBorderStyle = FormBorderStyle.None;
                solicitudesHD.TopLevel = false;
                solicitudesHD.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(solicitudesHD);
                this.centralPanel.Tag = solicitudesHD;
                solicitudesHD.Show();
            }
        }

        // Metodo que ejecuta el boton Usuarios
        private void OpenFromUsuarios()
        {
            this.lblTituloTop.Text = btnUsuarios.Text;
            if (UserUp.UserRol == Position.Administrator)
            {
                if (this.centralPanel.Controls.Count > 0)
                    this.centralPanel.Controls.RemoveAt(0);
                Usuarios usuarios = new Usuarios();
                usuarios.FormBorderStyle = FormBorderStyle.None;
                usuarios.TopLevel = false;
                usuarios.Dock = DockStyle.Fill;
                this.centralPanel.Controls.Add(usuarios);
                this.centralPanel.Tag = usuarios;
                usuarios.Show();
            }
        }

        // Metodo para el Boton Dashboard
        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            OpenChildFormDashboard();
        }

        // Metodo para el Boton Solicitudes
        private void btnSolicitudes_Click(object sender, System.EventArgs e)
        {
            OpenFromSolicitudes();
        }

        private void btnUsuarios_Click(object sender, System.EventArgs e)
        {
            OpenFromUsuarios();
        }

        // Metodo que cierra la aplicacion al cerrarce la ventana
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Cierra la Aplicacion
        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir", "Saliendo del sistema",
                                                        MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }

        private void PrincipalCP_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            try
            {
                domainCD = new DomainCD();
                domainCD.UpdateOnlineUser(UserUp.UserID, false);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error al desconectar: {ex.Message}", "Error", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error);
            }

        }

       
    }
}
