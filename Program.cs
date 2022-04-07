using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roger
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            carro[] p = new carro[TAM];
            caminhao[] c = new caminhao[TAM];
            int y = 0;
            int op = 0;

            do
            {
                op = menu();
                switch (op)
                {
                    case 1: p[y++] = CadastrarCarro(); break;

                    case 2: c[y++] = CadastrarCaminhao(); break;

                    case 3: ConsultarPlaca(p, c, y); break;

                    case 4: CaminhaoModelo(c, y); break;

                    case 5: CarroCor(p, y); break;

                    case 6: ExibirCarro(p, y); break;

                    case 7: ExibirCaminhao(c, y); break;

                    case 0: break;

                    default: Console.WriteLine("Opção invalida!"); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.Write("Digite algo para continuar");
                Console.ReadKey();
            } while (op != 0);
        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("***Menu Principal - Veiculos***\n");
            Console.WriteLine("1 - Cadastrar carro");
            Console.WriteLine("2 - Cadastrar caminhão");
            Console.WriteLine("3 - Consultar por placa");
            Console.WriteLine("4 - Consultar caminhão pelo modelo/marca");
            Console.WriteLine("5 - Consultar carro pela cor");
            Console.WriteLine("6 - Exibir todos os carros cadastrados");
            Console.WriteLine("7 - Exibir todos os caminhões cadastrados");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("\n Digite uma opção: ");
            return int.Parse(Console.ReadLine());
        } 
        public static carro CadastrarCarro()
        {
            Console.Clear();
            Console.Write("Digite a capacidade do porta-mala:"); int n = int.Parse(Console.ReadLine());
            Console.Write("Digite o bagageiro:"); bool i = bool.Parse(Console.ReadLine());
            Console.Write("Digite o farol do seu carro:"); string a = Console.ReadLine();
            char s = char.Parse(Console.ReadLine());

            return new carro(n, i, a, s);
        }
    }
}
