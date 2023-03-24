using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Fun2("ABDISUHC"));
        }
        static string Fun2(string s)
        {
            int l = s.Length;
            if (l == 0) return s;
            return s[l - 1] + s + s[l - 1];
        }
        static string Reverse(string s)
        {
            int l = s.Length;
            if (l < 2) return s;
            return s[l - 1] + s[1..(l-1)] + s[0];
        }
    }
}