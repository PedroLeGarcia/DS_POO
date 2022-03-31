using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class veiculo
    {
        public string modelo;
        public string fabricante;
        public int ano;
        public string cor;
        public int nr_portas;

        public veiculo(string modelo, string fabricante, int ano, string cor, int nr_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.nr_portas = nr_portas;

        }
    }
}
