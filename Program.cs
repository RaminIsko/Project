using System;
using static System.Console;


// 1 коммит - создание Метода получения массива строк

string[] GetArray (){
    
    string element = ReadLine()!;

    string[] result = element.Split(new char[] {' '});

    return result;
}