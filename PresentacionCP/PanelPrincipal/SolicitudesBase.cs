using System.Windows.Forms;

namespace CapaPresentacion.PanelPrincipal
{
    public partial class SolicitudesBase : Form
    {
        public SolicitudesBase()
        {
            InitializeComponent();
        }

        
        public virtual void FillGridRequests() { }

        public virtual void DisableColumnGrid() { }

        public virtual void FillGridComent() { }

        public virtual void FillComboUsuarios() { }

        public virtual void FillComboStatus() { }

        public virtual void GetNotesTicket(string ticket) { }

        public virtual void SearchTicket(string ticket) { }

        public virtual void btnBuscar_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void gridSolicitudes_SelectionChanged(object sender, System.EventArgs e)
        {

        }

        public virtual void btnAsignar_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void btnActualizar_Click(object sender, System.EventArgs e)
        {

        }

        public virtual void btnComentar_Click(object sender, System.EventArgs e)
        {

        }
    }
}
