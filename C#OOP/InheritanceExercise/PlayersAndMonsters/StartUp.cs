namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DarkKnight darkKnight = new BladeKnight("name", 3);
            System.Console.WriteLine(darkKnight);
        }
    }
}