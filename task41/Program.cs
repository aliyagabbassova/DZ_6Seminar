//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2;    1, -7, 567, 89, 223-> 3

int[] NewArray()
{
    Console.WriteLine("Введите некоторое количество чисел");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите числа");
    int[] nums = new int[a];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    return nums;
}
void CreateArray()
{
    int[] nums = NewArray();
    int count = 0;
    foreach (int i in nums)
        if (i > 0)
            count++;
    string x = string.Join(", ", nums);
    Console.WriteLine(x);
    Console.WriteLine($"Количество положительных чисел будет равно {count}");
}
CreateArray();