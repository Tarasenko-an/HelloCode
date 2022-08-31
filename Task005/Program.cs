//Введим число
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//Проверка на 3х-значное число
if (((num > -999) && (num < -100)) || (num > 100) && (num < 1000))

{
   Console.WriteLine(Math.Abs(num%10)); 
}
else
{
    Console.WriteLine("Число не трехзначное");
}