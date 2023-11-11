using System.Text;
using Task1_demonstration;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Демонстрація роботи реалізованих методів розширення:\n");
        Console.WriteLine("Методи розширення для класу String:");

        Console.Write("Введіть рядок: ");
        string example = Console.ReadLine();
        Console.WriteLine("Введений вами рядок: " + example);
        string new_str = example.Inverting();
        Console.WriteLine("\nВведений вами рядок у ІНВЕРТОВАНОМУ вигляді: " + new_str);

        Console.Write("\n\tВведіть бажану букву для пошуку у рядку(!реєєстр має значення!): ");
        string symbol = Console.ReadLine();
        char selected_symbol = symbol[0];
        int count = example.SymbolCount(selected_symbol);
        Console.WriteLine($"\tКількість букв {selected_symbol} у введеному вами рядку: {count}");
        
        Console.WriteLine("\nМетоди розширення для класу одновимірних масивів:");
        Console.Write("Введіть розмір подальшого масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] example_array = new int[n];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            example_array[i] = random.Next(-10, 10);
        }

        Console.Write("Вхідний масив: { ");
        foreach (int number in example_array)
        {
            Console.Write(number + "; ");
        }
        Console.Write("}");

        Console.Write("\n\n\tВведіть число для пошуку в масиві: ");
        int current_number = int.Parse(Console.ReadLine());
        int count_of_numbers = example_array.CountOccurrences(current_number);
        Console.WriteLine($"\tКількість чисел {current_number} у вхідному масиві: {count_of_numbers}");

        int[] new_array = example_array.UniqueArray();
        Console.Write("\nНовий унікальний масив (без повторюваних значень): { ");
        foreach (int number in example_array)
        {
            Console.Write(number + "; ");
        }
        Console.Write("}");
    }

}
