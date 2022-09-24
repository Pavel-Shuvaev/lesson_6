// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* Console.Write("Введите кол-во чисел: М = ");
int a1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("");
Console.WriteLine("Введите М случайных, положительных или отрицательных чисел: ");
int b1 = 0;
for (int i = 0; i < a1; i++)
{
    int c1 = Convert.ToInt32(Console.ReadLine());
    if (c1 > 0) 
    b1++;    
}
Console.WriteLine("->  " + b1 + " "); */

//---------------------------------------------------------------------------------------


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Задача была решена с подсказками из интернета

/* Console.WriteLine("Введите коэффициенты k1, b1, k2, b2 : ");
getCoefficients(out double k1, out double b1, out double k2, out double b2);
analysis(k1, b1, k2, b2, out string res); 
Console.WriteLine(res); 
static void getCoefficients(out double k1, out double b1, out double k2, out double b2)
{
    Console.Write("k 1 = ");
    k1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("b 1 = ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("k 2 = ");
    k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b 2 = ");
    b2 = Convert.ToDouble(Console.ReadLine());
}
static void analysis(double k1, double b1, double k2, double b2, out string result)
{
    if (k1 == k2 && b1 == b2)
        result = "Прямые совпадают во всех своих точках.";
    else if (k1 == k2)
        result = "Точки пересечения нет";
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 3);
        double y = Math.Round(k1 * x + b1, 3);
        result =
            "Точка пересечения двух прямых, по заданным точкам (" + x + "; " + y + ") ";
    }
} */