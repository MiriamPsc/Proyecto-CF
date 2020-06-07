using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P
{
    interface IDeshabilitar
    {
        bool Limpiar();
    }

    class Deshab : IDeshabilitar
    {
        bool IDeshabilitar.Limpiar()
        {
            return false;
        }
    }

    class Limpieza : IDeshabilitar
    {
       bool IDeshabilitar.Limpiar()
        {
            return true; }
    }
}
