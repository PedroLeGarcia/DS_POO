﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            int x = 0, optionMenu;


            do
            {
                Console.WriteLine("****Menu**** \n 1 - Cadastrar carro \n 2 - Cadastrar caminhão \n 3 - Consultar por placa \n 4 - Consultar caminhão por modelo/marca \n 5 - Consultar carro por cor \n 6 - Exibir todos os carros cadastrados \n 7 - Exibir todos os caminhões cadastrados \n 0 - Sair");
                menu = int.Parse(Console.ReadLine());
                switch (optionMenu)
                {

                    case 0:
                        Console.WriteLine("Deseja mesmo sair? [1 - sim/2- não]");
                        x = int.Parse(Console.ReadLine());
                        optClose(x);
                        break;
                    case 1:
                        caso1(x);
                        x = 2;
                        Console.Clear();
                        break;
                    case 2:
                        caso2(x);
                        x = 2;
                        Console.Clear();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        x = 2;
                        Console.Clear();
                        break;
                    case 6:
                        caso6();
                        x = 2;
                        Console.Clear();
                        break;
                };
            } while (x == 2);
            Console.ReadKey();


        }
        static int optClose(int n)
        {
            if (n == 1)
            {
                Console.Clear();
                Console.WriteLine("Uma pena, volte sempre :p");
            }
            else
            {
                Console.Clear();
                n = 2;
            }
            return n;

        }
        static int caso1(int n)
        {
            Console.Clear();
            for (int x = 0; x < 300; x++)
            {
                string modelo, fabricante, cor;
                int ano, nr_portas;
                int a = 0;
                Console.WriteLine("Digite o modelo do seu caminhão: ");
                modelo = Console.ReadLine();
                Console.WriteLine("Digite o/a fabricante do seu caminhão: ");
                fabricante = Console.ReadLine();
                Console.WriteLine("Digite o ano do veículo: ");
                ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cor do seu caminhão: ");
                cor = Console.ReadLine();
                Console.WriteLine("Digite o número de portas do seu veículo: ");
                nr_portas = int.Parse(Console.ReadLine());

                if (a == 2)
                {
                    break;
                }
            }
            n = 2;
            return n;
        }
        static int caso2(int n)
        {
            Console.Clear();
            for (int x = 0; x < 300; x++)
            {
                string modelo, fabricante, cor;
                int ano, nr_portas;
                int a = 0;
                Console.WriteLine("Digite o modelo do seu caminhão: ");
                modelo = Console.ReadLine();
                Console.WriteLine("Digite o/a fabricante do seu caminhão: ");
                fabricante = Console.ReadLine();
                Console.WriteLine("Digite o ano do veículo: ");
                ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cor do seu caminhão: ");
                cor = Console.ReadLine();
                Console.WriteLine("Digite o número de portas do seu veículo: ");
                nr_portas = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Deseja cadastrar outro caminhão? [1-Sim/2-Não]");
                a = int.Parse(Console.ReadLine());

                if (a == 2)
                {
                    break;
                }
            }
            n = 2;
            return n;
        }
        static void caso6()
        {
            int variavelcarroscadastrados = 0;
            for (int x = 0; x < 300; x++)
            {
                if (variavelcarroscadastrados != 0)
                {
                    Console.WriteLine("variaveldonomedoveiculo[x] \n variaveldomodelodoveiculo[x] \n variaveldoanodocarro[x] \n variaveldacordocarro[x] \n numerodeportasdocarro[x] \n variaveldaplaca[x]");
                }
            }
        }