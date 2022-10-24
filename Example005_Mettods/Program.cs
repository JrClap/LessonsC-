// 1. Методы ничего не принимают и ничего не возвращают.
/*
void Method1 ()
{
    Console.WriteLine("Автор");
}
Method1();
*/

// 2. Методы, которые ничего не возращают, но могут принимать аргументы.
/*
void Method2 (string a)
{
    Console.WriteLine(a);
}
Method2("Текст сообщения");

void Method21 (string a, int b)
{
    int c = 0;
    while (c < b)
    {
        Console.WriteLine(a);
        c++;
    }
}
Method21("Текст", 4);
*/

// 3. Методы, которые что-то возращают, но ни чего не принимают.
/*
int Method3 ()
{
    return DateTime.Now.Year;
}

int year = Method3 ();
Console.WriteLine(year);
*/

// 4. Методы, которые что-то принимают и что-то возращают.
/*
string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(5, "Vanga ");
Console.WriteLine(res);


string Method4 (int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(6, "MOnth ");
Console.WriteLine(res);
*/

// Таблица умножения через for
/*
for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} * {j} = {i*j}");
        }
        Console.WriteLine();
    }
*/

// Преобразование текста
/*
string text = "Я завтра иду на работу, но мне так не хочется рано вставть."
            + "Надо ведь ещё с собакой гулять!";

// string s = "jjjdfhl"
//               0123
// d[3]

string Replace (string text, char old, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == old) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);
*/

// Метод сортировки массива

int [] arr = {1, 5, 5, 7, 9, 3, 4};

void PrintArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Sort (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array [i];
        array [i] = array [minPos];
        array [minPos] = temp;
    }
}

PrintArray(arr);

Sort(arr);

PrintArray(arr);