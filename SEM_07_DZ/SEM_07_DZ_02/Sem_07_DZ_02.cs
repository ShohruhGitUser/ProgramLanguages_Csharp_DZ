
static int  FunctionAckermann(int m, int n)
{
    // По формуле Функции Аккермана есть 3 условия.
    // 1) Если первая переменная (m) равна 0, тогда функция возвращает второй аргумент  (n +1)
    // 2) Если m не равно 0, а n равно 0, тогда функция возвращает Функцию Аккермана с аргументами (m-1, 1)
    // 3) Если  ни один из аргументов не равно 0, т.е. натуральное целое положительное число, то  возвращает Функцию Аккермана (m-1,  вызывает себя еще раз с аргументом (m, n-1))

if (m == 0) return n+1;
else
    if (m != 0 && n == 0)  return FunctionAckermann(m-1, 1);
    else  
        return FunctionAckermann(m-1, FunctionAckermann(m,n-1));
}

int m = 2;
int n = 3;

int result = FunctionAckermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

