Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "emily";
cookies["email"] = "emily@gmail.com";
cookies["phone"] = "99999999";

Console.WriteLine(cookies["email"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}

else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("ALL COOKIES: ");
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}