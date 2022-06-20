//Задача: проверить является ли первое число квадратом второго.

int n1,n2; //  Вывод текста в "" в консоль. Переменная "int" без знака "=", т.к. n1, n2 - не конкретные числа;
Console.Write($"Input a first number: "); // Вывод текста в консоль;
n1 = Convert.ToInt32(Console.ReadLine());// Если "2" + "3" = "23", то 2 + 3 =5; Здесь происходит конвертация вводимых цифр в число "n1";

Console.Write($"Input a second number: "); // Вывод текста в "" в консоль;
n2 = Convert.ToInt32(Console.ReadLine()); //Здесь происходит конвертация вводимых цифр в число "n2";

int kuad = n2*n2;//переменная "kuad" - квадрат второго числа;
if(n1==kuad) // Внимание! не ставить ";" - Действие не закончено; Один знак "=" - это присваивание; "==" - это проверка на равенство.Логическая проверка, дающая ответ "Да" или "Нет";
{
    Console.WriteLine("First number is quad of second number");
}
else //Нет ";"
{
    Console.WriteLine("First number is not a quad of second number");
}