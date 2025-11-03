//Esercizio 1
int M = 10;
int sum = 0;
for (int i = 1; i <= M; i++)
{
    sum += i;
}
Console.WriteLine(sum);
//---------------------------------------

//Esercizio 2
int X = 2;
while (X <= 100)
{
    if (X % 2 == 0)
    {
        Console.WriteLine(X);
    }
    X++;
}
//---------------------------------------

//Esercizio 3
int secretNum = 7;
int currentAttempt;
int attemptsRemaining = 3;

do
{
    Console.Write($"Hai {attemptsRemaining} tentativi per indovinare il numero da 1 a 10: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out currentAttempt))
    {
        Console.WriteLine("Inserisci un numero valido!");
        Console.WriteLine("");
        continue;
    }

    if (currentAttempt == secretNum)
    {
        Console.WriteLine("Indovinato! Bravo!");
        Console.WriteLine("");
    }
    else
    {
        attemptsRemaining--;
        Console.WriteLine("Sbagliato, prova un'altro numero " + $"Tentativi rimasti: < {attemptsRemaining} >");
        Console.WriteLine("");
    }

} while (currentAttempt != secretNum && attemptsRemaining != 0);
//---------------------------------------