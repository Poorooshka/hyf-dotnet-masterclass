# Homework

## How to deliver homework 

Open this template repository  https://github.com/HackYourFuture-CPH/dotnet-masterclass and click on ![image](https://user-images.githubusercontent.com/6642037/115988976-3796da80-a5bc-11eb-9184-554a2218b2ae.png) and then create a copy of this structure on your own GitHub profile with the name ``hyf-dotnet-masterclass``

Create a PR to add your homework to the respective week folder like you are used to do in the web development course, and if you don't remember how to do hand in homework using Pull Requests, please check here https://github.com/HackYourFuture-CPH/JavaScript/blob/master/javascript1/week1/homework.md

## Homework exercises for Week #1

### 1. String manipulation
Complete the solution so that it reverses the string passed into it.

```csharp
string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString
Console.WriteLine($"Reversed input value: {reversed}")
```

Example:
```
'worlde'  =>  'edlrow'
'word'    =>  'drow'
```

### 2. String/Math
Return the number (count) of vowels in the given string. Consider `a, e, i, o, u` as vowels.

```csharp
string input = "Intellectualization";
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 
Console.WriteLine($"Number of vowels: {vowelCount}")
```

Example:
```
'Intellectualization' => Number of vowels: 9
```

### 3. Math/Array
Given an array of the numbers return an array with two elements where first element represents sum of all negative numbers and second element represents multiplication of all positive numbers;

```csharp
int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 };
int[] result = GetResult(arr); //TODO: Implement GetResult
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");
```

Example:
```
new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59,  -1852, 41, 5 } => Sum of negative numbers: -2022. Multiplication of positive numbers: 20222022
```

### 4. Classical task
Create function Fibonacci that returns N'th element of Fibonacci sequence (classic programming task).

```csharp
int n = 6;
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");
```

Example:
```
int n = 6 => Nth fibonacci number is 8
```

## Extra

### 5. Arrays
Given an integer array as an input, if the length of the array is not even write the warning message, otherwise split the array in half and add both resulting arrays together and write the result.

```csharp
int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);
int[] result = AddArray(splitArray);
WriteResult(result);
```

Example
```
                             [1, 5, 5, 5, 0, 4, 6, 7]          <---- input
                                   /            \
                           [1, 5, 5, 5]    [0, 4, 6, 7]        <---- split
                                   \            /
    [1, 5, 5, 5]  +  [0, 4, 6, 7] = [1, 9, 11, 12]             <---- result
```