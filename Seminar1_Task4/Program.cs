//программа принимает число n и выводит целые числа от -n до n
int n;
int current;
Console.Write("Input a number: "); // Вывод текста в консоль;
n = Convert.ToInt32(Console.ReadLine());

if(n<0)
{
    n = n*(-1);
}
current = n * (-1);
while(current<= n)
{
    Console.Write(current + " ");
    current++;//+=1
}