using System;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roger
{
    class veiculo
    {
        public string modelo;
        public string fabricante;
        public int ano;
        public string cor;
        public int nr_portas;

        //sem paremetro
        public veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.nr_portas = 0;
        }

        //com paremetro
        public veiculo(string modelo, string fabricante, int ano, string cor, int nr_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.nr_portas = nr_portas;

        }
        public string Modelo{
            get{ return modelo; }
            set{ modelo = value; }
     }
        public string Fabricante{
            get { return fabricante; }
            set { fabricante = value; }
        }
        public int Ano{
            get { return ano; }
            set { ano = value; }
        }
        public string Cor{
            get { return cor; }
            set { cor = value; }
        }
        public int NrPortas{
            get { return nr_portas; }
            set { nr_portas = value; }
        }
    }
}
