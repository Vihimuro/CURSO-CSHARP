using HashCode_Equals.Entities;

Client a = new Client { Name = "Emily", Email = "emily@gmail.com" };
Client b = new Client { Name = "Vinícius", Email = "emily@gmail.com" };

//O objeto Client está setado para comparar o Email apenas

Console.WriteLine(a.Equals(b)); //True => o conteúdo do email é o mesmo
Console.WriteLine(a == b); //False => a referência de memória é diferente
Console.WriteLine(a.GetHashCode()); //mesmo email == hashCode igual
Console.WriteLine(b.GetHashCode()); //mesmo email == hashCode igual