
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] result = GetResult(arr);

int[] GetResult(int[] array)
{
    int[] output = new[] { 0, 1 };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 0)
        {
            output[0] += array[i];
        }
        else
        {
            output[1] *= array[i];
        }
    }
    return output;
}
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");