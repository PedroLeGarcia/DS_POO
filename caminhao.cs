using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roger
{
    class caminhao
    {
        public int nr_eixos;
        public double cp_maxima_carga;
        public double peso_vazio;

        public caminhao()
        {
            this.nr_eixos = 0;
            this.cp_maxima_carga = 0.0;
            this.peso_vazio = 0.0;
        }
        public caminhao(int nr_eixos, double cp_maxima_carga, double peso_vazio)
        {
            this.nr_eixos = nr_eixos;
            this.cp_maxima_carga = cp_maxima_carga;
            this.peso_vazio = peso_vazio;
        }
        public int NrEixos{
            get { return nr_eixos; }
            set { nr_eixos = value; }
        }
        public double CargaMaxima{
            get { return cp_maxima_carga; }
            set { cp_maxima_carga = value; }
        }
        public double PesoVazio{
            get { return peso_vazio; }
            set { peso_vazio = value; }
        }
    }
}