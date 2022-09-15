internal class Program
{
    private static void Main(string[] args)
    {
        Random rand = new Random();
        int a = rand.Next(51);
        int count = 1;

        Console.WriteLine("Компьютер загадал число от 0 до 50. У вас есть три попытки, чтобы отгадать число!.");
        Console.WriteLine("Введите первое число:");

        int b = Convert.ToInt32(Console.ReadLine());

        while (count <= 3)
        {
            if (a == b)
            {
                Console.WriteLine($"Поздравляю вы угадали число с {count} попытки!");
                break;
            }
            else
            {
                count++;
                if (count == 4)
                {
                    Console.WriteLine($"К сожалению,вам не удалось отгадать число.Это было число {a}!");
                    break;
                }
                Console.WriteLine($"Вы не угадали число. У вас есть еще попытка :D");
                b = Convert.ToInt32(Console.ReadLine());


            }



        }
        


    }
}
