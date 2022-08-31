//Введите число
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -Math.Abs(num);

while (count <= Math.Abs(num))
{
    Console.Write($"{count} ");
    count++;
}
