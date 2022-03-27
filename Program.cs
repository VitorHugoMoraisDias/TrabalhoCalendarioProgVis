using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp1p
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calendario c = new Calendario();
            //Início
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║      Bem vindo ào calendário automático!!!            ║");
            Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
            Console.WriteLine("║  - Inserindo apenas o ano e o mês desejados, você     ║");
            Console.WriteLine("║ poderá descobrir quantos são os dias do mês, e como   ║");
            Console.WriteLine("║ estão distribuídos!                                   ║");
            Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
            Console.WriteLine("║          [Aperte Enter para continuar...]             ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ReadLine();
            // Inserção do Ano, se o Ano estiver errado, será iniciado um loop através do '!c.isAnoValido()' 
            while (!c.isAnoValido())
            {
                short comparador = 0;//Criação de um comparador para o método 'TryParse'
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║ »Por favor, insira um ano, no calendário gregoriano:  ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");

                Int16.TryParse(Console.ReadLine(), out comparador);// Comparação padrão com o método 'TryParse'
                c.Ano = Convert.ToUInt16(comparador);
                //Caso 'c.isAnoValido()' não retorne um true....
                if (!c.isAnoValido())
                {
                    Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║         »Por favor, insira um valor válido para o ano...        ║");
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝\n");
                }
                    //e se reinicia o loop
            }

                //Inserção do Mês
                while (!c.isMesValido())
            {
                short comparador = 0;//Definição do método comparador para 0, pra que assim ocorra o funcionamento do loop;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║      [Insira um valor que corresponde a um Mês]       ║");
                Console.WriteLine("╠════════════╦═══════════════╦══════════════╦═══════════╣");
                Console.WriteLine("║1-Janeiro   | 2-Fevereiro   | 3-Março      | 4-Abril   ║");
                Console.WriteLine("║5-Maio      ║ 6-Junho       ║ 7-Julho      ║ 8-Agosto  ║");
                Console.WriteLine("║9-Setembro  |10-Outubro     |11-Novembro   |12-Dezembro║");
                Console.WriteLine("╚════════════╩═══════════════╩══════════════╩═══════════╝");

                Int16.TryParse(Console.ReadLine(), out comparador);// Comparação padrão com o método 'TryParse'
                c.Mes = Convert.ToByte(comparador);
                //Caso 'c.isMesValido()' não retorne um true....
                if (!c.isMesValido())
                Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║         »Por favor, insira um valor válido para o mês...        ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝\n");
                //e se reinicia o loop
            }
            Console.Clear();
                Console.WriteLine(c.GerarCalendario());

                                Console.WriteLine("\n╔═════════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║    »Aperte Enter para ver o nome completo da equipe:        ║");
                                Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("╔════════════════════════════════╗");
                                Console.WriteLine("║♠           Equipe:            ♠║");
                                Console.WriteLine("╠════════════════════════════════╣");
                                Console.WriteLine("║ -Ruth Nunes de Oliveira        ║");
                                Console.WriteLine("║ -Maria Beatriz Lopes Santiago  ║");
                                Console.WriteLine("║ -Vitor Hugo Morais Dias        ║");
                                Console.WriteLine("╚════════════════════════════════╝");
                                Console.ReadLine();
                    
                
            
        }
    }
}