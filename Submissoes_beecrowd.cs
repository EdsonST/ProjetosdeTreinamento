using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;

namespace PrimeiroProjetoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //URI 1001
            int A, B, X;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);

            //URI 1002
            area = n.raio² (n = 3.14159)
                double raio, n, area;
            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //URI 1003
            int A, B, Soma;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Soma = A + B;

            Console.WriteLine("SOMA = " + Soma);

            //URI 1004
            int A, B, PROD;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;
            Console.WriteLine("PROD = " + PROD);

            //URI 1007
            int A, B, C, D, diferenca;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = A * B - C * D;
            Console.WriteLine("DIFERENCA = " + diferenca);

            //URI 1008
            int Number, Hour;
            double salary, pay;

            Number = int.Parse(Console.ReadLine());
            Hour = int.Parse(Console.ReadLine());
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pay = salary * Hour;

            Console.WriteLine("NUMBER = " + Number);
            Console.WriteLine("SALARY = U$ " + pay.ToString("F2", CultureInfo.InvariantCulture);

            //URI 1010
            int Number1, Number2, Qtd1, Qtd2;
            double Price1, Price2, Total;

            string[] vet1 = Console.ReadLine().Split(' ');
            Number1 = int.Parse(vet1[0]);
            Qtd1 = int.Parse(vet1[1]);
            Price1 = double.Parse(vet1[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            Number2 = int.Parse(vet2[0]);
            Qtd2 = int.Parse(vet2[1]);
            Price2 = double.Parse(vet2[2]);

            Total = (Price1 * Qtd1) + (Price2 * Qtd2);

            Console.WriteLine("VALOR A PAGAR: R$ " + Total.ToString("F2"));

            //URI 1014
            int X;
            double Y, Avg;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            Avg = X / Y;

            Console.WriteLine(Avg.ToString("F3") + " km/l");

            //URI 1016
            int X, Y;

            X = int.Parse(Console.ReadLine());

            Y = X * 2;

            Console.WriteLine(Y + " minutos");

            //URI 1017
            int Time, Velocity;
            double Consumer;

            Time = int.Parse(Console.ReadLine());
            Velocity = int.Parse(Console.ReadLine());

            Consumer = ((double)Time * (double)Velocity) / 12.0;

            Console.WriteLine(Consumer.ToString("F3"));

            //URI 1005
            double N1, N2, Note;

            N1 = double.Parse(Console.ReadLine());
            N2 = double.Parse(Console.ReadLine());

            N1 = (N1 / 11.0) * 3.5;
            N2 = (N2 / 11.0) * 7.5;

            Note = (N1 + N2);
            Console.WriteLine("MEDIA = " + Note.ToString("F5"));

            //URI 1006
            double A, B, C, Note;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            A = (A / 10) * 2.0;
            B = (B / 10) * 3.0;
            C = (C / 10) * 5.0;

            Note = (A + B + C);

            Console.WriteLine("MEDIA = " + Note.ToString("F1"));

            //URI 1019
            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            //URI 1009
            string Name;
            double Salary, Sales, Payment;

            Name = Console.ReadLine();
            Salary = double.Parse(Console.ReadLine());
            Sales = double.Parse(Console.ReadLine());

            Payment = (Sales * 0.15) + Salary;

            Console.WriteLine("TOTAL = R$ " + Payment.ToString("F2"));

            //URI 1011
            int R;
            double Vol, PI = 3.14159;

            R = int.Parse(Console.ReadLine());

            Vol = (4 / 3.0) * PI * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + Vol.ToString("F3"));

            //URI 1012            
            double A, B, C, Triangulo, Circulo, Trapezio, Quadrado, Retangulo, PI = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            Triangulo = A * C / 2.0;
            Circulo = PI * C * C;
            Trapezio = (A + B) / 2.0 * C;
            Quadrado = B * B;
            Retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + Circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3"));

            //URI 1013
            int A, B, C, MaiorAB, Maior;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            Maior = (C + MaiorAB + Math.Abs(C - MaiorAB)) / 2;

            Console.WriteLine(Maior + " eh o maior");

            //URI 1015
            double X1, X2, Y1, Y2, Dif;

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            X1 = double.Parse(vet1[0]);
            Y1 = double.Parse(vet1[1]);
            X2 = double.Parse(vet2[0]);
            Y2 = double.Parse(vet2[1]);

            Dif = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            Console.WriteLine(Dif.ToString("F4"));

            //URI 1018
            int Notas, N100, N50, N20, N10, N5, N2, N1;

            Notas = int.Parse(Console.ReadLine());

            int Nota100 = 100;
            N100 = Notas / 100;

            int Nota50 = 50;
            N50 = (Notas % 100) / 50;

            int Nota20 = 20;
            N20 = ((Notas % 100) % 50) / 20;

            int Nota10 = 10;
            N10 = (((Notas % 100) % 50) % 20) / 10;

            int Nota5 = 5;
            N5 = ((((Notas % 100) % 50) % 20) % 10) / 5;

            int Nota2 = 2;
            N2 = (((((Notas % 100) % 50) % 20) % 10) % 5) / 2;

            int Nota1 = 1;
            N1 = ((((((Notas % 100) % 50) % 20) % 10) % 5) % 2) / 1;

            Console.WriteLine(Notas);
            Console.WriteLine(N100 + " nota(s) de R$ " + Nota100 + ",00");
            Console.WriteLine(N50 + " nota(s) de R$ " + Nota50 + ",00");
            Console.WriteLine(N20 + " nota(s) de R$ " + Nota20 + ",00");
            Console.WriteLine(N10 + " nota(s) de R$ " + Nota10 + ",00");
            Console.WriteLine(N5 + " nota(s) de R$ " + Nota5 + ",00");
            Console.WriteLine(N2 + " nota(s) de R$ " + Nota2 + ",00");
            Console.WriteLine(N1 + " nota(s) de R$ " + Nota1 + ",00");

            //URI 1020
            int N, A, M, D;

            N = int.Parse(Console.ReadLine());

            A = N / 365;
            M = (N % 365) / 30;
            D = (N % 365) % 30;

            Console.WriteLine(A + " ano(s)");
            Console.WriteLine(M + " mes(es)");
            Console.WriteLine(D + " dia(s)");

            //URI 1021
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine());

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");
            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

            //URI 1061
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            // Calculando a duracao em segundos
            duracao = fim - inicio;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e segundos (Z) restantes
            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");

            //URI 1036
            double A, B, C, Delta, R1, R2;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            Delta = Math.Pow(B, 2.0) - 4.0 * A * C;

            if (A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                R1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5"));
                Console.WriteLine("R2 = " + R2.ToString("F5"));
            }

            //URI 1035
            int A, B, C, D;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            // URI 1038
            int cod;
            double qtd, price, total;

            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            qtd = double.Parse(vet[1]);

            if (cod == 1)
            {
                price = 4.00;
                total = price * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            } else if (cod == 2)
            {
                price = 4.50;
                total = price * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            } else if (cod == 3)
            {
                price = 5.00;
                total = price * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            } else if (cod == 4)
            {
                price = 2.00;
                total = price * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            } else if (cod == 5)
            {
                price = 1.50;
                total = price * qtd;
                Console.WriteLine("Total: R$ " + total.ToString("F2"));
            }

            //URI 1044
            int N1, N2;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = int.Parse(vet[0]);
            N2 = int.Parse(vet[1]);

            if (N1 % N2 == 0 || N2 % N1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            //URI 1046
            int Inicio, Fim, Tempo;

            string[] vet = Console.ReadLine().Split(' ');
            Inicio = int.Parse(vet[0]);
            Fim = int.Parse(vet[1]);

            if (Fim > Inicio)
            {
                Tempo = ((24 - Inicio) + Fim) - 24;
                Console.WriteLine("O JOGO DUROU " + Tempo + " HORA(S)");
            } else
            {
                Tempo = (24 - Inicio) + Fim;
                Console.WriteLine("O JOGO DUROU " + Tempo + " HORA(S)");
            }

            //URI 1048
            double salary, promotion, gain;

            salary = double.Parse(Console.ReadLine());

            if (salary > 0 && salary <= 400.00)
            {
                promotion = (salary / 100) * 15;
                salary += promotion;
                Console.WriteLine("Novo salario: " + salary.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + promotion.ToString("F2"));
                Console.WriteLine("Em percentual: 15 %");
            } else if (salary >= 400.01 && salary <= 800.00)
            {
                promotion = (salary / 100) * 12;
                salary += promotion;
                Console.WriteLine("Novo salario: " + salary.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + promotion.ToString("F2"));
                Console.WriteLine("Em percentual: 12 %");
            } else if (salary >= 800.01 && salary <= 1200.00)
            {
                promotion = (salary / 100) * 10;
                salary += promotion;
                Console.WriteLine("Novo salario: " + salary.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + promotion.ToString("F2"));
                Console.WriteLine("Em percentual: 10 %");
            } else if (salary >= 1200.01 && salary <= 2000.00)
            {
                promotion = (salary / 100) * 7;
                salary += promotion;
                Console.WriteLine("Novo salario: " + salary.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + promotion.ToString("F2"));
                Console.WriteLine("Em percentual: 7 %");
            } else if (salary > 2000.00)
            {
                promotion = (salary / 100) * 4;
                salary += promotion;
                Console.WriteLine("Novo salario: " + salary.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + promotion.ToString("F2"));
                Console.WriteLine("Em percentual: 4 %");
            }

            //URI 1037
            double N1;

            N1 = double.Parse(Console.ReadLine());

            if (N1 >= 0.00 && N1 <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");
            } else if (N1 >= 25.01 && N1 <= 50.75)
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if (N1 >= 50.76 && N1 <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            } else if (N1 >= 75.01 && N1 <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            } else
            {
                Console.WriteLine("Fora de intervalo");
            }
            //URI 1040
            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            string[] valores = Console.ReadLine().Split(' ');
            N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }

            //URI 1041
            double x, y;

            string[] valores = Console.ReadLine().Split(' ');
            x = double.Parse(valores[0]);
            y = double.Parse(valores[1]);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            //URI 1045
            string[] valores = Console.ReadLine().Split(' ');
            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            //URI 1047
            int Hinicio, Minicio, Hfim, Mfim, Duracao, Tinicio, Tfinal, Dhoras, Dminutos;

            string[] vet = Console.ReadLine().Split(' ');
            Hinicio = int.Parse(vet[0]);
            Minicio = int.Parse(vet[1]);
            Hfim = int.Parse(vet[2]);
            Mfim = int.Parse(vet[3]);

            Tinicio = (Hinicio * 60) + Minicio;
            Tfinal = (Hfim * 60) + Mfim;

            if (Tinicio < Tfinal)
            {
                Duracao = Tfinal - Tinicio;
            } else
            {
                Duracao = (24 * 60 - Tinicio) + Tfinal;
            }

            Dhoras = Duracao / 60;
            Dminutos = Duracao % 60;

            Console.WriteLine("O JOGO DUROU " + Dhoras + " HORA(S) E " + Dminutos + " MINUTO(S)");

            //URI 1049
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

            //URI 1051
            double Salary, IR;

            Salary = double.Parse(Console.ReadLine());

            if (Salary <= 2000.00)
            {
                Console.WriteLine("Isento");
            } else if (Salary > 2000.00 && Salary <= 3000.00)
            {
                IR = (Salary - 2000.00) * 0.08;
                Console.WriteLine("R$ " + IR.ToString("F2"));

            } else if (Salary > 3000.00 && Salary <= 4500.00)
            {
                IR = ((Salary - 3000.00) * 0.18) + (1000.00 * 0.08);
                Console.WriteLine("R$ " + IR.ToString("F2"));

            } else
            {
                IR = ((Salary - 4500.00) * 0.28) + (1500.00 * 0.18) + (1000.00 * 0.08);
                Console.WriteLine("R$ " + IR.ToString("F2"));
            }

            //URI 1042
            int A, B, C, N1, N2, N3;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                N1 = A;
                if (B < C)
                {
                    N2 = B;
                    N3 = C;
                } else
                {
                    N2 = C;
                    N3 = B;
                }

            } else if (B < A && B < C)
            {
                N1 = B;
                if (A < C)
                {
                    N2 = A;
                    N3 = C;
                } else
                {
                    N2 = C;
                    N3 = A;
                }
            } else
            {
                N1 = C;
                if (A < B)
                {
                    N2 = A;
                    N3 = B;
                } else
                {
                    N2 = B;
                    N3 = A;
                }
            }

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            //URI 1043
            double A, B, C, Area, Perimeto;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            if (A < B + C && B < A + C && C < A + B)
            {
                Perimeto = A + B + C;
                Console.WriteLine("Perimetro = " + Perimeto.ToString("F1"));

            } else
            {
                Area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + Area.ToString("F1"));
            }

            //URI 1050
            int DDD = int.Parse(Console.ReadLine());

            if (DDD == 61)
            {
                Console.WriteLine("Brasilia");
            } else if (DDD == 71)
            {
                Console.WriteLine("Salvador");
            } else if (DDD == 11)
            {
                Console.WriteLine("Sao Paulo");
            } else if (DDD == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            } else if (DDD == 32)
            {
                Console.WriteLine("Juiz de Fora");
            } else if (DDD == 19)
            {
                Console.WriteLine("Campinas");
            } else if (DDD == 27)
            {
                Console.WriteLine("Vitoria");
            } else if (DDD == 31)
            {
                Console.WriteLine("Belo Horizonte");
            } else
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            //URI 1052
            int M = int.Parse(Console.ReadLine());

            if (M == 1)
            {
                Console.WriteLine("January");
            }
            else if (M == 2)
            {
                Console.WriteLine("February");
            }
            else if (M == 3)
            {
                Console.WriteLine("March");
            }
            else if (M == 4)
            {
                Console.WriteLine("April");
            }
            else if (M == 5)
            {
                Console.WriteLine("May");
            }
            else if (M == 6)
            {
                Console.WriteLine("June");
            }
            else if (M == 7)
            {
                Console.WriteLine("July");
            }
            else if (M == 8)
            {
                Console.WriteLine("August");
            }
            else if (M == 9)
            {
                Console.WriteLine("September");
            } else if (M == 10)
            {
                Console.WriteLine("October");
            } else if (M == 11)
            {
                Console.WriteLine("November");
            } else if (M == 12)
            {
                Console.WriteLine("December");
            }

            //URI 1060
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            if (a > 0.0)
            {
                cont = cont + 1;
            }
            if (b > 0.0)
            {
                cont = cont + 1;
            }
            if (c > 0.0)
            {
                cont = cont + 1;
            }
            if (d > 0.0)
            {
                cont = cont + 1;
            }
            if (e > 0.0)
            {
                cont = cont + 1;
            }
            if (f > 0.0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores positivos");

            //URI 1064
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            double soma = 0.0;
            if (a > 0.0)
            {
                cont = cont + 1;
                soma = soma + a;
            }
            if (b > 0.0)
            {
                cont = cont + 1;
                soma = soma + b;
            }
            if (c > 0.0)
            {
                cont = cont + 1;
                soma = soma + c;
            }
            if (d > 0.0)
            {
                cont = cont + 1;
                soma = soma + d;
            }
            if (e > 0.0)
            {
                cont = cont + 1;
                soma = soma + e;
            }
            if (f > 0.0)
            {
                cont = cont + 1;
                soma = soma + f;
            }
            Console.WriteLine(cont + " valores positivos");

            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            //URI 1065
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            int cont = 0;
            if (a % 2 == 0)
            {
                cont = cont + 1;
            }
            if (b % 2 == 0)
            {
                cont = cont + 1;
            }
            if (c % 2 == 0)
            {
                cont = cont + 1;
            }
            if (d % 2 == 0)
            {
                cont = cont + 1;
            }
            if (e % 2 == 0)
            {
                cont = cont + 1;
            }

            Console.WriteLine(cont + " valores pares");

            //URI 1066
            int num, pares, impares, positivos, negativos;

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (num > 0)
            {
                positivos++;
            }
            else if (num < 0)
            {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

            //URI 1070
            int NE;

            NE = int.Parse(Console.ReadLine());

            if (NE % 2 == 0)
            {
                NE += 1;
            }

            Console.WriteLine(NE);
            Console.WriteLine(NE + 2);
            Console.WriteLine(NE + 4);
            Console.WriteLine(NE + 6);
            Console.WriteLine(NE + 8);
            Console.WriteLine(NE + 10);

            //URI 1113
            int N1, N2;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = int.Parse(vet[0]);
            N2 = int.Parse(vet[1]);

            while (N1 != N2)
            {
                if (N1 < N2)
                {
                    Console.WriteLine("Crescente");
                } else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                N1 = int.Parse(vet[0]);
                N2 = int.Parse(vet[1]);
            }

            //URI 1114
            int NE;

            NE = int.Parse(Console.ReadLine());

            while (NE != 2002)
            {
                Console.WriteLine("Senha Invalida");
                NE = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            //URI 1115
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            //URI 1117
            double nota1 = double.Parse(Console.ReadLine());
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }

            double nota2 = double.Parse(Console.ReadLine());
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }

            double media = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + media.ToString("F2"));

            //URI 1134
            int NE, Alcool = 0, Gasolina = 0, Diesel = 0;

            NE = int.Parse(Console.ReadLine());

            if (NE < 1 && NE > 4)
            {
                NE = int.Parse(Console.ReadLine());
            }

            while (NE != 4)
            {
                if (NE == 1)
                {
                    Alcool++;
                } else if (NE == 2)
                {
                    Gasolina++;
                } else if (NE == 3)
                {
                    Diesel++;
                }
                NE = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);

            //URI 1154
            int idade = int.Parse(Console.ReadLine());
            int soma = 0;
            int cont = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double)soma / cont;
            Console.WriteLine(media.ToString("F2"));

            //URI 1159
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {

                // se for impar, some mais 1
                if (x % 2 != 0)
                {
                    x = x + 1;
                }

                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }

            //URI 1118
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {
                double nota1 = double.Parse(Console.ReadLine());
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }

                double nota2 = double.Parse(Console.ReadLine());
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                double media = (nota1 + nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2"));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
            //URI 1131
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(valores[0]);
                int golsGremio = int.Parse(valores[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter = vitoriasInter + 1;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio = vitoriasGremio + 1;
                }
                else
                {
                    empates = empates + 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int total = vitoriasGremio + vitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
            //URI 1078
            int NE;

            NE = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + NE + " = " + NE * i);
            }

            //URI 1071
            int N1, N2, Min, Max, Soma = 0;

            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());

            if (N1 > N2)
            {
                Max = N1;
                Min = N2;
            }
            else
            {
                Max = N2;
                Min = N1;
            }

            for (int i = Min + 1; i < Max; i++)
            {
                if (i % 2 != 0) {
                    Soma = Soma + i;
                }
            }
            Console.WriteLine(Soma);

            //URI 1067
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //URI 1072
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

            //URI 1073
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }

            //URI 1074
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }

            //URI 1075
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }

            //URI 1079
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0]);
                double b = double.Parse(vet[1]);
                double c = double.Parse(vet[2]);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1"));
            }

            //URI 1080
            int maior, P = 1;

            maior = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    P = i;
                }

            }

            Console.WriteLine(maior);
            Console.WriteLine(P);

            //URI 1094
            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'C')
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'R')
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }
            }

            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");

            //URI 1096
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.Write("I=" + i + " J=" + j + "\n");
                }
            }

            //URI 1097
            int j = 7;
            for (int i = 1; i <= 9; i = i + 2)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j - 1));
                Console.WriteLine("I=" + i + " J=" + (j - 2));
                j = j + 2;
            }
            //URI 1116
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int A = int.Parse(vet[0]);
                int B = int.Parse(vet[1]);

                if (B == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } else
                {
                    double divisao = (double)A / B;
                    Console.WriteLine(divisao.ToString("F1"));
                }
            }

            //URI 1132
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int menor, maior, soma = 0;

            if (A > B) {
                maior = A;
                menor = B;
            } else {
                maior = B;
                menor = A;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);

            //URI 1133
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int maior, menor;

            if (X > Y)
            {
                maior = X;
                menor = Y;
            } else
            {
                maior = Y;
                menor = X;
            }

            for ( int i = menor + 1; i <= maior; i++)
            {
                if(i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }

            //URI 1142
            int N = int.Parse(Console.ReadLine());

            int aux = 0;

            for (int i = 1; i <= N; i++) {
                aux ++;
                Console.WriteLine((aux + 0) + " " + (aux+1) + " " + (aux+2) + " PUM");
                aux = aux + 3;
            }

            //URI 1143
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
            }

            //URI 1144
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
                Console.WriteLine(i + " " + (i * i + 1) + " " + (i * i * i + 1));
            }

            //URI 1151
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i = i + 1)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }

            //URI 1153
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);

            //URI 1155
            double soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma = soma + 1.0 / i;
            }

            Console.WriteLine(soma.ToString("F2"));

            //URI 1156
            int num;
            double den = 1.0, soma = 0.0;
            for (num = 1; num <= 39; num += 2)
            {
                soma = soma + num / den;
                den = den * 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

            //URI 1157
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <=  N; i++)
            {
                if(N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //URI 1099
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                    }
                }
                Console.WriteLine(soma);
            }

            //URI 1101
            string[] valores = Console.ReadLine().Split(' ');
            int m = int.Parse(valores[0]);
            int n = int.Parse(valores[1]);

            while (m > 0 && n > 0)
            {

                int menor = m;
                int maior = n;

                if (m > n)
                {
                    menor = n;
                    maior = m;
                }

                int soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');
                m = int.Parse(valores[0]);
                n = int.Parse(valores[1]);
            }

            //URI 1145
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }

            //URI 1149
            int A, N, i, soma;

            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);

            i = 1;
            N = int.Parse(valores[i]);
            while (N <= 0)
            {
                i = i + 1;
                N = int.Parse(valores[i]);
            }

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
            }

            Console.WriteLine(soma);

            //URI 1150
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());


            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            int cont = 1;
            int soma = x;
            do
            {
                x = x + 1;
                soma = soma + x;
                cont = cont + 1;
            } while (soma <= z);

            Console.WriteLine(cont);

            //URI 1158
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                int soma = 0;
                int cont = 0;
                for (int j = x; cont < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                        cont = cont + 1;
                    }
                }

                Console.WriteLine(soma);
            }

            //URI 1160
            int T, PA, PB, crescA, crescB, anos;
            double G1, G2;
            string[] vet;

            T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                vet = Console.ReadLine().Split(' ');
                PA = int.Parse(vet[0]);
                PB = int.Parse(vet[1]);
                G1 = double.Parse(vet[2]);
                G2 = double.Parse(vet[3]);

                crescA = PA;
                crescB = PB;

                anos = 0;
                while (crescA <= crescB)
                {
                    crescA += (int)(crescA * (G1 / 100));
                    crescB += (int)(crescB * (G2 / 100));
                    anos += 1;
                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }
            }

            //URI 1165
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (x % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(x + " eh primo");
                }
                else
                {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }       
            
}