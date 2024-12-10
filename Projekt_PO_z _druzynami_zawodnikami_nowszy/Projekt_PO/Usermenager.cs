using Projekt_PO;

public static class UserManager
{
    public static List<Uzytkownik> LoadUzytkownicy(string filePath)
    {
        List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 2)
                {
                    string nazwaUzytkownika = parts[0];
                    string haslo = parts[1];
                    uzytkownicy.Add(new Uzytkownik(nazwaUzytkownika, haslo));
                }
            }
        }

        return uzytkownicy;
    }

    public static void SaveUzytkownicy(string filePath, List<Uzytkownik> uzytkownicy)
    {
        List<string> lines = new List<string>();
        foreach (var uzytkownik in uzytkownicy)
        {
            lines.Add($"{uzytkownik.Nazwa_uzytkownika};{uzytkownik.Haslo}");
        }
        File.WriteAllLines(filePath, lines);
    }
}