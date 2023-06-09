Console.Write ("Enter you name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine ("Good! Hi, Masha");
}
else
{
    Console.WriteLine ("Hello, " + username);
}