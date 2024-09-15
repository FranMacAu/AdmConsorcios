using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Consorcios.Datos;

namespace Consorcios
{
    internal class Datos
    {
        
        ///////////////     UNIDADES FUNCIONALES    //////////////////////
        
        public struct RegUnidadFuncional
        {
            public int ID;
            public int IDEdificio;
            public string Nombre;
            public string Alias;
            public string Propietario;
            public decimal Saldo;
            public bool ExpA;
            public bool ExpB;
            public bool ExpC;

        }

        // vector de UFs
        public static RegUnidadFuncional[] UnidadesFuncionales = new RegUnidadFuncional[1000];
        //Indice de UFs
        public static Int32 INDUF;

        public void CrearUF(int id, int idEdificio, string nombre, string alias, string propietario, decimal saldo, bool expA, bool expB, bool expC)
        {
            UnidadesFuncionales[INDUF].ID = id;
            UnidadesFuncionales[INDUF].IDEdificio = idEdificio;
            UnidadesFuncionales[INDUF].Nombre = nombre;
            UnidadesFuncionales[INDUF].Alias = alias;
            UnidadesFuncionales[INDUF].Propietario = propietario;
            UnidadesFuncionales[INDUF].Saldo = saldo;
            UnidadesFuncionales[INDUF].ExpA = expA;
            UnidadesFuncionales[INDUF].ExpB = expB;
            UnidadesFuncionales[INDUF].ExpC = expC;
            INDUF++;
        }


        ///////////////     CONSORCIOS    //////////////////////
        

        public struct RegConsorcio
        {
            public int ID;
            public string Nombre;
            public string Direccion;
            public Decimal ExpA;
            public Decimal ExpB;    //categorías de expensas para separar por ej cocheras, ascensor
            public Decimal ExpC;
            public int CantUF;
            
        }

        //Vector de consorcios
        static public RegConsorcio[] Consorcios = new RegConsorcio[100];
        // Indice de consorcios
        public static Int32 INDCons = 0;


        public static void CrearConsorcio(string nombre, string direccion, int cantUF)
        {
            if (INDCons < Consorcios.Length)
            {
                Consorcios[INDCons].ID = INDCons;
                Consorcios[INDCons].Nombre = nombre;
                Consorcios[INDCons].Direccion = direccion;
                Consorcios[INDCons].CantUF = cantUF;
                Consorcios[INDCons].ExpA = 0;
                Consorcios[INDCons].ExpB = 0;
                Consorcios[INDCons].ExpC = 0;
                INDCons++;

                MessageBox.Show("Dato cargado");

            }
            else { MessageBox.Show("No hay más espacio para consorcios"); }

        }


    }
}
