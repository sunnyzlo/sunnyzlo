Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine ();

if (username.ToLower() == "Саша") //с маленькой буквы

{
  Console.WriteLine("Ура, это Саша");
}

else
{
   Console.Write("Привет, ");
   Console.WriteLine(username);
}