int n = 6;
int nthNumber = Fibonacci(n);
int Fibonacci(int p)
{
    int fib1 = 0;
    int fib2 = 1;
    for (int i = 0; i < p; i++)
    {
        int temp = fib1 + fib2;
        fib1 = fib2;
        fib2 = temp;
    }
    return fib1;
}
Console.WriteLine($"Nth fibonacci number is {nthNumber}");
