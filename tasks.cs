using static library;
/*
0
int q =  RandomNumbers_1();
q = q*q*q;

1
int w =  RandomNumbers_1();
int e =  RandomNumbers_1();
int r = 0;
if(e == w*w){
    Console.WriteLine(e +" Квадрат числа" + w);
    Console.WriteLine(e);
    Console.WriteLine(w);
}else{
    Console.WriteLine("не подходит");
}

2
int t =  RandomNumbers_1();
int y =  RandomNumbers_1();
if(t > y){
    Console.WriteLine(t + " Больше чем " + y);
}else if(t == y)  {
    Console.WriteLine(y + " Равен " + t);
}else{
    Console.WriteLine(y + " Больше чем " + t);
}

4
int a = RandomNumbers_1();
int s = RandomNumbers_1();
int d = RandomNumbers_1();
int asd = a;
if (a > asd)
{
    asd = a;
    Console.WriteLine("Ответ");
    Console.WriteLine(asd);
}
if (s > asd)
{
    asd = s;
    Console.WriteLine("Ответ");
    Console.WriteLine(asd);
}
if (d > asd)
{
    asd = d;
    Console.WriteLine("Ответ");
    Console.WriteLine(asd);
}

6
int x = RandomNumbers_1();
if (x % 2 == 0)
{
    Console.WriteLine($"Число {x} чётное");
}
else
{
    Console.WriteLine($"Число {x} не чётное");
}

7
int x = -(RandomNumbers_1());
int y = RandomNumbers_1();
Console.WriteLine($"{x} ");
Console.WriteLine($"{y} ");
while (x <= y)
{
    Console.Write($"{x} | ");
    x++;
}

8
int x = RandomNumbers_1();
for (int i = 1; i < x; i++)
{
    Console.Write($"{i} ");
}


Задача 54
int[,] a = CrtTwoDimArr(5, 5);
FillTwoDimArr(a);
PrintTwoDimArr(a);
//Сортировки пузырьком в двумерном массиве построчно
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(1) - 1; k++)
        {
            if (a[i, k] < a[i, k + 1])
            {
                int t = a[i, k + 1];
                a[i, k + 1] = a[i, k];
                a[i, k] = t;
            }
        }
    }
}
Console.WriteLine();
PrintTwoDimArr(a);

Задача 56
int[,] a = CrtTwoDimArr(5, 4);
FillTwoDimArr(a);
PrintTwoDimArr(a);
Console.WriteLine();
int[] s = CrtArr(5);
int p = 0;
int r = int.MaxValue;
int indexMin = 0;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        p += a[i, j];
    }
    Console.Write($"{p} ");
    if (p < r)
    {
        r = p;
        indexMin = i + 1;
    }
    p = 0;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(indexMin);
*/

int[,] a = CrtTwoDimArr(2, 2);
int[,] b = CrtTwoDimArr(2, 2);
int[,] c = CrtTwoDimArr(2, 2);

FillTwoDimArr(a);
FillTwoDimArr(b);

PrintTwoDimArr(a);
Console.WriteLine();
PrintTwoDimArr(b);

c[0, 0] = (a[0, 0] * b[0, 0]) + (a[0, 1] * b[1, 0]);
c[0, 1] = (a[0, 0] * b[0, 1]) + (a[0, 1] * b[1, 1]);

c[1, 0] = (a[1, 0] * b[0, 0]) + (a[1, 1] * b[1, 0]);
c[1, 1] = (a[1, 0] * b[0, 1]) + (a[1, 1] * b[1, 1]);

Console.WriteLine();
PrintTwoDimArr(c);