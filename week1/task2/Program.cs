
string input = "Intellectualization";
int vowelCount = GetVowelCount(input.ToLower());

int GetVowelCount(string input)
{
    int count = 0;
    int inputLength = input.Length;
    foreach (char c in input)
    {
        if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
        {
            ++count;
        }
    }
    return count;
}
Console.WriteLine($"Number of vowels: {vowelCount}");