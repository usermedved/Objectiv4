Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = 0;
while(number != 0)
{
  sumNumber = sumNumber + number % 10;
  number = number / 10;
}
Console.WriteLine($"Сумма числа: {sumNumber}");
