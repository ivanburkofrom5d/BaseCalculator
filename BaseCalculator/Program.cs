Calculator calculator = new Calculator();

int res1 = calculator.Calc("-", 2, 1);
int res2 = calculator.Calc("+", 2, 1);
int res3 = calculator.Calc("/", 4, 1);
int res4 = calculator.Calc("*", 2, 1);

int res5 = calculator.Calc("+", 1, 2);



Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);
Console.WriteLine(res4);
Console.WriteLine(res5);