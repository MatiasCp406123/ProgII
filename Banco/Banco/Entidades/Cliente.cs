using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public List<Cuenta> Cuentas { get; set; }

        public Cliente()
        {
            Cuentas = new List<Cuenta>();
        }
        public void AgregarCuenta(Cuenta cuenta)
        {
            Cuentas.Add(cuenta);
        }
        public void QuitarDetalle(int posicion)
        {
            Cuentas.RemoveAt(posicion);
        }

    }
}
