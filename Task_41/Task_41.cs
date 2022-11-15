// Вариант без рекурсии
Console.WriteLine("Введите число и нажмете Enter. Для вывода результата  ыыедите команду Results");
byte count=0;
while(true)
{
  string command=(Console.ReadLine()).ToLower();
  switch (command)
  {
  case "results":
  Console.WriteLine("Результат "+count);
  return;
  default:
    try {
      double tmp=Convert.ToDouble(command);
      if (tmp>0) {
count++;
      }
    }
    catch{
      Console.WriteLine("Неккоректный ввод числа");
    }
    break;
  }
}
