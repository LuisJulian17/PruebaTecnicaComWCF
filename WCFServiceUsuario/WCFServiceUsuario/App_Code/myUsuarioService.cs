using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class myUsuarioService : myUsuarioIService
{

    string cadenaConexion = ConfigurationManager.ConnectionStrings["myConexion"].ConnectionString;
    public Usuario buscarUsuario(int idUsuario)
    {   
        Usuario usuario = new Usuario();

        try
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Buscar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idUsuario);

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                if (rd.Read())
                {
                    usuario.Id = rd.GetInt32(0);
                    usuario.Nom = rd.GetString(1);
                    usuario.FechaN = rd.GetString(2);
                    usuario.Sexo = rd.GetString(3);
                }
            }
            else
            {
                throw new Exception("No hay registros para la consultar");
            }

            cnn.Close();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al consultar", ex);
        }
        return usuario;
    }

    public int EditarUsuario(Usuario usuario)
    {
        int res = 0;

        try
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Actualizar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@nom", usuario.Nom);
            cmd.Parameters.AddWithValue("@fechaN", usuario.FechaN);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);

            res = cmd.ExecuteNonQuery();

            cnn.Close();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al editar", ex);
        }
        return res;
    }

    public int EliminarUsuario(int idUsuario)
    {
        int res = 0;

        try
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Eliminar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", idUsuario);

            res = cmd.ExecuteNonQuery();

            cnn.Close();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al eliminar", ex);
        }
        return res;
    }

    public List<Usuario> ListarUsuarios()
    {
        List<Usuario> lista = new List<Usuario>();
        try
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Listar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    lista.Add(new Usuario
                    {
                        Id=rd.GetInt32(0),
                        Nom=rd.GetString(1),
                        FechaN = rd.GetString(2),
                        Sexo = rd.GetString(3),
                });
                }
            }
            else
            {
                throw new Exception("No hay registros para la consultar");
            }

            cnn.Close();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al consultar", ex);
        }
        return lista;
    }

    public int NuevoUsuario(Usuario usuario)
    {
        int res = 0;

        try
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Insertar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nom", usuario.Nom);
            cmd.Parameters.AddWithValue("@fechaN", usuario.FechaN);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);

            res = cmd.ExecuteNonQuery();

            cnn.Close();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al insertar", ex);
        }
        return res;
    }
}
