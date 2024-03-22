using System;
using Microsoft.Data.SqlClient;

namespace GSBANK;

public class ConexionBD
{
    private string connectionString = "Server=LAPTOP-TQH24RE4;Database=bancoDeSangre;Integrated Security=True;Encrypt=False;";

    public SqlConnection conexion;

    public ConexionBD()
    {
        conexion = new SqlConnection(connectionString);
    }

    public SqlConnection? AbrirConexion()
    {
        try
        {
            conexion.Open();
            return conexion;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
            return null;
        }
    }

    public void CerrarConexion()
    {
        conexion.Close();
    }

    
}