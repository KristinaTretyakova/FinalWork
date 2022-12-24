Console.WriteLine("Введите текст через один пробел, без запятых");
string? text = Console.ReadLine();
string [] shortWord = text.Split(' ');
Console.WriteLine("Слова меньше четырех символов из тех, что Вы ввели это :");
int maxLength = 4;
for(int i = 0; i < shortWord.Length; i++)
{
    if(shortWord[i].Length < maxLength)
    {
        Console.Write($"{shortWord[i]} ");
    } 
}