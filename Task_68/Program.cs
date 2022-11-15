/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. С помощью рекурсии!!!
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/

// ввод значений с клавиатуры
Console.Clear();
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
//функция Аккермана 
//https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
int AckermannFunc(int m, int n)
{
    if (m == 0) return (n + 1);
    else if ((m > 0) & (n == 0)) return AckermannFunc(m - 1, 1);
    else if ((m > 0) & (n > 0)) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    else
    {
        Console.WriteLine("Вы ввели недопустимые значения!!");
        return 999999;
    }
}
string input_text = "число m";
int m = int.Parse(ToInputVar(input_text));
input_text = "число n";
int n = int.Parse(ToInputVar(input_text));
Console.Write("A(m,n)=" + AckermannFunc(m, n));