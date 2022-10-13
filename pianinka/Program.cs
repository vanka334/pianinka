using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace pianinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            Console.WriteLine("Переключение октав осуществляется с помощью Fn(F1, F2, F3...");
            Console.WriteLine("Пока доступно только 4 октавы");
            Console.WriteLine("Для выхода нажмите F10");
            Console.WriteLine("Для того чтобы использовать пианино просто представьте клавиатуру в виде пианино, где:");
            Console.WriteLine("Q - C(До)");
            Console.WriteLine("2 - C#(До Диез)");
            Console.WriteLine("W - D(Ре)");
            Console.WriteLine("3 - D#(Ре Диез)");
            Console.WriteLine("E - E(Ми)");
            Console.WriteLine("R - F(Фа)");
            Console.WriteLine("5 - F#(Фа Диез)");
            Console.WriteLine("T - G(Соль)");
            Console.WriteLine("6 - G#(Соль Диез)");
            Console.WriteLine("Y - A(Ля)");
            Console.WriteLine("7 - A#(Ля диез)");
            Console.WriteLine("U - B(Си)");




            int stepenk = 0;

            do
            {

                int[] octava = Vetod(stepenk);
                ConsoleKeyInfo nota = Console.ReadKey();
                switch (nota.Key)
                {
                    case ConsoleKey.Q:
                        Bip(octava[0]);
                        break;
                    case ConsoleKey.W:
                        Bip(octava[2]);
                        break;
                    case ConsoleKey.E:
                        Bip(octava[4]);
                        break;
                    case ConsoleKey.R:
                        Bip(octava[5]);
                        break;
                    case ConsoleKey.T:
                        Bip(octava[7]);
                        break;
                    case ConsoleKey.Y:
                        Bip(octava[9]);
                        break;
                    case ConsoleKey.U:
                        Bip(octava[11]);
                        break;
                    case ConsoleKey.D2:
                        Bip(octava[1]);
                        break;
                    case ConsoleKey.D3:
                        Bip(octava[3]);
                        break;
                    case ConsoleKey.D5:
                        Bip(octava[6]);
                        break;
                    case ConsoleKey.D6:
                        Bip(octava[8]);
                        break;
                    case ConsoleKey.D7:
                        Bip(octava[10]);
                        break;
                    case ConsoleKey.F1:
                        stepenk = 0;
                        break;
                    case ConsoleKey.F2:
                        stepenk = 1;
                        break;
                    case ConsoleKey.F3:
                        stepenk = 2;
                        break;
                    case ConsoleKey.F4:
                        stepenk = 3;
                        break;
                    case ConsoleKey.F10:
                        a = true;
                        break;

                }

            } while (a == false);




        }
        static int[] Vetod(int stepen)
        {
            int[] octava = new int[12];

            int[] FirstOctave = new int[] { 128, 136, 144, 152, 160, 168, 184, 192, 200, 216, 232, 240 };
            double umnozh = Math.Pow(2, stepen);
            int umnozhenie = Convert.ToInt32(umnozh);
            for (int i = 0; i < 12; i++)
            {
                octava[i] = FirstOctave[i] * umnozhenie;
                
            }

            return octava;
        }
        static void Bip(int sound)
        {
            Console.Beep(sound, 300);
        }
    }

}