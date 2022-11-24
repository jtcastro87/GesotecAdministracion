using CapaDatos;
using Common;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class RequestsDA
    {
        QueryDB queryDB;

        public List<RequestModel> FillGridRequests() 
        {
            queryDB = new QueryDB();

            List<RequestModel> requests = queryDB.FillGridRequests();

            return requests;
        }

        public List<RequestModel> FillGridRequests(string param)
        {
            queryDB = new QueryDB();

            List<RequestModel> requests = queryDB.FillGridRequests(param);

            return requests;
        }

        public List<RequestModel> FillGridRequestsPerUser(int id)
        {
            queryDB = new QueryDB();

            List<RequestModel> requests = queryDB.FillGridRequestsPerUser(id);

            return requests;
        }

        public List<string> FillComboUsuarios()
        {
            queryDB = new QueryDB();

            return queryDB.FillComboUsuarios();
        }

        public List<string> FillComboStatus()
        {
            queryDB = new QueryDB();

            return queryDB.FillComboStatus();
        }

        public List<string> GetNotesTicket(string ticket)
        {
            queryDB = new QueryDB();

            return queryDB.GetNotesTicket(ticket);
        }

        public void SetTechnicalToRequest(string ticket, string techical, string allocator)
        {
            queryDB = new QueryDB();

            queryDB.SetTechnicalToRequest(ticket,techical,allocator);
        }

        public void UpdateStatusRequest(string ticket, int statusID, int userID)
        {
            queryDB = new QueryDB();

            queryDB.UpdateStatusRequest(ticket, statusID, userID);
        }

        public void AddComment(string ticket, string comment, string addedComment)
        {
            queryDB = new QueryDB();

            queryDB.AddComment(ticket, comment, addedComment);
        }

        public List<RequestModel> GetRequestsForStatus(int statusId)
        {
            queryDB = new QueryDB();
            return queryDB.GetRequestsForStatus(statusId);
        }

        public List<RequestModel> GetRequestsForStatusPerUser(int statusId, int userId)
        {
            queryDB = new QueryDB();
            return queryDB.GetRequestsForStatusPerUser(statusId, userId);
        }
    }
}
