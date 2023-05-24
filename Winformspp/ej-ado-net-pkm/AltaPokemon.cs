using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.IO;
using System.Configuration;

namespace ej_ado_net_pkm
{
		public partial class frmAltaPokemon : Form
		{
				private Pokemon pokemon = null;
				private OpenFileDialog archivo = null;
				public frmAltaPokemon()
				{
						InitializeComponent();
				}
				public frmAltaPokemon(Pokemon pokemon)
				{
						InitializeComponent();
						this.pokemon = pokemon;
						Text = "Modificar Pokemon";
				}


				private void btnCancelar_Click(object sender, EventArgs e)
				{
					this.Close();
				}

				private void btnAceptar_Click(object sender, EventArgs e)
				{
						//todo: Continuar video Modificar Pokemon @ 19 min
						//Pokemon	poke = new Pokemon();
						PokemonNegocio negocio = new PokemonNegocio();

						try
						{//lo agrego aca para saber si es nuevo pokemon. Si no esta nulo, se trigerea el @modificar@
								if(pokemon == null)
										pokemon = new Pokemon();
								pokemon.Numero = int.Parse(txtNumero.Text);
								pokemon.Nombre	= txtNombre.Text;
								pokemon.Descripcion = txtDescripcion.Text;
								//mapeo la imagen
								pokemon.UrlImagen	= txtImagen.Text;
								pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
								pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

								if (pokemon.Id != 0)
								{
										negocio.modificar(pokemon);
										MessageBox.Show("Modificado exitosamente");

								}
								else
								{
										negocio.agregar(pokemon);
										MessageBox.Show("Agregado exitosamente");
								}

								//Guardo imagen si la levanto localmente
								if (archivo != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
								{
									File.Copy(archivo.FileName, ConfigurationSettings.AppSettings["images-folder"] +				archivo.SafeFileName);
								}

								Close();

						}
						catch (Exception ex)
						{
								MessageBox.Show(ex.ToString());
						}
				}

				private void frmAltaPokemon_Load(object sender, EventArgs e)
				{
						ElementoNegocio elementoNegocio = new ElementoNegocio();
						try
						{
								cboTipo.DataSource = elementoNegocio.listar();
								cboTipo.ValueMember = "Id";
								cboTipo.DisplayMember = "Descripcion";
								cboDebilidad.DataSource = elementoNegocio.listar();
								cboDebilidad.ValueMember = "Id";
								cboDebilidad.DisplayMember = "Descripcion";


								//preselecciono valores
								if(pokemon != null)
								{
										txtNumero.Text = pokemon.Numero.ToString();
										txtNombre.Text = pokemon.Nombre;
										txtDescripcion.Text = pokemon.Descripcion;
										txtImagen.Text = pokemon.UrlImagen;
										cargarImagen(pokemon.UrlImagen);
										cboTipo.SelectedValue = pokemon.Tipo.Id;
										cboDebilidad.SelectedValue = pokemon.Debilidad.Id;


								}
					

						}
						catch (Exception ex)
						{

								MessageBox.Show(ex.ToString());
						}
				}

				private void txtImagen_Leave(object sender, EventArgs e)
				{
						cargarImagen(txtImagen.Text);
				}

				private void cargarImagen(string imagen)
				{
						try
						{
								pbxPokemon.Load(imagen);
						}
						catch (Exception ex)
						{
								pbxPokemon.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
						}
				}

		private void btnAgregarImagen_Click(object sender, EventArgs e)
		{
			archivo = new OpenFileDialog();
			archivo.Filter = "Archivo de imagen|*.jpg;*.png;*.gif;*.bmp";
			if(archivo.ShowDialog() == DialogResult.OK)
			{
				txtImagen.Text = archivo.FileName;
				cargarImagen(archivo.FileName);//devuelve el nombre del archivo y su ruta

				//guardo la imagen. necesito el using System.IO para usar copy;
				//en framework 4.8 se usa confoguration MANAGER
				//File.Copy(archivo.FileName, ConfigurationSettings.AppSettings["images-folder"] + archivo.SafeFileName);
			}
		}
	}
}
