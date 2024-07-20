using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcios
{
    internal class Datos
    {
        public struct UnidadFuncional
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Alias { get; set; }
            public string Propietario { get; set; }
            public decimal Saldo { get; set; }

            public UnidadFuncional(int id, string nombre, string alias, string propietario, decimal saldo)
            {
                ID = id;
                Nombre = nombre;
                Alias = alias;
                Propietario = propietario;
                Saldo = saldo;
            }
        }



        public struct Edificio
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public List<UnidadFuncional> UnidadesFuncionales { get; set; }
            public int CantUF { get; set; }

            public Edificio(int id, string nombre, string direccion, List<UnidadFuncional> unidadesFuncionales, int cantidadUF)
            {
                ID = id;
                Nombre = nombre;
                Direccion = direccion;
                UnidadesFuncionales = unidadesFuncionales;
                CantUF = cantidadUF; // para usar de índice
            }
        }

        
    }
}
