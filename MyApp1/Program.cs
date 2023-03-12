int number = 4566;
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

foreach (var letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    };
    if (letter == '1')
    {
        counter1++;
    };
    if (letter == '2')
    {
        counter2++;
    };
    if (letter == '3')
    {
        counter3++;
    };
    if (letter == '4')
    {
        counter4++;
    };
    if (letter == '5')
    {
        counter5++;
    };
    if (letter == '6')
    {
        counter6++;
    };
    if (letter == '7')
    {
        counter7++;
    };
    if (letter == '8')
    {
        counter8++;
    };
    if (letter == '9')
    {
        counter9++;
    };
};

Console.WriteLine("Liczba zadana = " + number);
Console.WriteLine("ilość liczb 0 = " + counter0);
Console.WriteLine("ilość liczb 1 = " + counter1);
Console.WriteLine("ilość liczb 2 = " + counter2);
Console.WriteLine("ilość liczb 3 = " + counter3);
Console.WriteLine("ilość liczb 4 = " + counter4);
Console.WriteLine("ilość liczb 5 = " + counter5);
Console.WriteLine("ilość liczb 6 = " + counter6);
Console.WriteLine("ilość liczb 7 = " + counter7);
Console.WriteLine("ilość liczb 8 = " + counter8);
Console.WriteLine("ilość liczb 9 = " + counter9);
