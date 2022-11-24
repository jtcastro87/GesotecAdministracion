using CapaNegocio;
using Common.Cache;
using System;

namespace CapaPresentacion.PanelPrincipal
{
    public partial class HelpDeskDashboard : BaseDashboar
    {
        public HelpDeskDashboard()
        {
            InitializeComponent();
        }

        DomainCD domainCD; 

        // Al cargar la ventana l
        private void HelpDeskDashboard_Load(object sender, EventArgs e)
        {
            UpdateDashBoard();
            timer1.Start();
        }     
       
        // Obtiene los datos de los DASHBOARD
        private void UpdateDashBoard()
        {
            domainCD = new DomainCD();
            this.lblCantidad.Text = domainCD.GetTotalRequestsUnAssigned(); // Por Asignar
            this.lblTotalProceso.Text = domainCD.GetTotalInProcessRequests(); // En Proceso
            this.lblTotalEspera.Text = domainCD.GetTotalInWaitRequests(); // En Espera
            this.lblTotalFinalizados.Text = domainCD.GetTotalCloseRequests(); // Finalizados
            this.lblTotalOnlieUser.Text = domainCD.GetTotalAllOnlineUser(); // Usuarios en Linea
        }


        private void HelpDeskDashboard_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateDashBoard();
        }
    }
}
