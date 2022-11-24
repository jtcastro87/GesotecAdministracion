using System;
using CapaNegocio;
using Common.Cache;

namespace CapaPresentacion.PanelPrincipal
{
    public partial class TechnicalDashboar : BaseDashboar
    {
        public TechnicalDashboar()
        {
            InitializeComponent();
        }

        private void TechnicalDashboar_Load(object sender, EventArgs e)
        {
            UpdateDashBoard();
            timer1.Start();
        }

        DomainCD domainCD;

        private void UpdateDashBoard()
        {
            domainCD = new DomainCD();
            this.lblCantidad.Text = domainCD.GetTotalRequestsAssignedPerUser(UserUp.UserID);
            this.lblTotalProceso.Text = domainCD.GetTotalInProcessRequestsPerUserd(UserUp.UserID);
            this.lblTotalEspera.Text = domainCD.GetTotalInWaitRequestsPerUser(UserUp.UserID);
            this.lblTotalFinalizados.Text = domainCD.GetTotalCloseRequestsPerUser(UserUp.UserID);
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDashBoard();
        }

        private void TechnicalDashboar_GiveFeedback(object sender, System.Windows.Forms.GiveFeedbackEventArgs e)
        {
            timer1.Stop();
        }
    }
}
