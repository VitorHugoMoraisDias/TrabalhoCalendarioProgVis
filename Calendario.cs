using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1p
{
    public class Calendario
    {
        public Byte Mes { get; set; }
        public UInt16 Ano { get; set; }

        //Verificar o mês com os valores máximos e mínimos fornecidos pelo DateTime, e o auxílio de um Boolean :
        public bool isMesValido()
        {
            return ((Mes >= DateTime.MinValue.Month) && (Mes <= DateTime.MaxValue.Month));
        }

        // Verificar o ano, utilizando os mesmos métodos efetuados no mês, porém, trocando o método DateTime de 'Month' para 'Year' :
        public bool isAnoValido()
        {
            return ((Ano >= DateTime.MinValue.Year) && (Ano <= DateTime.MaxValue.Year));
        }
        //gerar calendário
        public string GerarCalendario()
        {

            // para a construção do calendário, será necessário criar um modelo:
            // criação do cabeçalho utilizando um dia fornecido manualmente '1', para o funcionamento do mesmo.
            DateTime calendario = new DateTime(Ano, Mes, 1);
            string molde = $"{calendario.ToString("MMMM")} de {calendario.Year}";
            //Criação do modelo de referência para a segunda parte do cabeçalho
            string result = String.Format("\n\n" + molde.PadLeft(17 + molde.Length / 7, ' ') + "\n");

            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗\n");
            Console.WriteLine("║---[D]-----[S]------[T]------[Q]------[Q]------[S]-----[S] ║ \n");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");

            //Método 'For' que irá gerar um loop para os dias da semana que não irão conter o dia '1' no início do calendário:
            Int16 comparador = Convert.ToInt16(DateTime.DaysInMonth(Ano, Mes));
            for (int i = 0; i < (int)calendario.DayOfWeek; i++)
                Console.Write("         ");
            for (int i = 1; i <= comparador; i++)
            {
                DateTime g = new DateTime(Ano, Mes, i);
                if (g.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }

                if (g.DayOfWeek == DayOfWeek.Monday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }

                if (g.DayOfWeek == DayOfWeek.Tuesday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }

                if (g.DayOfWeek == DayOfWeek.Wednesday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }

                if (g.DayOfWeek == DayOfWeek.Thursday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }

                if (g.DayOfWeek == DayOfWeek.Friday)
                {
                    if (i < 10)
                        Console.Write("    " + i + "    ");
                    else
                        Console.Write("   " + i + "    ");
                }


                if (g.DayOfWeek == DayOfWeek.Saturday)
                {
                    if (i < 10)
                        Console.WriteLine("    " + i);
                    else
                        Console.WriteLine("   " + i);
                }
            }
            Console.WriteLine("\n═══════════════════════════════════════════════════════════\n");
            return result;
        }
    }
}
    
