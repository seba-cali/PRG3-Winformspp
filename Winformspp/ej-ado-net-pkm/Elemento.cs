using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_ado_net_pkm
{
		internal class Elemento
		{
				public int Id { get; set; }
				public string Descripcion { get; set; }

				public override string ToString() //sobreescribo el metodo ToString para que muestre la descripcion
				{
						return Descripcion;
				}
		}
}
