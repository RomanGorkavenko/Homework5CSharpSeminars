var rnd = new Random();
int[] nums = new int [4];
int n = nums.Length;
int sum = 0;

for (int i = 0; i < n; i++)
{
    nums[i] = rnd.Next(-50, 50);
    if (i % 2 != 0)
    {
        sum += nums[i];
    } 
}

PrintArray(nums);
Console.WriteLine($" -> сумма чисел стоящих на нечётных позициях в массеве равна: {sum}");

void PrintArray(int[] arr)
{
    string str = "[";

    for (int i = 0; i < arr.Length; i++)
    {
        str += $", {arr[i]}";
    }

    str = str.Remove(1, 2);
    str += "]";
    Console.Write($"Массив: {str}");
}
