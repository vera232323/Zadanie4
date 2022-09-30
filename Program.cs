// Используя определение 
// степени числа, напишите цикл, который принимает на вход два натуральных числа
//  (A и B) и возводит число A в степень B.
void Stepchis()
{
    Console.Write("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
int Stepen (int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}
  int exponentiation = Stepen(A, B);
  Console.WriteLine("Ответ: " + exponentiation);
}
// Stepchis();

void Summachisvchisle()
{
 Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());

  int SumN(int N)
  {
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = N - N % 10;
      result = result + (N - advance);
      N = N / 10;
    }
   return result;
  }

int sumaN = SumN(N);
Console.WriteLine("Сумма цифр в числе: " + sumaN);
}
// Summachisvchisle();
void FillArray(int[] numbers)
{ 
  Random random =new Random();
  for (int i = 0; i<numbers.Length;i++)
  { 
    numbers[i]=random.Next(-10,10);
  }
}

void PrintArray(int[] numbers)
{
  Console.WriteLine("Вывод массива:");
  for (int i =0;i<numbers.Length;i++)
  {
    Console.Write(numbers[i] + " ");
  }
  Console.WriteLine();
}

void Modulmassiv()
// Напишите программу,
//  которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.
{
  int size = 8;
  int [] numbers = new int[size];
  FillArray(numbers);
  PrintArray(numbers);

    for (int i = 1;i<size;i++)
    { 
      for(int j=0;j<size-i;j++)
      {
        if (Math.Abs(numbers[j]) > Math.Abs(numbers[j+1]))
        {
            int tmp = numbers[j];
            numbers[j]=numbers[j+1];
            numbers[j+1]=tmp;
        }
      }
    }
    PrintArray(numbers);
}

Modulmassiv();