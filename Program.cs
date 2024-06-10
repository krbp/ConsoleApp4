namespace ConsoleApp4
{
    public enum ECivilities
    {
        MONSIEUR,
        MADAME
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new("A", "A", Couleur.BLEU);
            user.Civilitie = ECivilities.MONSIEUR;
        }
    }
}
