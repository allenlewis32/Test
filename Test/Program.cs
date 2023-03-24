using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fun1("ABDISUHC"));
            Console.WriteLine(Fun2("ABDISUHC"));
            Console.WriteLine(Fun3("aookka"));
        }
        static string Fun3(string s)
        {
            StringBuilder sb = new();
            int l = s.Length;
            int k = 0;
            foreach(char c in s)
            {
                if(c == 'o')
                {
                    k++;
                } else if(c == 'k')
                {
                    if(k > 0)
                    {
                        k--;
                    } else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    sb.Append(c);
                    k = 0;
                }
            }
            while (k > 0) sb.Append('o');
            return sb.ToString();
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