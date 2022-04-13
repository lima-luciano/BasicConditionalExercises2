//18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade dela e depois mostre se ela pode ou não votar.

Console.WriteLine("Para saber sua idade e se você pode votar, digite seu ano de nascimento:");
int yearOfBirth = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o ano atual: ");
int currentYear = int.Parse(Console.ReadLine());

int yearsOld = currentYear - yearOfBirth;

if (yearsOld >= 16)
{
    Console.WriteLine($"Sua idade nesse ano será {yearsOld} e você já pode votar, porém, o voto é opcional");

    if (yearsOld >= 18)
    {
        Console.WriteLine($"Sua idade nesse ano será {yearsOld} e você é obrigado a votar");
    }
}
else
{
    Console.WriteLine($"Sua idade nesse ano será {yearsOld} e você não pode votar");
}
