using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consorcios
{
    internal class Datos
    {
        public struct UnidadFuncional { 
            public Int32 IdUF; 
            public String Alias;
            public String Propietario;
            public String Ocupante;
            public Int32 piso;
            public String Unidad;
            public Decimal Saldo;
            public Boolean ExpB;
        }

        public class Consorcio
        {
            public Int32 IndEdif;
            public Int32 CantidadUF;
            public String Alias;
            public String Direccion;
            public String Categoria;
            public List<UnidadFuncional> UnidadesFuncionales  = new List<UnidadFuncional>();
        }

        
        public static Int32 IndEdifTotal;
        public static UnidadFuncional[] Edificio = new UnidadFuncional[100]; // Edificio = lista de UF
        public static Consorcio[] Edificios = new Consorcio[100];     // Edificios = lista de Consorcios
    }
}
