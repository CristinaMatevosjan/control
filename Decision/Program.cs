Console.WriteLine("Введите путь к текстовому файлу");
string path=@"" + Console.ReadLine();  
string text=File.ReadAllText(path);
Console.WriteLine(text);
Console.WriteLine();
char[] separator={' ', ',','-','.','!',':','\n','\t','\r'};
string[] words=text.Split(separator, StringSplitOptions.RemoveEmptyEntries);


int SizeNewArray(string[] sourceArray)
{
    int count = 0;
    int length=sourceArray.Length;
        for (int i = 0; i < length; i++)
    {
        int elementLength=sourceArray[i].Length;
        if (elementLength <= 3)
        { count++;

        }
    }
     return count;
}

string[] NewArrayString(int size, string[] currentArray)
{
    string[] searchableArray = new string[size];
     int index=0;
     int length=currentArray.Length;
     for (int i = 0; i < length; i++)
    {      int lengthItem=currentArray[i].Length;
                if ( lengthItem <= 3) 
            
            {
              searchableArray[index] = currentArray[i];
               index++;
            }

}
return searchableArray;
}

int length=SizeNewArray(words);
string[] resultArray=NewArrayString(length, words);

void PrintResultArray(string[] arr)
{
    int size=arr.Length;
    for (int i = 0; i <size ; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

PrintResultArray(resultArray);



