using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class caminhao
    {
        public int nr_eixos;
        public double cp_maxima_carga;
        public double peso_vazio;

        public caminhao(int nr_eixos, double cp_maxima_carga, double peso_vazio)
        {
            this.nr_eixos = nr_eixos;
            this.cp_maxima_carga = cp_maxima_carga;
            this.peso_vazio = peso_vazio;
        }

    }
}
