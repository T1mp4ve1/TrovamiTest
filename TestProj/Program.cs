using TestProj;

var person1 = new Person("Ugo", "Fantozzi", 55);
Console.WriteLine("Nome: " + person1.Name);
Console.WriteLine("Cognome: " + person1.LastName);
Console.WriteLine("Eta': " + person1.Age);
person1.GetDetails();