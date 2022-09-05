//***********************************************************************
// GBTest Итоговая проверочная работа
// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа.
//***********************************************************************

//Initialize an array of strings
string[] stringsArray = { "123", "123213", "234dfdf", "df", "dfe3", "333" };
//Initialize a counter for short strings number
int shortStringsCounter = 0;
//Run through the array and check strings length
for (int i = 0; i < stringsArray.Length; i++)
{
    if (stringsArray[i].Length < 4) shortStringsCounter++;
}
//Initialize an array of strings whit a counted length
string[] newArray = new string[shortStringsCounter];
//Initialize a counter for the new array index
int j = 0;
//Run through the array and check strings length
for (int i = 0; i < stringsArray.Length; i++)
{
    if (stringsArray[i].Length < 4)
    {
        newArray[j] = stringsArray[i];
        j++;
    }
}
//Call the printing method for result array
PrintArray(newArray);

//Prints the given array of strings to the console
void PrintArray(string[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}