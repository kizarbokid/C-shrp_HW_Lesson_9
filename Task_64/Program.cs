/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1" 
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
System.Console.Clear();

// ввод значений с клавиатуры
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
//обратный отсчет
string FinalCountdown(int n)
{   if (n<1) 
    {Console.WriteLine("BOOM!");
    return "__Game over__";
    }
    Console.Write($"{n}..");
    n--;
    return FinalCountdown(n);
}

string input_text = "натуральное число N";
int n = int.Parse(ToInputVar(input_text));
Console.Write(FinalCountdown(n));
