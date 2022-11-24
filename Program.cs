//Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.




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

