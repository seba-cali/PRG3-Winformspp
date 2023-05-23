﻿using System;
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
				comando.CommandText = "SELECT Numero, Nombre, p.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE e.Id = P.IdTipo and D.Id = P.IdDebilidad and P.Activo=1";
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
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("INSERT INTO POKEMONS(Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values(" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1,  @idTipo, @idDebilidad, @urlImagen)");
				datos.setearParametro("@idTipo", nuevo.Tipo.Id);
				datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id);
				datos.setearParametro("@urlImagen", nuevo.UrlImagen);

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
		public void modificar(Pokemon poke)
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
		public void eliminar(int id)
		{
			try
			{
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("DELETE FROM POKEMONS where id= @id");
				datos.setearParametro("@id", id);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}

		public void eliminarLogico(int id)
		{
			try
			{
				AccesoDatos datos = new AccesoDatos();
				datos.setearConsulta("update POKEMONS set Activo = 0 where id = @id");
				datos.setearParametro("@id", id);
				datos.ejecutarAccion();

			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public List<Pokemon> filtrar(string campo, string criterio, string filtro)
		{
			List<Pokemon> lista = new List<Pokemon>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				string consulta = "SELECT Numero, Nombre, p.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE e.Id = P.IdTipo and D.Id = P.IdDebilidad and P.Activo=1 And ";
				if (campo == "Numero")
				{
					switch (criterio)
					{
						case "Mayor a":
							consulta += "Numero > " + filtro;
							break;
						case "Menor a":
							consulta += "Numero < " + filtro;
							break;
						default:
							consulta += "Numero = " + filtro;
							break;
					}
				}
				else if(campo == "Nombre")
				{
					switch (criterio)
					{
						case "Comienza con":
							consulta += "Nombre like '" + filtro + "%' ";
							break;
						case "Termina con":
							consulta += "Nombre like '%" + filtro + "'";
							break;
						default:
							consulta += "Nombre like '%" + filtro + "%'";
							break;
					}
				}
				else
				{
					switch (criterio)
					{
						case "Comienza con":
							consulta += "P.Descripcion '" + filtro + "%' ";
							break;
						case "Termina con":
							consulta += "P.Descripcion like '%" + filtro + "'";
							break;
						default:
							consulta += "P.Descripcion '%" + filtro + "%'";
							break; ;
					}

				}

				datos.setearConsulta(consulta);
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					Pokemon aux = new Pokemon();
					aux.Id = (int)datos.Lector["Id"];
					aux.Numero = datos.Lector.GetInt32(0);
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					if (!(datos.Lector["UrlImagen"] is DBNull))
						aux.UrlImagen = (string)datos.Lector["UrlImagen"];

					aux.Tipo = new Elemento();
					aux.Tipo.Id = (int)datos.Lector["IdTipo"];
					aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
					aux.Debilidad = new Elemento();
					aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
					aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

					lista.Add(aux);
				}
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}



