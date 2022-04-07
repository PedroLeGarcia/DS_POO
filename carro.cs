using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roger
{
    class carro
    {
        public int cp_portamala;
        public bool bagageiro;
        public string farol;

        public carro()
        {
            this.cp_portamala = 0;
            this.bagageiro = false;
            this.farol = null;
        }
        public carro(int cp_portamala, bool bagageiro, string farol)
        {
            this.cp_portamala = cp_portamala;
            this.bagageiro = bagageiro;
            this.farol = farol;

        }
        public int CpPortamala{
            get { return cp_portamala; }
            set { cp_portamala = value; }
        }
        public bool Bagageiro{
            get { return bagageiro; }
            set { bagageiro = value; }
        }
        public string Farol{
            get { return farol; }
            set { farol = value; }
        }
    }
}