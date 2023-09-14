using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class TipoCuenta
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public TipoCuenta()
        {
            Id = 0;
            Nombre = string.Empty;
        }
        public TipoCuenta(int id)
        {

        
            Id = id;
        
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
