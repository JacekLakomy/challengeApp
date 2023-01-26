int myNumber = 159512132;
string myNumberAsString = myNumber.ToString();
char[] digits = myNumberAsString.ToCharArray();

List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

Console.WriteLine("Wyniki dla liczby 159512132");

foreach (char number in numbers)
{
    int counter = 0;
    foreach (char i in digits)
    {
        if (i == number) counter++;
    }
    Console.WriteLine(number + " => " + counter);
}



