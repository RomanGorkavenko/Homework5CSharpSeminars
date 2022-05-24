var rnd = new Random();
int[] nums = new int [7];
int n = nums.Length;
int count = 0;

for (int i = 0; i < n; i++)
{
    nums[i] = rnd.Next(99, 1000);
}

for (int i = 0; i < n; i++)
{
    if (nums[i] % 2 == 0)
    {
        count += 1;
    } 
}
PrintArray(nums);
Console.WriteLine($" -> колличество четных чисел в массеве равно: {count}");

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
