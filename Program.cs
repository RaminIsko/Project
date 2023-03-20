using System;
using static System.Console;


// 1 коммит - создание Метода получения массива строк

string[] GetArray (){
    
    string element = ReadLine()!;

    string[] result = element.Split(new char[] {' '});

    return result;
}

// 2 коммит - создание Метода получения конвертированного массива строк

string ConvertedArray (string[] array){
    
    string result = "";
    
    for(int i = 0; i < array.Length; i++) if(array[i].Length <= 3) result += $"{array[i]} ";

    return result;

}
