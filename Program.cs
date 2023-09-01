
Console.WriteLine("Iveskite telefono numeri: ");
string number = Console.ReadLine();
string code = number.Substring(0, number.IndexOf(" "));
Console.WriteLine("Kiek minuciu noretumete sneketi?");
float time = Convert.ToSingle(Console.ReadLine());
float cost = 0;
switch (code)
{
    case "+370":
        Console.WriteLine("Paskambinote i Lietuva.");
        cost = 0.23f;
        break;
    case "+371":
        Console.WriteLine("Paskambinote i Latvija.");
        cost = 0.23f;
        break;
    case "+372":
        Console.WriteLine("Paskambinote i Estija.");
        cost = 0.23f;
        break;
    case "+45":
        Console.WriteLine("Paskambinote i Danija.");
        cost = 0.23f;
        break;
    case "+47":
        Console.WriteLine("Paskambinote i Norvegija.");
        cost = 0.23f;
        break;
    case "+358":
        Console.WriteLine("Paskambinote i Suomija.");
        cost = 0.23f;
        break;
    case "+46":
        Console.WriteLine("Paskambinote i Svedija.");
        cost = 0.23f;
        break;
    case "+355":
        Console.WriteLine("Paskambinote i Albanija.");
        cost = 1.19f;
        break;
    case "+373":
        Console.WriteLine("Paskambinote i Moldova.");
        cost = 1.19f;
        break;
    case "+44":
        Console.WriteLine("Paskambinote i Anglija.");
        cost = 1.19f;
        break;
    case "+1":
        Console.WriteLine("Paskambinote i Amerika.");
        Console.WriteLine("\nOperatorius: Bite \nSkambutis i numeri: " + number + "\nSkambucio " +
            "laikas: " + time + "min \nSkambučio kaina už minutę: " + time * 1.79 + "EUR");
        break;
}
Console.WriteLine("\nOperatorius: Bite \nSkambutis i numeri: " + number + "\nSkambucio " +
    "laikas: " + time + "min \nSkambučio kaina už minutę: " + time * cost + "EUR");

