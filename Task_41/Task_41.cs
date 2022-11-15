//т.к. тема заеятий рекурсия то вариант с ее использованием
byte Recursion (byte count)
{
  Console.WriteLine("Введите число и нажмите Enter. для отображения результата введите Result");
  string command=(Console.ReadLine()).ToLower();
  switch (command) {
    case "result":
    Console.WriteLine("Результат "+ count);
    return count;
    default:
      try {
        double tmp=Convert.ToDouble(command);
        if (tmp>0) {
          count++;
        }
      }
      catch {
        Console.WriteLine("Неккоректный ввод числа");
      }
      return (Recursion(count));
  }
}
Recursion(0);
