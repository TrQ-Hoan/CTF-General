using System;
using System.Security.Cryptography;
using System.Text;

internal class d3b54c 
{
    private static int b54cf5(int A_0, int A_1) 
    {
        return (new int[] 
        {
            2,
            3,
            5,
            7,
            11,
            13,
            17,
            19,
            23,
            29,
            31,
            37,
            41,
            43,
            47,
            53,
            59,
            61,
            67,
            71,
            73,
            79,
            83,
            89,
            97,
            101,
            103,
            107,
            109,
            113
        })[A_1] ^ A_0;
    }

    private static string ef87ef(string A_0) 
    {
        byte[] bytes = Encoding.ASCII.GetBytes(A_0);
        return "ispclub{" + BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(bytes)).Replace("-", "") + "}";
    }

    private static void c7caca(string A_0, int A_1, ref string A_2) 
    {
        int num = 0;
        if (0 < A_0.Length) 
        {
            do 
            {
                char c = A_0[num];
                int num2 = 1;
                do 
                {
                    c = Convert.ToChar(b54cf5(Convert.ToInt32(c), num2));
                    num2++;
                }
                while (num2 < 15);
                A_2 += c;
                num++;
            }
            while (num < A_0.Length);
        }
        A_2 = ef87ef(A_2);
    }

    private static void Main(string[] A_0) 
    {
        string b = null;
        string value = string.Format("{0}", DateTime.Now.Hour + 1);
        string a_ = "Reverse_Do_Thang";
        c7caca(a_, Convert.ToInt32(value), ref b);
        string a = Console.ReadLine();
        if (a == b) 
        {
            Console.WriteLine("u got it!");
            Console.ReadKey(true);
        }
        else 
        {
            Console.Write("u wrong!");
        }
        Console.ReadKey(true);
    }
}
