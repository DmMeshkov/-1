//  3. программа принимает трехзначное число и выводит последнюю цифру этого числа
int number;
Console.WriteLine("Input a number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number>999)
{
Console.WriteLine("Uncorrect number, Please, input correct number ");
}
else
    if (number<-999)
    {
      Console.WriteLine("Uncorrect number, Please, input correct number  ");   
    }
    else
    number = number % 10;// Пример: 4943 %10 = 3; 4943 %100 = 43; 4943%1000=943
    Console.WriteLine($"{number}");
       

    