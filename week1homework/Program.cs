// Task1: String manipulation


string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString

string ReverseString(string input)
{
    if (input == null) return null;
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}
Console.WriteLine($"Reversed input value: {reversed}");


// Task 2: String/Math

string input2 = "Intellectualization";
int vowelCount = GetVowelCount(input2); //TODO: Implement GetVowelCount 

int GetVowelCount(string input2)
{
    string vowels = "aeiou";
    int count = 0;

    foreach (char c in input2.ToLower())
    {
        if (vowels.Contains(c)) { count++; };


    };
    return count;
}

Console.WriteLine($"Number of vowels: {vowelCount}");


//Task 3: Math/Array
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5, 0 };
int[] result = GetResult(arr); //TODO: Implement GetResult

int[] GetResult(int[] arr)
{
    int negativeSum = 0;
    int positiveProduct = 0;
    foreach (int num in arr)
    {
        switch (num)
        {
            case < 0:
                negativeSum += num;
                break;
            case > 0:
                if (positiveProduct == 0)
                    positiveProduct = num;
                else
                    positiveProduct *= num;
                break;
        }
    }
    return new int[] { negativeSum, positiveProduct };
}

Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");

//Task 4:  Classical task
int number = 6;
// I have used an unsigned long integer so we can store long integer values.
ulong nthNumber = Fibonacci(number); //TODO: Implement Fibonacci

ulong Fibonacci(int number)
{
    if (number == 0) return 0;

    ulong current = 1;
    ulong prev = 0;
    for (int i = 1; i < number; i++)
    {
        ulong temp = current;
        current += prev;
        prev = temp;

    }
    return current;
}

Console.WriteLine($"Nth fibonacci number is {nthNumber}");