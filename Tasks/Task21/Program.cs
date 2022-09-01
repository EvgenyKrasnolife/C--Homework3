// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(double xa, double ya, double za, double xb, double yb, double zb ){
	double result = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
	return Math.Round(result, 2);
}


Console.WriteLine("Введите координаты первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
double ya = Convert.ToDouble(Console.ReadLine());
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
double yb = Convert.ToDouble(Console.ReadLine());
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Расстояние между точками в 3D пространстве: " + Distance(xa, ya, za, xb, yb, zb));