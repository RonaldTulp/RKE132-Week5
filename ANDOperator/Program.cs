//Math >= 90; Biology >= 90; Chemistry >=90;

int Math, Bio, Chem;

Console.WriteLine("Sisestage oma Matemaatika tulemus:");
Math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma Bioloogia tulemus:");
Bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma Keemia tulemus:");
Chem = Int32.Parse(Console.ReadLine());

if (Math >= 90 && Bio >= 90 && Chem >= 90)
    { Console.WriteLine("Palju õnne, Te olete vastuvõetud!"); }
else
    { Console.WriteLine("Teie taoltust ei saa heaks kiita."); }