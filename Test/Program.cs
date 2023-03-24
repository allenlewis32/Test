using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fun1("ABDISUHC"));
            Console.WriteLine(Fun2("ABDISUHC"));
            Console.WriteLine(Fun3("asdjokasdjasoksdas"));
        }
        static string Fun3(string s)
        {
            return s.Replace("ok", "");
        }
        static string Fun2(string s)
        {
            int l = s.Length;
            if (l == 0) return s;
            return s[l - 1] + s + s[l - 1];
        }
        static string Fun1(string s)
        {
            int l = s.Length;
            if (l < 2) return s;
            return s[l - 1] + s[1..(l-1)] + s[0];
        }
    }
}