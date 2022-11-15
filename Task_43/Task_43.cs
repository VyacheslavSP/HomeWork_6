float[,] BuildArray()
{
  string Name;
  float[,] ArrayCoeff=new float [3,2]; //двумерный массив третья строка зарезервирована для проверки правильности заполнения 0-Ок,-1-ошибка
  for (byte j=0; j<2; j++) {  // обход столбцов
    if (j==0) {
      Name="b";
    }else{
      Name="k";
    }
    for (byte i=0; i<2; i++) {  // обход строк
      string FullName=Name+Convert.ToString(i+1);
      Console.WriteLine("Введите значение "+FullName);
      try {
        ArrayCoeff[j,i]=Convert.ToSingle(Console.ReadLine());
      }
      catch {
        Console.WriteLine("неккоректный ввод");
        ArrayCoeff[2,0]=-1; // ставим признак в заранее обговоренном месте
        break;
      }
    }
  }
  return ArrayCoeff;
}
float [,] Coefficients;
while (true) {
  Coefficients=BuildArray();
  if (Coefficients[2,0]==0) {
    break;
  }
}
// блок решения задачи//
if (Coefficients[0,0]==Coefficients[0,1] &Coefficients[1,0]==Coefficients[1,1] ) { // проверки намерено выделены в отдельный блок для читаемости. понятно что можно запихнуть их в сам процесс создания массива
  Console.WriteLine("прямые полностью совподают. беконечное число пересечений");
}else if (Coefficients[1,1]==Coefficients[1,0])
{
  Console.WriteLine("прямые параллельны. нет точек пересечения");
}else {
  float PointX=((Coefficients[0,1]-Coefficients[0,0])/(Coefficients[1,0]-Coefficients[1,1]));
  float PointY=(Coefficients[1,0]*PointX)+Coefficients[0,0];
  Console.WriteLine("Точка пересечения двух прямых: ("+PointX+";"+PointY+")");
}
