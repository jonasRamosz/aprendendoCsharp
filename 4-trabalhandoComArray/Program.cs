using System;

class Programa
{
    static void Main(string[] args)
    {
        buscaNome();
        void buscaNome()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° nome ! : ");
                nomes[i] = Console.ReadLine();
            }
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Qual o nome deseja buscar?");
            string buscador = Console.ReadLine();

            foreach (string nome in nomes)
            {

                if (buscador.Equals(nome))
                {
                    Console.WriteLine("Nome encontrado");
                    Console.WriteLine($"O nome encontrado foi {nome}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nome nao encontrado");
                    break;

                }
            }

        }


    }


}  