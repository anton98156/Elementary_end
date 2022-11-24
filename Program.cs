

string [] array = ReadArray();
PrintArray(array);
Console.WriteLine();
PrintArray(Change (array));

string [] ReadArray (){
    Console.Write("Enter length of array: ");
    string lenStr = Console.ReadLine();
    int len = Convert.ToInt32(lenStr);

    string [] result = new string[len];
    for (int i = 0; i < len; i++)
    {
        string input = Console.ReadLine();
        result[i] = input;
    }
    return result;
}


void PrintArray(string [] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine ($"{array[i]}");

    }
}


string[] Change(string[] array){
    int Count = 0;
    int Add = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) {
        Count++;
        }
    }
    string [] result = new string[Count];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) {
        result[Add] = array[i];
        Add++;
        }
    }
    return result;
}
