/* Desenvolvido por Briotza (Ciano Meliunas) */
namespace MenuVetores_Ciano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.WriteLine("Menu de Vetores");
                Console.WriteLine("[1] Dia/Mes");
                Console.WriteLine("[2] Estados");
                Console.WriteLine("[3] Extenso");
                Console.WriteLine("[4] Finalizar Programa");

                Console.WriteLine("Digite sua opção:");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            Diames();
                            break;
                        }
                    case 2:
                        {
                            Estados();
                            break;
                        }
                    case 3:
                        {
                            Extenso();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Tchau");
                            break;
                        }
                }
            } while (opc != 4);
        }

        static void Diames()
        {
            string consulta, resposta;

            int nsemana, nmes;

            bool achou;

            string[] semana = { "", "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            string[] mes = { "", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };



            do
            {
                Console.Clear();

                Console.WriteLine("Deseja consultar semana ou mês?(semana/mês) ");

                consulta = Console.ReadLine();



                achou = false;


                if (consulta == "semana")

                {

                    Console.WriteLine("Digite um número de 1 a 7: ");
                    nsemana = int.Parse(Console.ReadLine());


                    for (int i = 0; i < 8; i++)
                    {
                        if (nsemana == i)

                        {
                            Console.WriteLine("Esse número corresponde a " + semana[nsemana]);

                            achou = true;

                            break;


                        }
                    }
                }
                else if (consulta == "mês" || consulta == "mes")

                {
                    Console.WriteLine("Digite um número de 1 a 12: ");
                    nmes = int.Parse(Console.ReadLine());


                    for (int i = 0; i < 13; i++)
                    {
                        if (nmes == i)

                        {
                            Console.WriteLine("Esse número corresponde a " + mes[nmes]);

                            achou = true;

                            break;

                        }
                    }
                }

                if (achou == false)

                {
                    Console.WriteLine("Número Fora da Faixa");

                }

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }



        static void Estados()
        {
            string[,] estado = new string[27, 2];

            string texto;

            string resposta;

            bool achou;

            do
            {

                Console.Clear();
                estado[0, 0] = "AC"; estado[0, 1] = "Acre";
                estado[1, 0] = "AL"; estado[1, 1] = "Alagoas";
                estado[2, 0] = "AP"; estado[2, 1] = "Amapá";
                estado[3, 0] = "AM"; estado[3, 1] = "Amazonas";
                estado[4, 0] = "BA"; estado[4, 1] = "Bahia";
                estado[5, 0] = "CE"; estado[5, 1] = "Ceará";
                estado[6, 0] = "ES"; estado[6, 1] = "Espírito Santo";
                estado[7, 0] = "GO"; estado[7, 1] = "Goiás";
                estado[8, 0] = "MA"; estado[8, 1] = "Maranhão";
                estado[9, 0] = "MT"; estado[9, 1] = "Mato Grosso";
                estado[10, 0] = "MS"; estado[10, 1] = "Mato Grosso do Sul";
                estado[11, 0] = "MG"; estado[11, 1] = "Minas Gerais";
                estado[12, 0] = "PA"; estado[12, 1] = "Pará";
                estado[13, 0] = "PB"; estado[13, 1] = "Paraíba";
                estado[14, 0] = "PR"; estado[14, 1] = "Paraná";
                estado[15, 0] = "PE"; estado[15, 1] = "Pernambuco";
                estado[16, 0] = "PI"; estado[16, 1] = "Piauí";
                estado[17, 0] = "RJ"; estado[17, 1] = "Rio de Janeiro";
                estado[18, 0] = "RN"; estado[18, 1] = "Rio Grande do Norte";
                estado[19, 0] = "RS"; estado[19, 1] = "Rio Grande do Sul";
                estado[20, 0] = "RO"; estado[20, 1] = "Rondônia";
                estado[21, 0] = "RR"; estado[21, 1] = "Roraima";
                estado[22, 0] = "SC"; estado[22, 1] = "Santa Catarina";
                estado[23, 0] = "SP"; estado[23, 1] = "São Paulo";
                estado[24, 0] = "SE"; estado[24, 1] = "Sergipe";
                estado[25, 0] = "TO"; estado[25, 1] = "Tocantins";
                estado[26, 0] = "DF"; estado[26, 1] = "Distrito Federal";


                Console.WriteLine("Digite um estado ou a sigla de um estado(Ex: São Paulo ou SP): ");

                texto = Console.ReadLine();


                achou = false;

                for (int i = 0; i < 27; i++)
                {
                    if (texto == estado[i, 0])
                    {
                        Console.WriteLine(texto + " corresponde a " + estado[i, 1]);

                        achou = true;

                        break;

                    }
                    else if (texto == estado[i, 1])
                    {
                        Console.WriteLine(texto + " corresponde a " + estado[i, 0]);

                        achou = true;

                        break;

                    }
                }

                if (achou == false)
                {
                    Console.WriteLine("Sigla ou estado inválido");

                }

                Console.WriteLine("Deseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");
        }

        static void Extenso()
        {
            string[] unidade = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezesete", "dezoito", "dezenove" };

            string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

            string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            int n, nd, ne, nc, ncd;



            string resposta;



            do
            {
                Console.Clear();

                Console.WriteLine("Digite um número de 0 a 1000: ");
                n = int.Parse(Console.ReadLine());


                if (n < 0 || n > 1000)

                {
                    Console.WriteLine("Número fora da faixa");

                }

                else if (n < 20)

                {
                    Console.Write(unidade[n]);

                }

                else if (n < 100)

                {
                    ne = n / 10;

                    nd = n % 10;

                    Console.Write(dezena[ne]);

                    if (nd > 0)

                    {
                        Console.Write(" e " + unidade[nd]);

                    }
                }

                else if (n == 100)

                {
                    Console.WriteLine("cem");

                }

                else if (n > 100 && n < 1000)

                {
                    nc = n / 100;

                    ncd = n % 100;

                    Console.Write(centena[nc]);

                    if (ncd > 0 && ncd < 20)

                    {
                        Console.Write(" e " + unidade[ncd]);

                    }

                    else if (ncd > 20)

                    {
                        ne = ncd / 10;

                        nd = ncd % 10;

                        Console.Write(" e " + dezena[ne]);

                        if (nd > 0)

                        {
                            Console.Write(" e " + unidade[nd]);

                        }
                    }

                }

                else if (n == 1000)

                {
                    Console.WriteLine("mil");

                }
                Console.WriteLine("\nDeseja repetir?(s|n) ");
                resposta = Console.ReadLine();
            } while (resposta.ToUpper() == "S" || resposta.ToUpper() == "SIM");

        }
    }
}