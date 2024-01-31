//Math >= 90 OR Chemistry >= 90
//Math && Chem || Math && Bio || Chem && Bio

int Math, Bio, Chem;

Console.WriteLine("Sisestage oma Matemaatika tulemus:");
Math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma Bioloogia tulemus:");
Bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma Keemia tulemus:");
Chem = Int32.Parse(Console.ReadLine());

if ((Math >= 90 && Chem >= 90) || (Math >= 90 && Bio >= 90) || (Bio >= 90 && Chem >= 90))
{ Console.WriteLine("Palju õnne, Te olete vastuvõetud!"); }
else
{ Console.WriteLine("Teie taoltust ei saa heaks kiita."); }