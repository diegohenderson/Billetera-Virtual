using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Billetera.Web.Models
{
    public class GestorEjemplo
    {

        private const string StrConn =
       "Server=LAPTOP-0CRE86U4\\SQLEXPRESS;Database=Personas;User Id=sa;Password=123456;";
        public void AgregarPersona(Ejemplo nueva)
        {
            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO Personas(nombre, apellido) VALUES(@Nombre, @Apellido)";
            comm.Parameters.Add(new SqlParameter("@Nombre", nueva.Nombre));
            comm.Parameters.Add(new SqlParameter("@Apellido", nueva.Apellido));
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public List<Ejemplo> ObtenerPersonas()
        {
            List<Ejemplo> lista = new List<Ejemplo>();
            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM Personas";
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string apellido = dr.GetString(2);
                Ejemplo p = new Ejemplo(id, nombre, apellido);
                lista.Add(p);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public void Eliminar(int id)
        {
            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM Personas WHERE id=@Id";
            comm.Parameters.Add(new SqlParameter("@Id", id));
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public Ejemplo ObtenerPorId(int id)
        {
            Ejemplo p = null;
            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM Personas WHERE id=@Id";
            comm.Parameters.Add(new SqlParameter("@Id", id));
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                string nombre = dr.GetString(1);
                string apellido = dr.GetString(2);
                p = new Ejemplo(id, nombre, apellido);
            }
            dr.Close();
            conn.Close();
            return p;
        }
        public void ModificarPersona(Ejemplo p)
        {
            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE Persona       SET nombre = @Nombre, apellido = @Apellido WHERE id = @Id";
            comm.Parameters.Add(new SqlParameter("@Nombre", p.Nombre));
            comm.Parameters.Add(new SqlParameter("@Apellido",
           p.Apellido));
            comm.Parameters.Add(new SqlParameter("@Id", p.Id));
            comm.ExecuteNonQuery();
            conn.Close();
        }

    }
}