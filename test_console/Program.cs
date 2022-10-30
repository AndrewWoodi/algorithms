using strings;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] input = new string[] { "she", "sells", "seashells", "by", "the", "seashore", "the", "shells", "she", "sells", "are", "surely", "seashells" };

MSD.sort(input);

for (int index = 0; index < input.Length; index++)
{
    Console.Write(", " + input[index]);
}