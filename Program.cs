using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool isDictionaryWor = true;

            Dictionary <string, string> dictionary = new Dictionary<string, string> ();
            dictionary.Add("казахстан", "столица Астана");
            dictionary.Add("россия", "столица Москва");
            dictionary.Add("италия", "столица Рим");
            dictionary.Add("канада", "столица Оттава");

            while(isDictionaryWor)
            {
                Console.WriteLine("Добро пожаловать в толковый словарь, здесь Вы можете узнать столицу определенной страны.\nВведите слово из списка для получения информации о нем");

                foreach (var item in dictionary)
                {
                    Console.WriteLine(item.Key);
                }

                Console.SetCursorPosition(0, 10);
                userInput= Console.ReadLine().ToLower();

                if (dictionary.ContainsKey(userInput))
                {
                    Console.WriteLine(dictionary[userInput]);
                    Console.ReadKey();
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine("Данный запрос в словаре отсутствует, повторите запрос");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
