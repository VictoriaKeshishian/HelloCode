int[] array = {11,26,32,74,52,60,47,88,74};
int n = array.Length;
int find = 74;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}