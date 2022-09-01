// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int number){
	int i = 1;
	while(i <= number){
		int result = Convert.ToInt32(Math.Pow(i, 3));
		i++;
		Console.WriteLine(result);
	}
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);