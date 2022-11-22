using System.Globalization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YaziDuzeltme
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine(string.Format("{0:f}",DateTime.Now));

            Console.WriteLine();

            YaziDuzeltme("bU tasKI metHodla yAzmAliSiz");

            Console.WriteLine();

            YaziDuzeltme(Console.ReadLine());

            Console.WriteLine();

            

        }

        static void YaziDuzeltme(params string[] soz1)
        {

            TextInfo duzelis = CultureInfo.CurrentCulture.TextInfo;
            foreach (string value in soz1)
                Console.WriteLine("{0} -> {1}", value, duzelis.ToTitleCase(value));






            //string[] soz2 = (string[])soz1.Clone();

            //foreach (string yazdir in soz2)
            //{
            //    Console.WriteLine(yazdir);

            //}
        }

    }
}