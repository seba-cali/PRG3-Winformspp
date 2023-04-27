using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ej_ado_net_pkm
{
		internal class PokemonNegocio
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
								conexion.ConnectionString = ".\\LABO3; database=POKEDEX_DB; integrated security=false; user=sa; password=123xx;";
								comando.CommandType = System.Data.CommandType.Text;
								comando.CommandText	= "SELECT Numero, Nombre, Descripcion FROM POKEMONS";
								comando.Connection = conexion;

								conexion.Open();
								lector = comando.ExecuteReader();

								while (lector.Read())
								{
										Pokemon aux = new Pokemon();
										aux.Numero = lector.GetInt32(0);
										aux.Nombre = (string)lector["Nombre"];
										aux.Descripcion = (string)lector["Descripcion"];

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

		}
}
