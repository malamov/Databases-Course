namespace ExtractAllSongTitles
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine("\"{0}\"", reader.ReadElementString());
                    }
                }
            }
        }
    }
}
