
/*
Lag en konsoll-app som skriver til konsollen "Hei, hva heter du?",

deretter leser inn input fra bruker og til slutt printer ut "Velkommen + det brukeren skrev"

eks.

Hei, hva heter du?

Joakim

Velkommen Joakim!
*/


namespace ReadLine_and_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");

            var input = Console.ReadLine(); // ReadLine forventer en verdi fra bruker

            Console.WriteLine("Velkommen " + input + "!"); // Verdien bruker skrev blir skrevet til konsollen
        }
    }
}