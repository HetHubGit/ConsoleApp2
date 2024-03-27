public class PasswordGenerator
{
    private static readonly Random random = new Random();

    private static string GeneratePassword(int length)
    {
        const string chars = "!@#$%^&*()_+|~`1234567890-=qwertyuioop[]asdfghjkl;'zxcvbnm,./QWERTYUIOP{}ASDFGHJKL:ZXCVBNM<>?";
        return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()); // wyrażenie lambda
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj długość Hasła : ");

        var passwordLength = int.Parse(Console.ReadLine());
        string password = GeneratePassword(passwordLength);
        Console.WriteLine("Przetwarzanie znaków specjalnych i wygenerowane Hasło: " + password);
        Console.WriteLine("abc \" W cudzysłowiu\" \t oraz inne znaki specjalne \n \t \" Nowa linia\" i \"Tab\"");
    }
}