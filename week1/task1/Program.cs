// to reverse a input string
string input = "world";
string reversed = ReverseString(input); 

string ReverseString(string input)
{   var inputLength = input.Length;
    string reversedInput = "";
    while(inputLength > 0)
    {
        reversedInput = reversedInput+input[inputLength - 1];
        inputLength--;
    }
    return reversedInput;
}
Console.WriteLine($"Reversed input value: {reversed}");