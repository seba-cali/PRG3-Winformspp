using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
		public class PokemonNegocio
		{
				public List<Pokemon> listar()
				{
						List<Pokemon> lista = new List<Pokemon>();
						//creo los objetos para la conexion y el comando
						SqlConnection conexion = new SqlConnection();
						SqlCommand comando = new SqlCommand();
						SqlDataReader lector;

						try
						{
								conexion.ConnectionString = "server=localhost\\LABO3; database=POKEDEX_DB; integrated security=false; user=sa; password=123xx;";
								comando.CommandType = System.Data.CommandType.Text;
								comando.CommandText = "SELECT Numero, Nombre, p.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE e.Id = P.IdTipo and D.Id = P.IdDebilidad";
								comando.Connection = conexion;

								conexion.Open();
								lector = comando.ExecuteReader();

								while (lector.Read())
								{
										Pokemon aux = new Pokemon();
										aux.Numero = lector.GetInt32(0);
										aux.Nombre = (string)lector["Nombre"];
										aux.Descripcion = (string)lector["Descripcion"];
										aux.UrlImagen = (string)lector["UrlImagen"];
										aux.Tipo = new Elemento();
										aux.Tipo.Descripcion = (string)lector["Tipo"];
										aux.Debilidad = new Elemento();
										aux.Debilidad.Descripcion = (string)lector["Debilidad"];

										lista.Add(aux);
								}

								conexion.Close();
								return lista;
						}
						catch (Exception ex)
						{
								throw ex;
						}

				}
				public void agregar(Pokemon nuevo)
				{
						AccesoDatos	datos = new AccesoDatos();
						  
						try
						{
								datos.setearConsulta("INSERT INTO POKEMONS(Numero, Nombre, Descripcion, Activo) values("+nuevo.Numero + ", '" +nuevo.Nombre+ "', '" +nuevo.Descripcion+ "', 1)");
								datos.ejecutarAccion();
						}
						catch (Exception ex)
						{

								throw ex;
						}
						finally
						{
								datos.cerrarConexion();
						}
				}

				public void modiciar(Pokemon modificiar)
				{
				}
		}
}



