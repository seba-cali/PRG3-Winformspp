using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Excepciones
{
		public partial class Form1 : Form
		{
				public Form1()
				{
						InitializeComponent();
				}

				private void btnCalcular_Click(object sender, EventArgs e)
				{
						int resultado;
						try
						{
								resultado = calcular();
								lblResultado.Text = "= " + resultado;
								//Si necesito que se EJECUTE SI o SI (operacion sensible)... @finally va a ejecutar siempre

						}
						catch (Exception ex)
						{
								MessageBox.Show("Error: " + ex.Message);//error generico
						}
						finally//las instrucciones se ejecutan siempre, independientemente de si se produjo o no una excepcion
						{
								//---!OPERACION SENSIBLE! tiene que ejecutarse si o si.
						}

						
						///Familias de catch//
						//catch (OverflowException ex)
						//catch (FormatException ex)//aca decidimos que hacer
						//{
						//		MessageBox.Show("Por favor, cargar solo numeros.");
						//		//throw; nos permite lanzar excepciones, cuando no estamos manjeando la excepcion. 
						//}
						//catch (DivideByZeroException ex)
						//{
						//		MessageBox.Show("No se puede dividir por cero.");
						//}
				}
				private int calcular()
				{
						int a, b, r;
						try
						{
								a = int.Parse(txtNumero1.Text);
								b = int.Parse(txtNumero2.Text);
								r = a / b;
								return r;
						}
						catch (Exception ex)
						{
								//podria guardar un registro de error en archivo.
								throw ex;
						}
				}
		}
}
