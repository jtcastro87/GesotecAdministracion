using CapaDatos;
using System;
using System.Data;
using Common.Cache;
using Common;

namespace CapaNegocio
{
    public class UserLoginCD
    {
        // Variables de la clase
        public string Login { get; set; }
        public string Pass { get; set; }

        // Metodo constructor de la clase, recibe el usuario y password
        public UserLoginCD(string login,string pass)
        {
            this.Login = login;
            this.Pass = pass;
        }

        // Variables utilitarias
        QueryDB queryDB;     
   
        // Consulta el user y el login
        public bool GetUserLogin()
        {
            queryDB = new QueryDB();           

            Usuario usuario = queryDB.GetUserLogin(this.Login); // Con estemetodo se realiza la consulta del usuario recibido

            if (this.Login.Equals( usuario.UserLogin ))
            {
                if (this.Pass.Equals (usuario.UserPass) )
                {
                    UserUp.UserID = usuario.UserId;
                    UserUp.UserFullName = String.Concat(usuario.UserNom + " " + usuario.UserApe);
                    UserUp.UserLogin = usuario.UserLogin;
                    UserUp.UserMail = usuario.UserMail;
                    UserUp.UserPass = usuario.UserPass;
                    UserUp.UserRol = usuario.UserRol;
                    usuario = null;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            queryDB.UpdateOnlineUser(UserUp.UserID, true);
            return true;
        }
    }
}
