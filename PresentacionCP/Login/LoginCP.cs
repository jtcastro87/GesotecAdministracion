using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.PanelPrincipal;

namespace CapaPresentacion.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(tbUser.Text))
            {
                lblError.Text = "Favor ingrear un usuario valido!";
                lblError.Visible = true;
                tbUser.Clear();
                tbPass.Clear();
            }
            else if (String.IsNullOrEmpty(tbPass.Text))
            {
                lblError.Text = "Debe colocar una contraseña valida!";
                lblError.Visible = true;
                tbPass.Clear();
            }                
            else
            {
                try
                {
                    UserLoginCD userLogin = new UserLoginCD(tbUser.Text.Trim(), tbPass.Text.Trim());

                    if (userLogin.GetUserLogin() == true)
                    {
                        //PrincipalCP principal = new PrincipalCP(userLogin.UserID,userLogin.FullName,userLogin.Login,userLogin.Email,userLogin.Pass,userLogin.Rol);
                        PrincipalCP principalCP = new PrincipalCP();
                        principalCP.Show();
                        this.Hide();        
                    }
                    else
                    {
                        lblError.Text = "Usuario o contraseña incorrecto!";
                        lblError.Visible = true;
                    }
                }catch(Exception ex)
                {
                    lblError.Text = String.Format("Usuario no existe: ",ex.Message.ToString());
                    lblError.Visible = true;
                    tbUser.Clear();
                    tbPass.Clear();
                }
                
            }

        }
    }
}
