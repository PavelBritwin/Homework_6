// Task 41

Console.WriteLine("Укажите количество чисел для ввода: ");
int m = Convert.ToInt32(Console.ReadLine());

int [] array = new int[m];
int positiveCount = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите число № {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) positiveCount++;
}
Console.WriteLine($"Количество введенных положительных чисел: {positiveCount}");
