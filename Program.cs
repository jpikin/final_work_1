string[] array = { "Help", "me", "finish", "this", "task", "right", "now" };
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) counter += 1;
}

string[] resultArray = new string[counter];
int resultArrayIndex=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[resultArrayIndex] = array[i];
        resultArrayIndex += 1;
    } 
}
Console.WriteLine($"[{String.Join(", ", resultArray)}]");