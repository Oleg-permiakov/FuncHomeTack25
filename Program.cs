// Напишите цикл который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа А");
int B = Convert.ToInt32(Console.ReadLine());


double FuncNamberStep(int A, int B) {
double res =  A;   
int[] array = new int[B];   

for (int i = 0; i < B - 1; i++)
{
   array[i] = new Random().Next(A, (A+1));
   res = res * array[i];
}
 return res;
}
double result = FuncNamberStep(A, B);
Console.WriteLine("Полученый результат - " + result);