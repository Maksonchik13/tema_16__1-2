//// номер 1

//double[,] mas = new double[3, 3];
//Random random = new Random();
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        mas[i, j] = random.NextDouble() * 21;
//        Console.Write($"{mas[i,j]:f2}  "); 
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("введите строку для замены");
//int n=int.Parse(Console.ReadLine());
//Console.WriteLine("Введите столбец для замены");
//int m=int.Parse(Console.ReadLine());
//Console.WriteLine("Введите элемент, на который нужно заменить");
//double el=double.Parse(Console.ReadLine());
//mas[n-1, m-1] = el;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{mas[i, j]:f2}  ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();

// номер 2

string[,] mas = { {"с","р"},{"е","П"},{"М","т, "},{"а","к"},{"в","и"} };

for (int i = 0; i <= mas.GetUpperBound(0); i++)
{
    for (int j = 0; j <= mas.GetUpperBound(1); j++)
    {
        Console.Write($"{mas[i, j]}  "); 
    }
    Console.WriteLine();
}
Console.WriteLine();
string slovo = mas[1, 1] + mas[0, 1] + mas[4, 1] + mas[4, 0] + mas[1, 0] + mas[2, 1] + mas[2, 0] + mas[3, 0] + mas[3, 1] + mas[0, 0];
Console.WriteLine(slovo);



// номер 3 (лампочка)

string[,] mas1 ={
    {"","","x","x","",""},    {"","x","x","x","x",""},
    {"x","x","","","x","x"},    {"","x","x","x","x",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","","x","x","",""},    {"","","x","x","",""},
    {"","x","x","x","x",""}};
string answer = "no"; bool isChecked = false;
do
{
    Console.Clear(); for (int j = 0; j < mas1.GetUpperBound(0) + 1; j++)
    {
        for (int l = 0; l < mas1.GetUpperBound(1) + 1; l++)
        {
            //if (mas1[j, l] != null)
            //{
                Console.Write($"{mas1[j, l],2}");
            //}
        }
        Console.WriteLine();
    }
    if (isChecked == false) Console.Write("Включить лампочку?"); else Console.Write("Выключить лампочку?");
    answer = Console.ReadLine()!; if (answer == "yes") isChecked = !isChecked;
    if (isChecked)
    {
        mas1[2, 2] = "x"; mas1[2, 3] = "x";
    }
    else
    {
        mas1[2, 2] = "";
        mas1[2, 3] = "";
    }
}
while (true);