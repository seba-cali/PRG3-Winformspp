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
								comando.CommandText = "SELECT Numero, Nombre, p.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE e.Id = P.IdTipo and D.Id = P.IdDebilidad";
								comando.Connection = conexion;

								conexion.Open();
								lector = comando.ExecuteReader();

								while (lector.Read())
								{
										Pokemon aux = new Pokemon();
										aux.Id = (int)lector["Id"];
										aux.Numero = lector.GetInt32(0);
										aux.Nombre = (string)lector["Nombre"];
										aux.Descripcion = (string)lector["Descripcion"];
										//VALIDAR SI HAY NULLS EN LA BASE DE DATOS//2 formas//
										//if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
										//aux.UrlImagen = (string)lector["UrlImagen"];
										if (!(lector["UrlImagen"] is DBNull))
												aux.UrlImagen = (string)lector["UrlImagen"];

										aux.Tipo = new Elemento();
										aux.Tipo.Id = (int)lector["IdTipo"];
										aux.Tipo.Descripcion = (string)lector["Tipo"];
										aux.Debilidad = new Elemento();
										aux.Debilidad.Id = (int)lector["IdDebilidad"];
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
								datos.setearConsulta("INSERT INTO POKEMONS(Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values("+nuevo.Numero + ", '" +nuevo.Nombre+ "', '" +nuevo.Descripcion+ "', 1,  @idTipo, @idDebilidad, @urlImagen)");
								datos.setearParametro("@idTipo", nuevo.Tipo.Id);
								datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
								datos.setearParametro("@urlImagen",nuevo.UrlImagen);

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
				public void modificar( Pokemon poke)
				{
						AccesoDatos datos = new AccesoDatos();
						try
						{
								datos.setearConsulta("UPDATE POKEMONS SET Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @imagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad WHERE Id = @id");
								datos.setearParametro("@numero", poke.Numero);
								datos.setearParametro("@nombre", poke.Nombre);
								datos.setearParametro("@descripcion", poke.Descripcion);
								datos.setearParametro("@imagen", poke.UrlImagen);
								datos.setearParametro("@idTipo", poke.Tipo.Id);
								datos.setearParametro("@idDebilidad", poke.Debilidad.Id);
								datos.setearParametro("@ID", poke.Id);
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

		}
}



