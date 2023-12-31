/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
*/
string [] input_arr = new string[4]{"Hello","3r", "H-", "(-" };
System.Console.WriteLine($" массив :   ");
PrintArray(input_arr);
System.Console.WriteLine($" Новый массив :  ");
//PrintArray(GetNewArr(input_arr));



void PrintArray (string [] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write ($"{arr[i]}  " );
    }
 System.Console.WriteLine("");
}