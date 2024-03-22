namespace GBDS2;
class ConsultaEmparejamiento
{
    ConexionBD conexionBD = new ConexionBD();
    public void Usuario()
    {
      string query =""

      using (SqlCommand command = new SqlCommand(query,conexionBD.AbrirConexion()))
      {

      }
    }
}