int num; 

while (true)
{
      Console.Write("Введите трёхзначное число: ");
      if (int.TryParse(Console.ReadLine(), out num) && num < 1000 && num > 100 || num > -1000 && num < -100 )
           
            break;
      Console.WriteLine("Ошибка ввода! Введите трёхзначное число!");
}

Console.WriteLine($"Введено число = {num}");

num = num % 100;
num = num/10;

Console.WriteLine($"Вторая цифра числа = {num}");






