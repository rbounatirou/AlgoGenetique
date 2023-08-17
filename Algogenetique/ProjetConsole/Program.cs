using BibliVille;

namespace ProjetConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ville v = new Ville(4000, 4000);
            Coordonees c = new Coordonees(100, 100,v);
            Coordonees c2 = new Coordonees(912, 418,v);

            Console.WriteLine(Convert.ToString(c.X,2) + " | " + Convert.ToString(c.Y, 2));
            Console.WriteLine(Convert.ToString(c2.X,2) + " | " + Convert.ToString(c2.Y, 2));
            Coordonees e1 = c.Crossover(c2);
            Console.WriteLine(Convert.ToString(e1.X, 2) + " | " + Convert.ToString(e1.Y, 2));
        }
    }
}