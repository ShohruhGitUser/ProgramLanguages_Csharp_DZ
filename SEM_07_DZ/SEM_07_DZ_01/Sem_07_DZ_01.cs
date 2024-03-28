// // Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

 Console.OutputEncoding = System.Text.Encoding.UTF8;   // Синтаксис для корректного отображения кирилического текста *у меня проблема с выводом на экран


void NaturalNumbers(int number1, int number2)
{
    if (number1 < number2)
    {
        Console.Write($"{number1}, ");
        NaturalNumbers(number1 + 1, number2);
    }
    else if (number1 > number2)
    {
        Console.Write($"{number1}, ");
        NaturalNumbers(number1 - 1, number2);
    }
    else
    {
        Console.Write($"{number1}");         // Если числа равны вывод двух чисел.
    }
}

Console.WriteLine("Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);