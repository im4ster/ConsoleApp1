using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dataAccess = new DataAccess();
            //var datos =  dataAccess.selectQuery("Select * from tabla1");


            //var algorithms = new Dictionary<string, Func<string, string>>
            //{
            //    {nameof(Hasher.MD5).ToLower(), Hasher.MD5},
            //    // {nameof(Hasher.SHA1).ToLower(), Hasher.SHA1},
            //    {nameof(Hasher.SHA256).ToLower(), Hasher.SHA256},
            //    {nameof(Hasher.SHA384).ToLower(), Hasher.SHA384},
            //    {nameof(Hasher.SHA512).ToLower(), Hasher.SHA512},
            //};

            //if (args.Length < 2)
            //{
            //    Console.WriteLine("You need 2 arguments.");
            //    return;
            //}

            //if (args.Length > 2)
            //{
            //    Console.WriteLine("Too many arguments.");
            //    return;
            //}

            //var algo = args[0].ToLower();
            //var text = args[1];

            //if (!algorithms.ContainsKey(algo))
            //{
            //    Console.WriteLine($"Algorithm {algo} is unknown.");
            //    return;
            //}

            var md5Text = Hasher.MD5("algo");
            var Sha256TextMd5 = Hasher.SHA256(md5Text);
            var Sha256ext = Hasher.SHA256("algo");
            var Sha512Text = Hasher.SHA512("algo");

            Console.WriteLine($"Algorithm md5Text. {md5Text}");
            Console.WriteLine($"Algorithm Sha256ext. { Sha256ext}");
            Console.WriteLine($"Algorithm Sha512Text. { Sha512Text}");

            Console.WriteLine($"Algorithm Sha256TextMd5. { Sha256TextMd5}");

            Console.ReadKey();

        }
    }
}
