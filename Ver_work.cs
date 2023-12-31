/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
*/
string [] input_arr = new string[4]{"Hello","3r", "H-", "(-" };
System.Console.WriteLine($" массив :   ");
PrintArray(input_arr);
System.Console.WriteLine($" Новый массив :  ");
PrintArray(GetNewArr(input_arr));

string [] GetNewArr (string [] input_array)       // Формирует новый массив
{
    int len = GetLengthNewArr(input_arr);
    string [] res = new string [len];
    int j=0;
    for (int i = 0; i < input_arr.Length-1; i++)
    {
        if (input_arr[i].Length<=3)
        {
         res[j]=input_arr[i];
         j++;
        }
    }
    return res;   
}


int GetLengthNewArr (string [] input_arr)         // Возвращает кол во элементов удовлетворяющих условию
{
    int count = 0;
    string [] res = new string [input_arr.Length];
    for (int i = 0; i < input_arr.Length-1; i++)
    {
        if (input_arr[i].Length<=3) count ++;
    }
    return count;

}



void PrintArray (string [] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write ($"{arr[i]}  " );
    }
 System.Console.WriteLine("");
}