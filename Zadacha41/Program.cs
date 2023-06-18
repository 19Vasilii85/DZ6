Console.Clear();
Console.Write("Введите числа через через пробел: ");
string numbers_string = Console.ReadLine();
int count_number = 1;
for (int i = 0; i < numbers_string.Length; i++)
{
    if (numbers_string[i] == ' ')
    {
        count_number++;
    }
}
int[] numbers = new int [count_number];
int index = 0;
for (int i = 0; i < numbers_string.Length; i++)
{
    string number = "";
    while (numbers_string [i] != ' ')
    {
        if(i != numbers_string.Length - 1)
        {
            number += numbers_string [i].ToString();
            i++;
        }
        else
        {
            number += numbers_string [i].ToString();
            break;
        }
    }
    numbers[index] = Convert.ToInt32(number);
    index++;
}
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Массив цифр равен: {string.Join(", ", numbers)}, больше 0 введено {sum} цифр");
