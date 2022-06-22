Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "еврей")
{
    Console.WriteLine("Ассалам алейкум!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}