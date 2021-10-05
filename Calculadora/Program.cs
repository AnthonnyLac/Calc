using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar;
            int escolhaMenu;
            do
            {
                Console.Clear();

                Console.WriteLine("Olá, Seja bem vindo!\n\rEscolha a opção desejada:\n\r[1]Calculadora\n\r[2]Sair.");
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                int operacao;

                switch (escolhaMenu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Calculadora Selecionada!\n\rPrecione qualquer tecla!");
                        Console.ReadKey();
                        do
                        {

                            Console.Clear();

                            Console.WriteLine("Insira o primeiro numero que deseja calcular:");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Insira a operação desejada.\n\r[1]Somar.\n\r[2]Subtrair.\n\r[3]Dividir.\n\r[4]Mutiplicar.");
                                operacao = Convert.ToInt32(Console.ReadLine());
                            }
                            while (operacao < 1 || operacao > 4);
                            Console.Clear();
                            Console.WriteLine("Agora insira o segundo numero que deseja calcular");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();

                            switch (operacao)
                            {
                                case 1:
                                    Console.WriteLine("O resultado é:" + num1 + "+" + num2 + "=" + (num1 + num2));
                                    break;

                                case 2:
                                    Console.WriteLine("O resultado é:" + num1 + "-" + num2 + "=" + (num1 - num2));
                                    break;

                                case 3:
                                    Console.WriteLine("O resultado é:" + num1 + "/" + num2 + "=" + (num1 / num2));
                                    break;

                                case 4:
                                    Console.WriteLine("O resultado é:" + num1 + "X" + num2 + "=" + (num1 * num2) + "\n\r");
                                    break;
                            }
                            do
                            {

                                Console.WriteLine("\r\nDeseja reiniciar a calculadora?\n\r[1]Reinicar.\n\r[2]Encerrar.");
                                continuar = Convert.ToInt32(Console.ReadLine());
                                switch (continuar)
                                {
                                    case 1:
                                        Console.WriteLine("Reiniciando...");
                                        break;
                                    case 2:
                                        Console.WriteLine("Encerrando...");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("Opção não encontrada, Reiniciando.");
                                        break;
                                }
                                Console.Clear();
                            } while (continuar < 1 || continuar > 2);

                        } while (continuar == 1);
                        break;

                    case 2:
                        Console.WriteLine("Saindo.");
                        Environment.Exit(0);
                        break;
                }
            } while (escolhaMenu > 2 || escolhaMenu < 1);
        }
    }
}
