using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sentido;
            int localizacao_x = 0;
            int localizacao_y = 0;

            Console.WriteLine("----- TUPINIQUIM I -----\n");

            Console.WriteLine("COORDENADAS:\n\nCanto superior direito (5,5)\nCanto inferior esquerdo (0,0)\n");

            Console.WriteLine("SENTIDOS:\n\n[N] Norte\n[S] Sul\n[L] Leste\n[O] Oeste\n");

            Console.WriteLine("COMANDOS:\n\n[E] Virar 90° a esquerda\n[D] Virar 90° a direita\n[M] Mover\n");

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Iniciando entrada de dados para comando do " + i + "° robô...");

                Console.WriteLine("\nInforme o sentido: ");
                sentido = char.Parse(Console.ReadLine());

                Console.WriteLine("Informe localização eixo x: ");
                localizacao_x = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe localização eixo y: ");
                localizacao_y = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o comando do " + i + "° robô:");
                string comando = Console.ReadLine();

                char[] instrucoes = comando.ToCharArray();

                for (int posicao = 0; posicao < instrucoes.Length; posicao++)
                {
                    if (instrucoes[posicao] == 'M')
                    {
                        if (sentido == 'N')
                            localizacao_y++;
                        else if (sentido == 'S')
                            localizacao_y--;
                        else if (sentido == 'L')
                            localizacao_x++;
                        else if (sentido == 'O')
                            localizacao_x--;
                    }
                    if (instrucoes[posicao] == 'E')
                    {
                        if (sentido == 'O')
                            localizacao_y--;
                        else if (sentido == 'L')
                            localizacao_x++;
                        else if (sentido == 'S')
                            localizacao_y--;
                        else if (sentido == 'N')
                            localizacao_y++;
                    }
                    if (instrucoes[posicao] == 'D')
                    {
                        if (sentido == 'L')
                            localizacao_x++;
                        else if (sentido == 'S')
                            localizacao_y--;
                        else if (sentido == 'O')
                            localizacao_x--;
                        else if (sentido == 'N')
                            localizacao_y++;
                    }

                    Console.WriteLine("\nPosição final " + i + "° robô: " + localizacao_x + "" + localizacao_y + "" + sentido);
                    Console.WriteLine("_____________________________________________________");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}

