namespace TelephoneDirectory
{
    static class SeedApp
    {
        // Default records
        private static List<Directory> seedList = new List<Directory> {
            new Directory("Murat", "Can", "1111"),
            new Directory("Meltem", "Can", "2222"),
            new Directory("Büşra", "Yanık", "3333"),
            new Directory("Tufan", "Kemal", "4444"),
            new Directory("Pelin", "Ece", "5555")
        };

        public static List<Directory> SeedList { get { return seedList; } }
    }
}