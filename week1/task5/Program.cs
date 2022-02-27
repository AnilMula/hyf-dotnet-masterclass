int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
if(input.Length % 2 != 0)
{
    Console.WriteLine("WARNING: the array is of odd length");
}
else
{
    int[][] splitArray = Split(input);
    int[] result = AddArray(splitArray);
    WriteResult(result);
}

int[][] Split(int[] input)
{
    int[] one = new int[input.Length / 2];
    int[] two = new int[input.Length / 2];
    int j = 0;

    for( int i= 0; i < input.Length; i++)
    {
        if(i < input.Length/2)
        {
            one[i] = input[i]; 
        }
        else
        {
            two[j] = input[i];
            j++;
        }
    }
    return new int[][]{one,two};
}

int[] AddArray(int[][] splitArray)
{   int[] result = new int[splitArray[0].Length];
    for(int i = 0; i < splitArray[0].Length; i++)
    {
        result[i] = splitArray[0][i] + splitArray[1][i];
    }
    return result;
}

void WriteResult(int[] result)
{
  for(int i = 0; i < result.Length; i++)
  {
      Console.WriteLine(result[i]);
  }
}