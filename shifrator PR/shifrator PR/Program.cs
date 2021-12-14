using System;

namespace shifrator_PR
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphavit = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int Variant;
            do
            {
                Console.WriteLine("Выбери действие которое хочешь: \n1)Зашифровать \n2)Расшифровать");
                Variant = int.Parse(Console.ReadLine());
                if (Variant == 1)
                {
                    Console.WriteLine("Введи строку для шифорвки");
                    string input = Console.ReadLine();
                    Console.WriteLine("Введите ключ для шифровки");
                    string key = Console.ReadLine();
                    char[] enter_text = input.ToCharArray();
                    char[] enter_key = key.ToCharArray();
                    string shfr = "";
                    for (int i = 0; i < enter_text.Length; i++)
                    {
                        int one = ((enter_text[i] + enter_key[i]) % 26);
                        one += 'A';
                        shfr += (char)(one);
                    }
                    Console.WriteLine(shfr);
                }
                if (Variant == 2)
                {
                    Console.WriteLine("Введи строку для дешифорвки");
                    string input = Console.ReadLine();
                    Console.WriteLine("Введите ключ для дешифровки");
                    string key = Console.ReadLine();
                    char[] enter_text = input.ToCharArray();
                    char[] enter_key = key.ToCharArray();
                    string shfr = "";
                    for (int i = 0; i < enter_text.Length && i < enter_key.Length; i++)
                    {
                        int one = (enter_text[i] - enter_key[i] + 26) % 26;
                        one += 'A';
                        shfr += (char)(one);
                    }
                    Console.WriteLine(shfr);
                }
            } while (true);

        }
    }
}
