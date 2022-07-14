// Пользователь вводит с клавиатуры "M" чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

// Первый вариант программы (как делали обычно)

// int n;
// // Спрашиваем у пользователя сколько чисел будет в массиве
// Console.Write("Напишите количество чисел: ");
// n = Convert.ToInt32(Console.ReadLine());
// // Просим пользователя ввести несколько чисел
// Console.Write("Напишите любые целые числа, в диапазоне от '-100' до '100': ");
// // Создаём массив на указанное пользователем количество элементов
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Ваш массив: [" + string.Join(", ", array) + "]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) count++;
// }
// Console.WriteLine("Вы написали " + string.Join(" ", count) + " чисел больше '0'");
// Console.Write("Вы написали ");
// Console.Write(count);
// Console.Write(" чисел больше '0'.");

// Второй вариант (числа вводятся в одну строку через пробел)
// Стало интересно как сделать такой ввод, кажется получилось, ЙиИХХААА ))

// Просим пользователя ввести несколько чисел
Console.WriteLine("Напишите несколько любых целых чисел через 'пробел'");
Console.WriteLine("В диапазоне от '-100' до '100' и нажмите 'Enter': ");
// Создаём строку, в которую запишутся числа
string a = Console.ReadLine();
// Преобразуем строку в массив, разделённый "пробелом"
string[] arr = a.Split(' ');
// Создаём рабочий массив
int[] array = new int[arr.Length];
for (int i = 0; i < array.Length; i++)
{
    // Преобразуем символы из строки, разделённые "пробелом", в числа и записываем в наш массив
    string myString = arr[i].Trim();
    array[i] = int.Parse(myString);
}
Console.WriteLine("Ваш массив: [" + string.Join(", ", array) + "]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine("Вы написали " + string.Join(" ", count) + " чисел больше '0'");
// Console.Write("Вы написали ");
// Console.Write(count);
// Console.Write(" чисел больше '0'.");
