// Найти максимальное из 9 чисел через массив

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array = {11, 20, 13, 24, 75, 56, 70, 18, 59};

//Если мы хотим, чтобы нам вывело 1 число из массива, то можно:
//Console.WriteLine(array[5]);


int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);


