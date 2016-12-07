using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testecripto
{

    class Program
    {

        static void Main(string[] args)
        {
            int ASCII;
            int somacaracteres = 0;
            string chave, texto, encrypt = "";
            Console.Clear();
            Console.WriteLine("Escolha opção :");
            Console.WriteLine("1 ==>>Encriptografar");
            Console.WriteLine("2 ==>>Descriptografar");
            Console.WriteLine("======== Sair ======");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Chave : (Máx 10 Caracteres)");
                    chave = Console.ReadLine();
                    while (chave.Length > 10 || chave.Length == 0)//Tratar erros de entrada para a variável chave
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\nErro para chave, máx. de 10 Caracteres :");
                        chave = Console.ReadLine();
                    }


                    //Este FOR serve para testar cada caracter da variavel chave, obs: chave não é um vetor no codigo abaixo, eh um método para testar caracter por caracter
                    for (int i = 0; i < chave.Length; i++)
                    {
                        ASCII = (int)chave[i]; // A variavel ASCII recebe o valor inteiro da tabela ASCII de cada caracter da variavel chave
                        somacaracteres += ASCII; // Soma todos os valores obtidos da variavel ASCII                       
                    }


                    if ((chave.Length) % 2 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o texto :");
                        texto = Console.ReadLine();
                        while (texto.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum texto informado, digite o texto novamente :");
                            texto = Console.ReadLine();
                        }
                        for (int i = 0; i < texto.Length; i++)//	.Length , este comando faz a contagem do numero de elementos existentes na váriavel tipo string
                        {
                            //Devolve o codigo ASCII da letra
                            ASCII = (int)texto[i];

                            //Coloca a chave fixa adicionando posições no numero da tabela ASCII
                            int ASCIIC = ASCII + 40 + acrescimo(somacaracteres);

                            if (ASCIIC >= 127 && ASCIIC <= 160) //Verificando caso o valor ASCIIC esteja entre o valor na tabela, que não é exibido na tela.
                            {
                                ASCIIC += 34;
                            }

                            else if (ASCIIC > 255) // Verificando caso aconteça valor ASCIIC esteja fora da tabela, sendo maior que 255, volta a contar apartir 32
                            {
                                int aux = ASCIIC - 255;
                                ASCIIC = 32 + aux;
                            }
                            Console.WriteLine(ASCIIC);
                            //Concatena o texto e o coloca na variável
                            encrypt += Char.ConvertFromUtf32(ASCIIC);

                        }

                        Console.WriteLine("\n\nTexto Criptografado :\n\n");
                        Console.WriteLine(encrypt);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o texto:");
                        texto = Console.ReadLine();
                        while (texto.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum texto informado, digite o texto novamente :");
                            texto = Console.ReadLine();
                        }
                        for (int i = 0; i < texto.Length; i++)//	.Length , este método faz a contagem do numero de elementos existentes na váriavel tipo string
                        {
                            //Devolve o codigo ASCII da letra
                            ASCII = (int)texto[i];
                            //Coloca a chave fixa adicionando posições no numero da tabela ASCII
                            int ASCIIC = ASCII + 62 + acrescimo(somacaracteres);
                            if (ASCIIC >= 127 && ASCIIC <= 160) //Verificando caso o valor ASCIIC esteja entre o valor na tabela, que não é exibido na tela.
                            {
                                ASCIIC += 34;
                            }
                            else if (ASCIIC > 255) // Verificando caso aconteça valor ASCIIC esteja fora da tabela, sendo maior que 255, volta a contar apartir 32
                            {
                                int aux = ASCIIC - 255;
                                ASCIIC = 32 + aux;
                            }
                            Console.WriteLine(ASCIIC);
                            //Concatena o texto e o coloca na variável
                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                        }
                        
                        Console.WriteLine("\n\nTexto Criptografado :\n\n");
                        Console.WriteLine(encrypt);
                        //Console.WriteLine("Soma de todos caracteres :{0}",somacaracteres);
                        //Console.WriteLine("Acrescimo :{0}",acrescimo(somacaracteres));


                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Chave : (Máx 10 Caracteres)");
                    chave = Console.ReadLine();
                    while (chave.Length > 10)//Tratar erros de entrada para a variável chave
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\nErro para chave, máx. de 10 Caracteres :");
                        chave = Console.ReadLine();
                    }

                    //Este FOR serve para testar cada caracter da variavel chave, obs: chave não é um vetor no codigo abaixo, eh um método para testar caracter por caracter
                    for (int i = 0; i < chave.Length; i++)
                    {
                        ASCII = (int)chave[i]; // A variavel ASCII recebe o valor inteiro da tabela ASCII de cada caracter da variavel chave
                        somacaracteres += ASCII; // Soma todos os valores obtidos da variavel ASCII                       
                    }


                    if ((chave.Length % 2) == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o texto criptografado :");
                        texto = Console.ReadLine();
                        while (texto.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum texto informado, digite o texto novamente :");
                            texto = Console.ReadLine();
                        }
                        for (int i = 0; i < texto.Length; i++)//	.Length , este método faz a contagem do numero de elementos existentes na váriavel tipo string
                        {
                            //Devolve o codigo ASCII da letra
                            ASCII = (int)texto[i];
                            //Coloca a chave fixa adicionando posições no numero da tabela ASCII
                            int ASCIIC = ASCII - (40 + acrescimo(somacaracteres));
                            if (ASCIIC >= 127 && ASCIIC <= 160)
                            {
                                ASCIIC -= 34;
                            }
                            else if (ASCIIC < 32) // Verificando caso aconteça valor ASCIIC esteja fora da tabela
                            {
                                int aux = ASCIIC - 32;
                                ASCIIC = 255 - aux;
                            }
                            Console.WriteLine(ASCIIC);
                            //Concatena o texto e o coloca na variável
                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                        }
                        
                        Console.WriteLine("\n\nTexto Decriptografado :\n\n");
                        Console.WriteLine(encrypt);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o texto criptografado :");
                        texto = Console.ReadLine();
                        while (texto.Length == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum texto informado, digite o texto novamente :");
                            texto = Console.ReadLine();
                        }
                        for (int i = 0; i < texto.Length; i++)//	.Length , este método faz a contagem do numero de elementos existentes na váriavel tipo string
                        {
                            //Devolve o codigo ASCII da letra
                            ASCII = (int)texto[i];
                            //Coloca a chave fixa adicionando posições no numero da tabela ASCII
                            int ASCIIC = ASCII - (62 + acrescimo(somacaracteres));
                            if (ASCIIC >= 127 && ASCIIC <= 160)
                            {
                                ASCIIC -= 34;
                            }
                            else if (ASCIIC < 32) // Verificando caso aconteça valor ASCIIC esteja fora da tabela
                            {
                                int aux = ASCIIC - 32;
                                ASCIIC = 255 - aux;
                            }
                            Console.WriteLine(ASCIIC);
                            //Concatena o texto e o coloca na variável
                            encrypt += Char.ConvertFromUtf32(ASCIIC);
                        }
                        Console.WriteLine(acrescimo(somacaracteres));
                        Console.WriteLine("\n\nTexto Decriptografado :\n\n");
                        Console.WriteLine(encrypt);

                    }
                    break;
            }// Fim CASE
            Console.ReadKey();
        }// Fim MAIN

        static int acrescimo(int x)
        {
            int acre;

            if (x % 5 == 0 && x % 3 == 0)
            {
                acre = 2;
            }
            else if (x % 5 == 0 && x % 2 == 0)
            {
                acre = 4;
            }
            else if (x % 3 == 0 && x % 2 == 0)
            {
                acre = 6;
            }
            else if (x % 7 == 0 && x % 3 == 0)
            {
                acre = 8;
            }
            else if (x % 7 == 0 && x % 5 == 0)
            {
                acre = 10;
            }
            else if (x % 7 == 0 && x % 2 == 0)
            {
                acre = 12;
            }
            else if (x % 5 == 0)
            {
                acre = 14;
            }
            else if (x % 3 == 0)
            {
                acre = 16;
            }
            else if (x % 2 == 0)
            {
                acre = 18;
            }
            else if (x % 7 == 0)
            {
                acre = 20;
            }
            else
            {
                acre = 0;
            }
            return acre;
        }
    }
}
