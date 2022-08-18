using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiparadigma {
    class Rango {
        private int nInferior;

        private int nSuperior;

        public int Inferior {
            get{ return nInferior; }
            set { nInferior = value; }
        }

        public int Superior {
            get { return nSuperior; }
            set { nSuperior = value; }
        }

        public Rango(int nInferior, int nSuperior) {
            this.nInferior = nInferior;
            this.nSuperior = nSuperior;
        }
    }
}
