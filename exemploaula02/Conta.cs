using exemploaula02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploaula02
{
    public class Conta
    {
        public long Numero { get; set; }
        private double _saldo;
        public double Saldo { 
            get
            {
                return _saldo + Limite;
            }
            private set { _saldo = value; }
        }
        public static double Limite { get; set; }

    }
}
