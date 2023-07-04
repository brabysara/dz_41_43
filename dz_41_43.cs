//Задача 41 |

int number = GetNumberFU("Введите желаемое количество чисел  ","Ошибка ввода!");
int[] znach2 = Number("Вводите числа ","Ошибка ввода!", number);
int calculation = Calculation(znach2 , number);


Console.Write(String.Join(", ", znach2));
Console.Write($" -> {calculation}");



int GetNumberFU(string m , string b )
{
    while(true)
    {
        Console.WriteLine(m);
        if (int.TryParse(Console.ReadLine(), out int UN ))
            return UN;
        Console.WriteLine(b);
    }
}

int[] Number(string m , string b, int size)
{
    int[] z = new int[size];
    Console.WriteLine(m);
    for(int i = 0; size > i ; i++ )
    {
        if (int.TryParse(Console.ReadLine(), out int UN ))
        {
            z[i] = UN;
           // if(UN > 0) z+= 1;
        }
        else 
        {
            i-= 1;
            Console.WriteLine(b);
        }
    }

    return z ;
}

int Calculation(int[] a, int size )
{
    int z = 0;
    for(int i = 0; size > i; i++)
    {
        if(a[i] > 0) z++;
    }
    return z;
}


//задача 43

Console.WriteLine(" ");
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");