namespace ExtractSongsWithLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class Program
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../catalog.xml");
            var albums =
                from title in xmlDoc.Descendants("title")
                select title.Value;

            foreach (var item in albums)
            {
                Console.WriteLine("\"{0}\"", item);
            }
        }
    }
}
