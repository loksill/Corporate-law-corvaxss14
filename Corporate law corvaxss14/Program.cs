using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_law_corvaxss14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> articles = new Dictionary<string, int>
            {
                { "xx1", 5 },
                { "xx2", 10 },
                { "xx3", 15 },
                { "xx4", 25 },
                { "xx5", -1 }, // Пожизненное
                { "xx6", -2 },  // Казнь
                { "Преступление против должностного лица", 10},
                { "Расизм", 10},
                { "Рецидив", 5},
                //{ "Явка с повинной", -5},
                { "Организатор", 10},
                //{ "Неосторожность", -5}
            };
            List<string> selectedArticles = new List<string>();
            string input;

            Console.WriteLine("Введите группы статей (Статьи: 'xx1', 'xx2', 'xx3', 'xx4', 'xx5', 'xx6'; модификаторы: 'Преступление против должностного лица', 'Рецидив', 'Организатор'). Введите 'стоп' для завершения ввода:");
            
            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "стоп")
                {
                    break;
                }

                if (articles.ContainsKey(input))
                {
                    selectedArticles.Add(input);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное название статьи.");
                }

                int totalTime = 0;

                foreach (string article in selectedArticles)
                {
                    int time = articles[article];

                    if (time >= 0)
                    {
                        totalTime += time;
                    }
                    else if (time == -1)
                    {
                        Console.WriteLine("Выбрано: Пожизненное заключение");
                    }
                    else if (time == -2)
                    {
                        Console.WriteLine("Выбрано: Казнь");
                    }

                    //if (totalTime < 6)
                    //{
                    //    Console.WriteLine("Замените срок на предупреждение");
                    //}
                }
                Console.WriteLine($"Общее время заключения: {totalTime} минут");
            }
        }
    }
}