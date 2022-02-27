
string input = "Intellectualization";
int vowelCount = GetVowelCount(input.ToLower());

int GetVowelCount(string input)
{
    int count = 0;
    int inputLength = input.Length;
    for(int i = 0; i < inputLength; i++)
    {
        if((input[i] == 'a' )|| (input[i] == 'e' )|| (input[i] == 'i' )|| (input[i] == 'o' )|| (input[i] == 'u' ))
        {
            ++count;
        }
    }
    return count;
}
Console.WriteLine($"Number of vowels: {vowelCount}");