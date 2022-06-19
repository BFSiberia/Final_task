void PrintArray (string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

string[] ArrString = {"hello", "2", "world", ":-)", "key"};

string [] Char3Array = new string[0];
int j =0;

for (int i=0; i<ArrString.Length; i++)
{
    if (ArrString[i].Length<=3)
    {
        Array.Resize(ref Char3Array, Char3Array.Length +1);
        Char3Array[j]=ArrString[i];
        j++;
    }
}

PrintArray(Char3Array);