using System.Text;
using System.Xml.Linq;
using Task2_demonstration;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        ExtendedDictionary<int, string, double> dictionary = new ExtendedDictionary<int, string, double>();

        Console.WriteLine("Оберіть бажану дію для роботи з розширеним словником:\n" +
            "1 - Додати новий елемент.\n" +
            "2 - Видалити елемент (за заданим ключем).\n" +
            "3 - Перевірити наявність елемента (із заданим ключем).\n" +
            "4 - Перевірити наявність елемента (із заданим значенням (знач1 та знач2)).\n" +
            "5 - Повернення елемента за заданим ключем.\n" +
            "6 - Повернути кількість елементів словника.\n" +
            "0 - Переглянути елементи у словнику.\n" +
            "Для виходу введіть будь-яке значення, яке не належить до наведених вище.\n");

        bool exit = false;

        do
        {
            Console.Write("Ваш вибір: ");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 0:
                    {
                        if (dictionary.Count != 0)
                        {
                            foreach (var element in dictionary)
                            {
                                Console.WriteLine($"\nКлюч: {element.Key}, Значення1: {element.Value1}, Значення2: {element.Value2}\n");
                            }
                        }
                        else Console.WriteLine("Словник пустий! Елементів не знайдено!\n");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Додати новий елемент:\n");
                        Console.Write("Введіть ключ (int): ");
                        int key = int.Parse(Console.ReadLine());
                        Console.Write("Введіть перше значення (string): ");
                        string value1 = Console.ReadLine();
                        Console.Write("Введіть друге значення (double): ");
                        double value2 = double.Parse(Console.ReadLine());
                        dictionary.Add(key, value1, value2);
                        Console.WriteLine("Елемент успішно додано у словник!\n");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Видалити елемент (за заданим ключем):\n");
                        Console.Write("Введіть ключ (int): ");
                        int key = int.Parse(Console.ReadLine());
                        if (dictionary.ContainsKey(key))
                        {
                            dictionary.Remove(key);
                            Console.WriteLine("Елемент успішно видалено із словника!\n");
                        }
                        else Console.WriteLine("Елемент відсутній!\n");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Перевірити наявність елемента (із заданим ключем):\n");
                        Console.Write("Введіть ключ (int): ");
                        int key = int.Parse(Console.ReadLine());
                        Console.WriteLine(dictionary.ContainsKey(key));
                        if (dictionary.ContainsKey(key))
                        {
                            Console.WriteLine("Елемент наявний у словнику!\n");
                        }
                        else Console.WriteLine("Елемент відсутній!\n");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Перевірити наявність елемента (із заданим значенням (знач1 та знач2)):\n");
                        Console.Write("Введіть перше значення (string): ");
                        string value1 = Console.ReadLine();
                        Console.Write("Введіть друге значення (double): ");
                        double value2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(dictionary.ContainsValue(value1, value2));
                        if (dictionary.ContainsValue(value1, value2))
                        {
                            Console.WriteLine("Елемент наявний у словнику!\n");
                        }
                        else Console.WriteLine("Елемент відсутній!\n");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Повернення елемента за заданим ключем:\n");
                        Console.Write("Введіть ключ (int): ");
                        int key = int.Parse(Console.ReadLine());
                        var element = dictionary[key];
                        if (dictionary.ContainsKey(key))
                        {
                            Console.WriteLine($"\nКлюч: {element.Key}, Значення1: {element.Value1}, Значення2: {element.Value2}\n");
                        }
                        else Console.WriteLine("Елемент відсутній!\n");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Повернути кількість елементів словника:\n");
                        Console.WriteLine($"Кількість елементів у словнику: {dictionary.Count}");
                        break;
                    }
                default:
                    {
                        exit = true;
                        break;
                    }
            }
        } while (!exit);
    }
}