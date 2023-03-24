using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            Console.WriteLine(RemoveOK(Console.ReadLine()));
        }
        static string RemoveOK(string s)
        {
            StringBuilder sb = new();
            int k = 0;
            foreach(char c in s)
            {
                if(c == 'o')
                {
                    k++;
                }
                else if(c == 'k')
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
                    while(k > 0)
                    {
                        sb.Append('o');
                        k--;
                    }
                    sb.Append(c);
                }
            }
            while (k > 0)
            {
                sb.Append('o');
                k--;
            }
            return sb.ToString();
        }
        static string AddLastChar(string s)
        {
            int l = s.Length;
            if (l == 0) return s;
            return s[l - 1] + s + s[l - 1];
        }
        static string SwapFirstAndLastChar(string s)
        {
            int l = s.Length;
            if (l < 2) return s;
            return s[l - 1] + s[1..(l-1)] + s[0];
        }
    }
}