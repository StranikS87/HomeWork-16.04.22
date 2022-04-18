Console.WriteLine("ПЕРВАЯ ЗАДАЧА ДОМАШНЕЙ РАБОТЫ");

int numberA = 5;
int numberB = 7;
int numberA1 = 2;
int numberB1 = 10;
int numberA2 = -9;
int numberB2 = -3;

Console.WriteLine("В первом неравенстве: ");
if(numberA < numberB)
{
    Console.WriteLine("второе число больше первого");
}  
else
{
    Console.WriteLine("первое число больше вторго");    
}

Console.WriteLine("Во втором неравенстве: ");
if(numberA1 < numberB1)
{
    Console.WriteLine("второе число больше первого");
}  
else
{
    Console.WriteLine("первое число больше вторго");    
}

Console.WriteLine("В третьем неравенстве: ");
if(numberA2 < numberB2)
{
    Console.WriteLine("второе число больше первого");
}  
else
{
    Console.WriteLine("первое число больше вторго");    
}

Console.WriteLine("ВТОРАЯ ЗАДАЧА ДОМАШНЕЙ РАБОТЫ");

int a1 =2, b1 = 3, c1 = 7;
int a2 = 44, b2 = 5, c2= 78;
int a3 = 22, b3 = 3, c3 = 9;

//"ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ"

int max1 = a1;
if(b1 > max1) max1 = b1;
if(c1 > max1) max1 = c1;

int max2 = a2;
if(b2 > max2) max2 = b2;
if(c2 > max2) max2 = c2;

int max3 = a3;
if(b3 > max3) max3 = b3;
if(c3 > max3) max3 = c3;

//"ВТОРОЙ ВАРИАНТ РЕШЕНИЯ С ИСПОЛЬЗОВАНИЕМ ФУНКЦИИ"

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}

int max4 = Max(a1, b1, c1);
int max5 = Max(a2, b2, c2);
int max6 = Max(a3, b3, c3);
Console.WriteLine("ОТВЕТЫ ПЕРВЫМ СПОСОБОМ РЕШЕНИЯ: ");
Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine("ОТВЕТЫ ВТОРЫМ СПОСОБОМ РЕШЕНИЯ: ");
Console.WriteLine(max4); 
Console.WriteLine(max5); 
Console.WriteLine(max6); 

Console.WriteLine("ТРЕТЬЯ ЗАДАЧА ДОМАШНЕЙ РАБОТЫ");

int[] array = { 4, -3, 7};
int n = array.Length;
int index = 0;
while (index < n)
{
    if(array[index] % 2 == 0) Console.WriteLine("Число является чётным");
    else Console.WriteLine("Число является нечётным"); 
    index++;
}

Console.WriteLine("ЧЕТВЁРТАЯ ЗАДАЧА ДОМАШНЕЙ РАБОТЫ");

int[] array1 = { 1, 2, 3, 4, 5};
int n1 = array1.Length;
int index1 = 0;
while (index1 < n1)
{
    if(array1[index1] % 2 == 0) Console.WriteLine(array1[index1]);
    index1++;
}

Console.WriteLine("ВТОРАЯ ПОДЗАДАЧА (попроще решение)");
int N = 8;
int x = 1;
while (x <= N)
{
    if(x % 2 == 0) Console.WriteLine(x);
    x++;
}