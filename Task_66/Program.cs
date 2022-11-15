/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

// ввод значений с клавиатуры
Console.Clear();
string ToInputVar(string input_text)
{
    Console.Write($"Введите {input_text} и нажмите Enter: ");
    string result = Console.ReadLine();
    return result;
}
//замена значений переменных местами
static void ToSwap(ref int oldvar, ref int newvar)
{
    int temp = oldvar;
    oldvar = newvar;
    newvar = temp;
}

//найти сумму чисел между n и m
int ToFindSumBetweenMN(int n, int m,int sum=0)
{
    if (n <= m)
    {
        sum=sum+n;
        n++;
        return ToFindSumBetweenMN(n, m,sum);        

    }
    else if (n == m+1)
    {
        return sum;
    }
    else 
    {
        ToSwap(ref m, ref n);
        return ToFindSumBetweenMN(n, m,sum);
    }
}


string input_text = "натуральное число N";
int n = int.Parse(ToInputVar(input_text));
input_text = "натуральное число M";
int m = int.Parse(ToInputVar(input_text));
Console.WriteLine($"Сумма чисел между {n} и {m} равна " + ToFindSumBetweenMN(n, m));
