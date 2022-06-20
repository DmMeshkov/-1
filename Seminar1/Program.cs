
//int number;
//Console.WriteLine("My number is " + number + " and it is good");
//Console.WriteLine($"My number is {number + 9} and it is good");
//Console.WriteLine("Input a number: ");
//number =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Your number is {number}");
//Console.Write($"Your number is {number}");

//Задача: проверить является ли первое число квадратом второго.

//int n1,n2; //  Вывод текста в "" в консоль. Переменная "int" без знака "=", т.к. n1, n2 - не конкретные числа;
//Console.Write($"Input a first number: "); // Вывод текста в консоль;
//n1 = Convert.ToInt32(Console.ReadLine());// Если "2" + "3" = "23", то 2 + 3 =5; Здесь происходит конвертация вводимых цифр в число "n1";

//Console.Write($"Input a second number: "); // Вывод текста в "" в консоль;
//n2 = Convert.ToInt32(Console.ReadLine()); //Здесь происходит конвертация вводимых цифр в число "n2";

//int kuad = n2*n2;//переменная "kuad" - квадрат второго числа;
//if(n1==kuad) // Внимание! не ставить ";" - Действие не закончено; Один знак "=" - это присваивание; "==" - это проверка на равенство.Логическая проверка, дающая ответ "Да" или "Нет";
//{
 //   Console.WriteLine("First number is quad of second number");
//}
//else //Нет ";"
//{
   // Console.WriteLine("First number is not a quad of second number");
//}


// Задачи:
    //  2. Необходима программа которая принимает число, и возвращает название дня недели которому ссотвествует число.
    //  3. программа принимает трехзначное число и выводит последнюю цифру этого числа
//Пример:
//1234 % 1000 =234; % - остаток от деления
//1234 % 100 = 34;
//1234 % 10 = 4;

// 1234/10 = 123;
// 1234/100 = 12;
// 1234/1000 = 1;

int DayOfWeek;
Console.Write("Input a day of week number: ");
DayOfWeek = Convert.ToInt32(Console.ReadLine());
if (DayOfWeek==1)
{
    Console.Write("Monday");
}
else{
    if (DayOfWeek==2)
    {
        Console.Write("Tuesday");
    }
    else
        if (DayOfWeek==3)
    {
         Console.Write("Wednesday");
    }
     else
         if(DayOfWeek==4)
         {
         Console.Write("Thursday");
         }
     else
         if (DayOfWeek==5)
         {
         Console.Write("Friday");
         }
     else 
         if (DayOfWeek==6)
         {
            Console.Write("Saturday");
         } 
     else   
        if (DayOfWeek==6)
        {
            Console.Write("Sunday");
        }
     else
     {
         Console.Write("Not a day of week");
     }   
}