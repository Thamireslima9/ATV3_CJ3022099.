namespace teste_1
{
    internal class program
    {
        static void Main(string[] args)
        {
            //exercício 1
            int num;

            Console.WriteLine("insira um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("o número inserido {0} é par.", num);
            }
            else
            {
                Console.WriteLine("o número inserido {0} é ímpar.", num);
            }
            //exercício 2
            Console.WriteLine();
            float lado1, lado2, lado3;

            Console.WriteLine("insera os comprimentos dos três lados do triângulo: ");

            Console.WriteLine("lado 1: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.WriteLine("lado 2: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.WriteLine("lado 3: ");
            lado3 = float.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("o triângulo é equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("o triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("o triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("não é possível formar um triângulo com esses lados.");
            }
            Console.WriteLine();

            //exercício 3
            Console.WriteLine();
            int numero, tentativa;

            Random gerador = new Random();
            numero = gerador.Next(1, 100);

            Console.WriteLine("digite e tente adivinhar um número aleatório entre 1 a 100");
            tentativa = int.Parse(Console.ReadLine());

            if (numero == tentativa)
            {
                Console.WriteLine("parabéns, você acertou de primeira");
            }
            else
            {
                if (numero < tentativa)
                {
                    Console.WriteLine("o número é menor do que {0}", tentativa);
                }
                else
                {
                    Console.WriteLine("o número é maior do que {0}", tentativa);
                }
                Console.WriteLine("digite e tente adivinhar um número aleatório entre 1 a 100");
                tentativa = int.Parse(Console.ReadLine());
                if (numero == tentativa)
                {
                    Console.WriteLine("acertou de segunda!");
                }
                else
                {
                    if (numero < tentativa)
                    {
                        Console.WriteLine("o número é menor do que {0}", tentativa);
                    }
                    else
                    {
                        Console.WriteLine("o número é maior do que {0}", tentativa);
                    }
                    Console.WriteLine("digite e tente adivinhar um número aleatório entre 1 a 100");
                    tentativa = int.Parse(Console.ReadLine());
                    if (numero == tentativa)
                    {
                        Console.WriteLine("acertou de terceira!");
                    }
                    else
                    {
                        Console.WriteLine("suas tentativas acabaram");
                    }
                }

            }
            //exercício 4
            Console.WriteLine();
            string nome, senha;

            Console.WriteLine("insira o seu nome para o nosso sistema de autenticação: ");
            nome = Console.ReadLine();
            Console.WriteLine("agora a sua senha: ");
            senha = Console.ReadLine();


            if (nome == "admin" && senha == "admin123")
            {
                Console.WriteLine("o seu acesso ao nosso sistema foi concedido!");
            }
            else
            {
                Console.WriteLine("o seu acesso ao nosso sistema foi negado!");
            }
            //exercício 5
            Console.WriteLine();
            float nota;
            string conceito;

            Console.WriteLine("insira uma nota de 0 a 100: ");
            nota = float.Parse(Console.ReadLine());

            if (nota > 100 || nota < 0)
            {
                Console.WriteLine("nota inválida!");
            }
            else
            {
                if (nota >= 90)
                {
                    conceito = "a";
                }
                else if (nota >= 80)
                {
                    conceito = "b";
                }
                else if (nota >= 70)
                {
                    conceito = "c";
                }
                else if (nota >= 60)
                {
                    conceito = "d";
                }
                else
                {
                    conceito = "f";
                }
                Console.WriteLine("a nota {0} corresponde ao conceito {1}", nota, conceito);
            }

            //exercício 6
            Console.WriteLine();
            int jogador, computador;

            Random geretor = new Random();

            Console.WriteLine("escolha entre 1-papel, 2-tesoura ou 3-pedra");

            jogador = int.Parse(Console.ReadLine());

            computador = geretor.Next(1, 3);

            if (jogador == computador)
            {
                Console.WriteLine("Deu empate");
            }
            else
            {
                if (jogador == 1 && computador == 2)
                {
                    Console.WriteLine("Você perdeu");
                }
                else if (jogador == 1 && computador == 3)
                {
                    Console.WriteLine("Você ganhou");
                }
                else if (jogador == 2 && computador == 3)
                {
                    Console.WriteLine("Voce perdeu");
                }
                else if (jogador == 2 && computador == 1)
                {
                    Console.WriteLine("Voce ganhou");
                }
                else if (jogador == 3 && computador == 1)
                {
                    Console.WriteLine("Voce perdeu");
                }
                else if (jogador == 3 && computador == 2)

                {
                    Console.WriteLine("Voce ganhou");
                }

                //exercício 7
                Console.WriteLine();
                float valortotal, desconto = 0;

                Console.WriteLine("insira o valor total da compra: ");
                valortotal = float.Parse(Console.ReadLine());

                if (valortotal > 100 && valortotal <= 200)
                {
                    desconto = 0.1f;
                }
                else if (valortotal > 200 && valortotal <= 300)
                {
                    desconto = 0.2f;
                }
                else if (valortotal > 300 && valortotal <= 400)
                {
                    desconto = 0.3f;
                }
                else if (valortotal > 400)
                {
                    desconto = 0.4f;
                }

                float valorcomdesconto = valortotal - (valortotal * desconto);

                Console.WriteLine("o valor total da compra é: r$ {0}", valortotal);
                Console.WriteLine("o desconto aplicado é: {0}%", desconto * 100);
                Console.WriteLine("o valor final com desconto é: r$ {0}", valorcomdesconto);

                //exercício 8
                Console.WriteLine();
                float peso1, altura, imc;
                string categoria;

                Console.WriteLine("insira seu peso (em kg): ");
                peso1 = float.Parse(Console.ReadLine());
                Console.WriteLine("insira sua altura (em metros): ");
                altura = float.Parse(Console.ReadLine());

                imc = peso1 / (altura * altura);

                if (imc < 18.5)
                {
                    categoria = "abaixo do peso";
                }
                else if (imc >= 18.5f && imc <= 24.9f)
                {
                    categoria = "peso normal";
                }
                else if (imc >= 25 && imc <= 29.9f)
                {
                    categoria = "sobrepeso";
                }
                else if (imc >= 30 && imc <= 34.9f)
                {
                    categoria = "obesidade grau i";
                }
                else if (imc >= 35 && imc <= 39.9f)
                {
                    categoria = "obesidade grau ii";
                }
                else
                {
                    categoria = "obesidade grau iii";
                }
                Console.WriteLine("a categoria na qual você se encaixa é {0}", categoria);

            }
        }
    }
}
