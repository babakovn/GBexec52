int[] StringToArray(string arrayrow, int size)
{
    string[] row = arrayrow.Split(" ", size);
    
    int[] rowarray = new int[size];

    for(int i = 0; i < size; i++)
    {
        while(true)
        {
            if(int.TryParse(row[i], out rowarray[i])) break;
            Console.WriteLine("Неправильно введена строка массива!");
        }
    }

    return rowarray;
}

string ArrayRow(int size, int numberrow)
{
    string[] nameofrow = {"первую", "вторую", "третью", "четвертую", "пятую"};

    if(numberrow < 5)
    {
        Console.Write($"Введите {nameofrow[numberrow]} строку массива (числа через пробел, количество чисел {size}:");
        string row = Console.ReadLine();
        return row;
    }
    else
    {
        Console.Write($"Введите следующую строку массива (числа через пробел, количество чисел {size}:");
        string row = Console.ReadLine();
        return row;
    }
}

int GetSizeColArray()
{
    int size = 0;
    while(true)
    {
        Console.Write("Введите количество столбцов массива:");
        if(int.TryParse(Console.ReadLine(), out size)) break;
        Console.WriteLine("Ошибка ввода!");
    }
    return size;
}

int GetSizeRowArray()
{
    int size = 0;
    while(true)
    {
        Console.Write("Введите количество строк массива:");
        if(int.TryParse(Console.ReadLine(), out size)) break;
        Console.WriteLine("Ошибка ввода!");
    }
    return size;
}


double ArithmeticMeanRow(int[,] array, int row)
{
    double armean = 0;
    for(int i = 0; i < array.GetLength(1); i++)
        armean = armean + array[row, i];
    armean = armean / array.GetLength(1);
    return armean;
}


double ArithmeticMeanColumn(int[,] array, int column)
{
    double armean = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        armean = armean + array[i, column];
    armean = armean / array.GetLength(1);
    return armean;
}
//



int column = GetSizeColArray();
int row = GetSizeRowArray();

string strrow = string.Empty;
int[] arrrow = new int[column];

int[,] arr = new int[row, column];
double[] armeanrow = new double[row];
double[] armeancol = new double[column];


for(int i = 0; i < row; i++)
{
    strrow = ArrayRow(column, i);
    arrrow = StringToArray(strrow, column);
    for(int j = 0; j < column; j++)
    {
        arr[i, j] = arrrow[j];
    }
    armeanrow[i] = ArithmeticMeanRow(arr,i);
}

for(int i = 0; i < column; i++)
    armeancol[i] = ArithmeticMeanColumn(arr,i);

for(int i = 0; i < row; i++)
{
Console.WriteLine($"Среднее строки {i}: {armeanrow[i]}");
}

for(int i = 0; i < column; i++)
{
Console.WriteLine($"Среднее строки {i}: {armeancol[i]}");
}

