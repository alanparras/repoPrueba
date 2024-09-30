using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class Usuario_Datos
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.id,u.nombre,u.apellido,u.zipcode,u.domicilio,u.email,u.usuario,u.pass,p.id_perfiles,p.descripcion,u.baja from usuarios u");
                    query.AppendLine("inner join perfiles p on p.id_perfiles = u.perfil_id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dataReader["id"]),
                                nombre = dataReader["nombre"].ToString(),
                                apellido = dataReader["apellido"].ToString(),
                                CP = Convert.ToInt32(dataReader["zipcode"]),
                                domicilio = dataReader["domicilio"].ToString(),
                                email = dataReader["email"].ToString(),
                                user = dataReader["usuario"].ToString(),
                                pass = dataReader["pass"].ToString(),
                                objPerfil = new Perfil() { id_perfil = Convert.ToInt32(dataReader["id_perfiles"]), descripcion = dataReader["descripcion"].ToString() },
                                baja = dataReader["baja"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
