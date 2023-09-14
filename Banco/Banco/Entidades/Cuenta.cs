using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entidades
{
    public class Cuenta
    {
        public int Cbu { get; set; }
        public double Saldo { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public DateTime UltimoMovimiento { get; set; }

        public Cuenta(int cbu, double saldo, DateTime ultimoMovimiento, TipoCuenta tipoCuenta)
        {
            Cbu = cbu;
            Saldo = saldo;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = ultimoMovimiento;
         
        }
    }
}
