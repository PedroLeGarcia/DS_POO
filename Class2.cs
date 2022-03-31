using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class carro
    {
        public int cp_portamala;
        public bool bagageiro;
        public string farol;

        public carro(int cp_portamala, bool bagageiro, string farol)
        {
            this.cp_portamala = cp_portamala;
            this.bagageiro = bagageiro;
            this.farol = farol;

        }
    }
}
