using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class QueryDB : Conexion
    {
        /*** COMUNUES ***/
        // Realiza la consulta para el login a la aplicacion
        public Usuario GetUserLogin(string login)
        {
            Usuario usuario = new Usuario() ;

            using ( var conn = GetConnection() )
            {
                conn.Open();
                using ( SqlCommand comando = new SqlCommand() )
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Security.SP_GetUserForLogin";
                    comando.Parameters.AddWithValue("@userLogin",login);
                    SqlDataReader dataReader = comando.ExecuteReader();
                    dataReader.Read();
                    usuario.UserId = dataReader.GetFieldValue<int>(0);
                    usuario.UserNom = dataReader.GetFieldValue<string>(1);
                    usuario.UserApe = dataReader.GetFieldValue<string>(2);
                    usuario.UserLogin = dataReader.GetFieldValue<string>(3);
                    usuario.UserMail = dataReader.GetFieldValue<string>(4);
                    usuario.UserPass = dataReader.GetFieldValue<string>(5);
                    usuario.UserRol = dataReader.GetFieldValue<string>(6);
                    dataReader.Close();
                    return usuario;
                }
            }

            
        }

        // Actualiza el estado del usuario a Offline / Online
        public void UpdateOnlineUser(int id,bool status)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Security.SP_UpdateUserOnline";
                    comando.Parameters.AddWithValue("@userId", id);
                    comando.Parameters.AddWithValue("@status",status);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Para llenar el GRID de Solicitudes
        public List<RequestModel> FillGridRequests()
        {
            List<RequestModel> solicitudes = new List<RequestModel>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetRequestsUnAssigned";
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            solicitudes.Add(new RequestModel()
                            {
                                Ticket = dr.GetFieldValue<string>(0),
                                Employee = dr.GetFieldValue<string>(1),
                                Area = dr.GetFieldValue<string>(2),
                                Department = dr.GetFieldValue<string>(3),
                                ExtIP = dr.GetFieldValue<string>(4),
                                Category = dr.GetFieldValue<string>(5),
                                Detail = dr.GetFieldValue<string>(6),
                                CreateDate = dr.GetFieldValue<DateTime>(7),
                                CreateTime = dr.GetFieldValue<string>(8),
                                Priority = dr.GetFieldValue<string>(9),
                                Status = dr.GetFieldValue<string>(10),
                                Assigned = dr.GetFieldValue<bool>(11)
                            });
                        }
                    }
                    dr.Close();
                    return solicitudes;
                }
            }


        }

        // Sobrecarga del metodo llenar GRID Solicitudes mediante un numero de Ticket
        public List<RequestModel> FillGridRequests(string param)
        {
            List<RequestModel> solicitudes = new List<RequestModel>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetRequestsForNunTicket";
                    comando.Parameters.AddWithValue("@ticket", param);
                    SqlDataReader dr = comando.ExecuteReader();
                    dr.Read();
                    solicitudes.Add(new RequestModel()
                    {
                        Ticket = dr.GetFieldValue<string>(0),
                        Employee = dr.GetFieldValue<string>(1),
                        Area = dr.GetFieldValue<string>(2),
                        Department = dr.GetFieldValue<string>(3),
                        ExtIP = dr.GetFieldValue<string>(4),
                        Category = dr.GetFieldValue<string>(5),
                        Detail = dr.GetFieldValue<string>(6),
                        CreateDate = dr.GetFieldValue<DateTime>(7),
                        CreateTime = dr.GetFieldValue<string>(8),
                        Priority = dr.GetFieldValue<string>(9),
                        Status = dr.GetFieldValue<string>(10),
                        Assigned = dr.GetFieldValue<bool>(11)

                    });

                    dr.Close();
                    return solicitudes;
                }
            }


        }

        // Devuelve una lista de nombres de usuarios
        public List<string> FillComboUsuarios()
        {
            List<string> usuarios = new List<string>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {

                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Security.SP_GetAllUserName";
                    SqlDataReader dr = comando.ExecuteReader();
                    while ( dr.Read() )
                    {
                        if ( dr.HasRows )
                        {
                            usuarios.Add( dr.GetFieldValue<string>(0) );
                        }
                    }
                    dr.Close();

                    return usuarios;
                }
            }
        }

        // Devuelve unaa lista de nombre de estatus
        public List<string> FillComboStatus() 
        {
            List<string> status = new List<string>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetStatusName";
                    SqlDataReader dr = comando.ExecuteReader();
                    while ( dr.Read())
                    {
                        if ( dr.HasRows )
                        {
                            status.Add(dr.GetFieldValue<string>(0));
                        }
                    }
                    dr.Close();

                    return status;
                }
            }
        }

        // Devuelve las Notas de un determinado Ticket
        public List<string> GetNotesTicket(string ticket)
        {
            List<string> notas = new List<string>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetNotesTicket";
                    comando.Parameters.AddWithValue("@ticket", ticket);
                    SqlDataReader dr = comando.ExecuteReader();
                    string nota = string.Empty;
                    string usuario = string.Empty;
                    string fecha = string.Empty;
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            nota = dr[0].ToString();
                            usuario = dr[1].ToString();
                            fecha = dr[2].ToString();

                            if (usuario != null)
                                notas.Add(usuario + " escribio: " + nota + "\r\n " + " el dia "+ fecha + "\r\n");
                            else
                                notas.Add(nota + "\r\n " + fecha + "\r\n");
                        }
                    }
                    dr.Close();

                    return notas;
                }
            }
        }

        // Establece Tecnico a Solicitud
        public void SetTechnicalToRequest(string ticket,string techical,string allocator)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_UpdateRequestsTechnical";
                    comando.Parameters.AddWithValue("@ticket",ticket);
                    comando.Parameters.AddWithValue("@technical", techical);
                    comando.Parameters.AddWithValue("@allocator", allocator);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Actualiza el Status de un ticket
        public void UpdateStatusRequest(string ticket,int statusID,int userID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_UpdateRequestsStatus";
                    comando.Parameters.AddWithValue("@ticket", ticket);
                    comando.Parameters.AddWithValue("@status", statusID);
                    comando.Parameters.AddWithValue("@UserID", userID);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Agrega un comentario nuevo
        public void AddComment(string ticket,string comment,string addedComment)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.InsertNotes";
                    comando.Parameters.AddWithValue("@ticket",ticket);
                    comando.Parameters.AddWithValue("@comment",comment);
                    comando.Parameters.AddWithValue("@addedComment",addedComment);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Devuelve los Ticket por su status
        public List<RequestModel> GetRequestsForStatus(int statusId)
        {
            List<RequestModel> solicitudes = new List<RequestModel>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetRequestsForStatus";
                    comando.Parameters.AddWithValue("statusId", statusId);
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            solicitudes.Add(new RequestModel()
                            {
                                Ticket = dr.GetFieldValue<string>(0),
                                Employee = dr.GetFieldValue<string>(1),
                                Area = dr.GetFieldValue<string>(2),
                                Department = dr.GetFieldValue<string>(3),
                                ExtIP = dr.GetFieldValue<string>(4),
                                Category = dr.GetFieldValue<string>(5),
                                Detail = dr.GetFieldValue<string>(6),
                                CreateDate = dr.GetFieldValue<DateTime>(7),
                                CreateTime = dr.GetFieldValue<string>(8),
                                Priority = dr.GetFieldValue<string>(9),
                                Status = dr.GetFieldValue<string>(10),
                                Assigned = dr.GetFieldValue<bool>(11)
                            });
                        }
                    }
                    dr.Close();
                    return solicitudes;
                }
            }
        }

        // Devuelve los Ticket por Status de un Usuario
        public List<RequestModel> GetRequestsForStatusPerUser(int statusId,int userId)
        {
            List<RequestModel> solicitudes = new List<RequestModel>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetRequestsForStatusPerUser";
                    comando.Parameters.AddWithValue("statusId", statusId);
                    comando.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            solicitudes.Add(new RequestModel()
                            {
                                Ticket = dr.GetFieldValue<string>(0),
                                Employee = dr.GetFieldValue<string>(1),
                                Area = dr.GetFieldValue<string>(2),
                                Department = dr.GetFieldValue<string>(3),
                                ExtIP = dr.GetFieldValue<string>(4),
                                Category = dr.GetFieldValue<string>(5),
                                Detail = dr.GetFieldValue<string>(6),
                                CreateDate = dr.GetFieldValue<DateTime>(7),
                                CreateTime = dr.GetFieldValue<string>(8),
                                Priority = dr.GetFieldValue<string>(9),
                                Status = dr.GetFieldValue<string>(10),
                                Assigned = dr.GetFieldValue<bool>(11)
                            });
                        }
                    }
                    dr.Close();
                    return solicitudes;
                }
            }
        }


        /*** Para el DASHBOARD de los HELPDESK ***/
        // Obtiene el total de ticket sin asignar
        public int GetTotalRequestsUnAssigned()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalRequestsUnAssigned";
                    int total = Convert.ToInt32(comando.ExecuteScalar());                   
                    return (int)total;
                }
            }

        }       

        // Obtiene el total de los ticket en progreso
        public int GetTotalInProcessRequests()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalInProcessRequests";
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }

        // Devuelve el total de los tickest en Espera
        public int GetTotalInWaitRequests()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalInWaitRequests";
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }

        //Devuelve el total de los tickets cerrados
        public int GetTotalCloseRequests()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalCloseRequests";
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }

        // Devuelve el total de los usuarios en linea 
        public int GetTotalAllOnlineUser()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Security.SP_GetTotalOnlineUser";
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }


        /*** Para el DASHBOARD de los SOPORTES ***/
        // Total de ticket por Asignados por Usuarios
        public int GetTotalRequestsAssignedPerUser(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalRequestsAssignedPerUser";
                    comando.Parameters.AddWithValue("@userID", id);
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }

        }

        // Obtiene el total de ticket en Procesos por Usuario
        public int GetTotalInProcessRequestsPerUser(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalInProcessRequestsPerUser";
                    comando.Parameters.AddWithValue("@userId", id);
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }

        }

        // Devuelve el total de los tickest en Espera de un usuario
        public int GetTotalInWaitRequestsPerUser(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalInWaitRequestsPerUser";
                    comando.Parameters.AddWithValue("@userId", id);
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }

        //Devuelve el total de los tickets cerrados por usuarios
        public int GetTotalCloseRequestsPerUser(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetTotalCloseRequestsPerUser";
                    comando.Parameters.AddWithValue("@userId", id);
                    int total = Convert.ToInt32(comando.ExecuteScalar());
                    return (int)total;
                }
            }
        }

        // Para llenar el GRID de Solicitudes de un Usuario
        public List<RequestModel> FillGridRequestsPerUser(int id)
        {
            List<RequestModel> solicitudes = new List<RequestModel>();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "Production.SP_GetRequestsAssignedTechnical";
                    comando.Parameters.AddWithValue("@userId",id);
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            solicitudes.Add(new RequestModel()
                            {
                                Ticket = dr.GetFieldValue<string>(0),
                                Employee = dr.GetFieldValue<string>(1),
                                Area = dr.GetFieldValue<string>(2),
                                Department = dr.GetFieldValue<string>(3),
                                ExtIP = dr.GetFieldValue<string>(4),
                                Category = dr.GetFieldValue<string>(5),
                                Detail = dr.GetFieldValue<string>(6),
                                CreateDate = dr.GetFieldValue<DateTime>(7),
                                CreateTime = dr.GetFieldValue<string>(8),
                                Priority = dr.GetFieldValue<string>(9),
                                Status = dr.GetFieldValue<string>(10),
                                Assigned = dr.GetFieldValue<bool>(11)
                            });
                        }
                    }
                    dr.Close();
                    return solicitudes;
                }
            }


        }









    }
}
