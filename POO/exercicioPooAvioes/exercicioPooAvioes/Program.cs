using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooAvioes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            List<Aviao> avioes = new List<Aviao>();
            while (contador != 6)
            {
                Console.WriteLine("Digite 1 para cadastrar Aviao");
                Console.WriteLine("Digite 2 para cadastrar um Voo");
                Console.WriteLine("Digite 3 para efetuar uma reserva");
                Console.WriteLine("Digite 4 para cancelar uma reserva");
                Console.WriteLine("Digite 5 para listar");
                Console.WriteLine("Digite 6 para sair");
                contador = int.Parse(Console.ReadLine());

                if (contador == 1)
                {
                    Console.WriteLine("Digite o prefixo do aviao");
                    string prefixo = Console.ReadLine();
                    Console.WriteLine("Digite o modelo do avião");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("Digite o fabricante do avião");
                    string fabricante = Console.ReadLine();
                    avioes.Add(new Aviao(prefixo, modelo, fabricante));
                    Console.Clear();
                }
                else if (contador == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o prefixo do avião");
                    Console.WriteLine(avioes[0].prefixo);
                    Console.WriteLine(avioes[1].prefixo);
                    Console.WriteLine(avioes[2].prefixo);
                    string nomeAviao = Console.ReadLine();
                    int nrAviao;
                    if (nomeAviao == avioes[0].prefixo)
                    {
                        nrAviao = 0;
                    }
                    else if (nomeAviao == avioes[1].prefixo)
                    {
                        nrAviao = 1;
                    }
                    else if (nomeAviao == avioes[2].prefixo)
                    {
                        nrAviao = 2;
                    }
                    else
                    {
                        throw new Exception("Entrada inválida");
                    }
                    Console.WriteLine(
                        "0 - {0} - {1}",
                        avioes[nrAviao].Voos[0].origem,
                        avioes[nrAviao].Voos[0].destino
                    );
                    Console.WriteLine(
                        "1 - {0} - {1}",
                        avioes[nrAviao].Voos[1].origem,
                        avioes[nrAviao].Voos[1].destino
                    );
                    Console.WriteLine(
                        "2 - {0} - {1}",
                        avioes[nrAviao].Voos[2].origem,
                        avioes[nrAviao].Voos[2].destino
                    );
                    Console.WriteLine(
                        "3 - {0} - {1}",
                        avioes[nrAviao].Voos[3].origem,
                        avioes[nrAviao].Voos[3].destino
                    );
                    Console.WriteLine(
                        "4 - {0} - {1}",
                        avioes[nrAviao].Voos[4].origem,
                        avioes[nrAviao].Voos[4].destino
                    );
                    int nrVoo = int.Parse(Console.ReadLine());
                    avioes[nrAviao].CadastrarVoo(nomeAviao, nrVoo);
                    Console.Clear();
                }
                else if (contador == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o prefixo do avião");
                    Console.WriteLine(avioes[0].prefixo);
                    Console.WriteLine(avioes[1].prefixo);
                    Console.WriteLine(avioes[2].prefixo);
                    string nomeAviao = Console.ReadLine();
                    int aux = 0;
                    foreach (Aviao p in avioes)
                    {
                        if (nomeAviao == p.prefixo)
                        {
                            foreach (Voo v in p.VoosCadastrado)
                            {
                                Console.WriteLine("{0} - {1} - {2}", aux, v.origem, v.destino);
                                aux++;
                            }
                            int vooEscolhido = int.Parse(Console.ReadLine());
                            try
                            {
                                if (p.VoosCadastrado[vooEscolhido].EfetuarReserva())
                                {
                                    Console.WriteLine("Sua reserva foi efetuada com sucesso");
                                }
                                else
                                {
                                    Console.WriteLine("Esse voo está lotado");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
                }
                else if (contador == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o prefixo do avião");
                    Console.WriteLine(avioes[0].prefixo);
                    Console.WriteLine(avioes[1].prefixo);
                    Console.WriteLine(avioes[2].prefixo);
                    string nomeAviao = Console.ReadLine();
                    int aux = 0;
                    foreach (Aviao p in avioes)
                    {
                        if (nomeAviao == p.prefixo)
                        {
                            foreach (Voo v in p.VoosCadastrado)
                            {
                                Console.WriteLine("{0} - {1} - {2}", aux, v.origem, v.destino);
                                aux++;
                            }
                            int vooEscolhido = int.Parse(Console.ReadLine());
                            if (p.VoosCadastrado[vooEscolhido].CancelarReserva())
                            {
                                Console.WriteLine("Sua reserva foi cancelada com sucesso");
                            }
                            else
                            {
                                Console.WriteLine("Você não tinha reserva nesse voo");
                            }
                        }
                    }
                }
                else if(contador == 5)
                {
                    Console.WriteLine("Digite o prefixo do avião");
                    Console.WriteLine(avioes[0].prefixo);
                    Console.WriteLine(avioes[1].prefixo);
                    Console.WriteLine(avioes[2].prefixo);
                    string nomeAviao = Console.ReadLine();
                    foreach (Aviao p in avioes)
                    {
                        if (nomeAviao == p.prefixo)
                        {
                            Console.Clear();
                            Console.WriteLine("Escolha uma opção de listagem de voo: ");
                            Console.WriteLine("0 - Por data");
                            Console.WriteLine("1 - Por numero do voo");
                            Console.WriteLine("2 - Por origem");
                            int resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 0:
                                    Console.WriteLine("Voos disponniveis para as datas: ");
                                    foreach (Voo v in p.VoosCadastrado)
                                    {
                                        Console.WriteLine(v.dataVoo);
                                    }
                                    break;
                                case 1:
                                    Console.WriteLine("Numeros dos voos disponiveis: ");
                                    foreach (Voo v in p.VoosCadastrado)
                                    {
                                        Console.WriteLine(v.nrVoo);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Origem dos voos disponiveis: ");
                                    foreach (Voo v in p.VoosCadastrado)
                                    {
                                        Console.WriteLine(v.origem);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                else if(contador > 6)
                {
                    break;
                }
            }
        }
    }
}
