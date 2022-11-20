using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class UtilidadesArreglos<T>
    {
        //Se usa "T", como una convecion, ya que viene de Type o tipo
        internal int CalcualrLongitudArray(T[] arreglo)
        {
            return arreglo.Length;
        }


        internal T? PrimerElementoOValorPorDefecto(T[] arreglo)
        {
            if (arreglo.Length == 0)
            {
                return default;
            }

            return arreglo[0];
        }
    }
}
