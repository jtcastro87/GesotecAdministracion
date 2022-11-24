using CapaDatos;
using System;

namespace CapaNegocio
{
    public class DomainCD
    {
        QueryDB queryDB;

        // Estos metodos llenan los tableros de los HelpDesk
        // Obtiene total de ticket creados sin Asignar
        public string GetTotalRequestsUnAssigned()
        {
            queryDB = new QueryDB();
            var total = queryDB.GetTotalRequestsUnAssigned();
            return total.ToString();
        }

        // Obtiene el total de los ticket en Erocesos
        public string GetTotalInProcessRequests()
        {
            queryDB = new QueryDB();
            int total = queryDB.GetTotalInProcessRequests();
            return total.ToString();
        }

        // Obtiene el total de los tickets en Espera
        public string GetTotalInWaitRequests()
        {
            queryDB = new QueryDB();
            int total = queryDB.GetTotalInWaitRequests();
            return total.ToString();
        }

        // Obtiene el total de los tickets Cerrados
        public string GetTotalCloseRequests()
        {
            queryDB = new QueryDB();
            int total = queryDB.GetTotalCloseRequests();
            return total.ToString();
        }

        // Obtiene el total de los usuarios Conectados
        public string GetTotalAllOnlineUser()
        {
            queryDB = new QueryDB();
            int total = queryDB.GetTotalAllOnlineUser();
            return total.ToString();
        }

        // Para Actualizar el estatus del usuario a NO online
        public void UpdateOnlineUser(int id,bool status)
        {
            queryDB = new QueryDB();
            queryDB.UpdateOnlineUser(id,status);
        }



        /** Estos metodos llenan los tableros de los SOPORTES **/

        // Obtiene el total de Tiecket Asignado a un Usuario
        public string GetTotalRequestsAssignedPerUser(int id)
        {
            queryDB = new QueryDB();
            return queryDB.GetTotalRequestsAssignedPerUser(id).ToString();
        }

        // Obtiene total de ticket asignado a un usuario
        public string GetTotalInProcessRequestsPerUserd(int id)
        {
            queryDB = new QueryDB();
            int total = queryDB.GetTotalInProcessRequestsPerUser(id);
            return total.ToString();
        }

        // Devuelve el total de los tickest en Espera de un usuario
        public string GetTotalInWaitRequestsPerUser(int id)
        {
            queryDB = new QueryDB();
            return queryDB.GetTotalInWaitRequestsPerUser(id).ToString();
        }

        //Devuelve el total de los tickets cerrados por usuarios
        public string GetTotalCloseRequestsPerUser(int id)
        {
            queryDB = new QueryDB();
            return queryDB.GetTotalCloseRequestsPerUser(id).ToString();
        }





    }
}
