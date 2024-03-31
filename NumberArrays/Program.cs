int[] myNums = new int[10];
Random rnd = new Random();
//populating the array with a random numbers
int sum = 0;
for (int i = 0; i < myNums.Length; i++)
{
    myNums[i] = rnd.Next(1, myNums.Length + 1);
    sum = sum + myNums[i];
}
foreach (int element in myNums)
{
    Console.WriteLine(element);
}
Console.WriteLine($"Total: {sum}");