Console.WriteLine("24. Найти кубы чисел от 1 до N");

int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int GetResult(int n)
{
  int K = 0;
  for (int i = 1; i < n; i++)
  {
    K = i * i * i;

    Console.WriteLine(K.ToString() + "  i= " + i.ToString());
  }
  return K;
}


int n = GetNumber("Введите конечное число: ");
Console.Write(GetResult(n));
