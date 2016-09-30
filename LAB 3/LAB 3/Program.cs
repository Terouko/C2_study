using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Title = "Dave";
            Console.WriteLine("Привет, меня зовут Dave," +
                              "Я предлагаю сыграть тебе в игру,все достаточно просто,ха-ха-ха\n" +
                              "в твою кровь введен яд,раслябляющий твои мышцы" +
                              "и лишает тебя возможности говорить и он убьет тебя через 5 минут,правда весело?" +
                              "чтобы получить противоядие тебе нужно, чтобы человек " +
                              "который находится в этой комнате с тобой НЕ УГАДАЛ число из заданого тобой диапозона за 5 попыток...\n" +
                              "Жить или умереть решать тебе, НАЧНЕМ ПОЖАЛУЙ\n" +
                              "Начало диапазона: ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец диапазона: ");
            var second = Convert.ToInt32(Console.ReadLine());
            var myRandom = new Random();
            var myRandomInt = myRandom.Next(first, second);
            Console.Clear();
            Console.Title = "Nika";
            Console.WriteLine("Привет друг мой, на этот раз с тобой Nika, сейчас на тебя направлен пистолет из другого конца комнаты," +
                              "для того чтобы выжить тебе нужно угадать число за 5 попыток, сделаешь это, цепи с твоих ног спадут и " +
                              "ты сможешь уйти.Наверное,хе-хе-хе.." +
                              "Будь внимателен, ключ к спасению в твоих руках." +
                              "\n Жить или умереть решать тебе, ИГРА НАЧАЛАСЬ!!!");
            int count = 5;
            for (int argIterator = 0; argIterator < 5; argIterator++)
            {
                Console.Title = ("Nika" + Convert.ToString(count));
                Console.WriteLine("\nТвое число: ");
                var printint = Convert.ToInt32(Console.ReadLine());
                if (printint == myRandomInt)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n Умница. Все сводится к одному правилу: чтобы научиться ценить свою жизнь," +
                                          " нужно лично познать вкус смерти");
                    Console.WriteLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Title = "Dave";
                    Console.WriteLine("Игра окончена!");
                    break;
                }
                Console.WriteLine(printint < myRandomInt
                    ? "\nЯ заклинаю вас не следовать своим инстинктам! Больше..."
                    : "\nпока человек не заглянул в глаза смерти нельзя сказать на что он готов ради жизни. Меньше...");
                if (count == 0)
                {
                    Console.WriteLine(
                        "\nЯ не могу дать вам времени, никто не может, время - это иллюзия... \n Игра окончена!");
                    Console.Clear();
                    Console.Title = "Dave";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nУмница. Все сводится к одному правилу: чтобы научиться ценить свою жизнь," +
                                      " нужно лично познать смерть.");
                }
                if (count == 3)
                {   
                    Console.WriteLine("\nУвидь то, что вижу Я");
                }
                if (count == 1)
                {
                    Console.WriteLine("\nПочувствуй то, что чувствую Я");
                }
                --count;
            }


        }
    }
}