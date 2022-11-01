//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    
    if (n <=0)
    {
        Console.WriteLine($"не натуральное число");
    }
    Console.Write( " " + n);
    if (n > 1) ShowNumbers(n-1); 
    
} 
ShowNumbers(-3);
*/

 //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
int CalculateSumm(int n, int m)
{
    if(n > m)
    {
	    CalculateSumm(n-1, m); 
	}
	return (n + m)*(n - m + 1)/2; 
}
		
Console.WriteLine(CalculateSumm(6, 1));
	
*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*
int AkkermanFunc(int m, int n)
{
	if(m == 0)
	{
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return AkkermanFunc(m - 1, 1);
	}
	return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
		
Console.WriteLine(AkkermanFunc(3,2));
*/