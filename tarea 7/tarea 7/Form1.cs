using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_7.Clases;

namespace tarea_7
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        int[] resultado1, resultado2, resultado3;

        public Form1()
        {
            InitializeComponent();
        }

        /*private void buttonArreglo_Click(object sender, EventArgs e)
         {
             int[] arreglo = new int[5];
             arreglo[0] = 1;
             arreglo[1] = 8;
             arreglo[2] = 16;
             arreglo[3] = 36;
             arreglo[4] = 1;
                ClsArreglos ObjArreglos = new ClsArreglos;
             ClsArreglos ObjArreglo = new ClsArreglos(arreglo);

             int[] resultado = ObjArreglo.MetodoBurbuja();


             foreach(int arreglos in resultado)
             {
                 listBoxResultado.Items.Add(arreglos);
             }

         }*/


        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\jeant\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);

                textBoxContenido.Text = resultado;
            }


        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[] Orden = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {

                    string[] datos = linea.Split(';');
                    Orden[contador - 1] = datos[1];
                }
                contador++;
            }

                ClsArreglos ObjArreglo = new ClsArreglos(Orden);
                    string[] resultado = ObjArreglo.MetodoBurbujaNombres();
                    for (int i = 0; i < resultado.Length; i++)
                    {
                        listBoxResultado.Items.Add(resultado[i]);
                    }

        }
        private void buttonProm_Click(object sender, EventArgs e)
        {

            double Prom1 = 0, Prom2 = 0, Prom3 = 0;

            for (int i = 0; i < resultado1.Length; i++)
            {
                Prom1 += resultado1[i];
                Prom2 += resultado2[i];
                Prom3 += resultado3[i];
            }
            Prom1 /= resultado1.Length;
            Prom2 /= resultado1.Length;
            Prom3 /= resultado1.Length;

            string prom1 = Convert.ToString(Math.Round(Prom1, 2));
            string prom2 = Convert.ToString(Math.Round(Prom2, 2));
            string prom3 = Convert.ToString(Math.Round(Prom3, 2));

            int notamin1, notamin2, notamin3;
            int notamax1, notamax2, notamax3;

            notamin1 = resultado1[0];
            notamin2 = resultado2[0];
            notamin3 = resultado3[0];
            notamax1 = resultado1.Length - 1;
            notamax2 = resultado2.Length - 1;
            notamax3 = resultado3.Length - 1;

            labelpromedio1.Text = $"parcial 1: Promedio {prom1} N. mayor {notamax1} N. Minima {notamin1}";
            labelpromedio2.Text = $"parcial 2: Promedio {prom2} N. mayor {notamax2} N. Minima {notamin2}";
            labelpromedio3.Text = $"parcial 3: Promedio {prom3} N. mayor {notamax3} N. Minima {notamin3}";
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int[] NotasOrdenParcial1 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial2 = new int[ArregloNotas.Length - 1];
            int[] NotasOrdenParcial3 = new int[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {

                    string[] datos = linea.Split(';');
                    NotasOrdenParcial1[contador - 1] = int.Parse(datos[2]);
                    NotasOrdenParcial2[contador - 1] = int.Parse(datos[3]);
                    NotasOrdenParcial3[contador - 1] = int.Parse(datos[4]);
                }
                contador++;
            }
            ClsArreglos ObjNotas1 = new ClsArreglos(NotasOrdenParcial1);
            ClsArreglos ObjNotas2 = new ClsArreglos(NotasOrdenParcial2);
            ClsArreglos ObjNotas3 = new ClsArreglos(NotasOrdenParcial3);

            resultado1 = ObjNotas1.MetodoBurbujaNotas1();
            resultado2 = ObjNotas2.MetodoInsercionNotas2();
            resultado3 = ObjNotas3.MetodoSeleccionNotas3();

            for (int i = 0; i < resultado1.Length; i++)
            {
                listBoxResultado.Items.Add($"Nota 1> {resultado1[i]}\tNota 2> {resultado2[i]}\tNota 3> {resultado3[i]}");
            }
        }

    }
}
