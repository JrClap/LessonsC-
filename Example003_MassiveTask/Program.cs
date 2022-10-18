// Найти значение элемента find в одномерном массиве array состоящий n из элементов

int [] array = {1, 2, 45, 85, 84, 78, 4, 63};

int n = array.Length;
int find = 4;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}

/*
Если в массиве несколько одинаковых чисел, используем команду break мы прерываем операцию на 1-м числе

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/