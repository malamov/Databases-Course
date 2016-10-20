namespace DeleteExpensiveAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
       public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            var albumsToBeRemoved = new List<XmlNode>();

            foreach (XmlNode album in rootNode)
            {
                XmlNode price = album["price"];
                var albumPrice = int.Parse(price.InnerText);

                if (albumPrice > 20)
                {
                    albumsToBeRemoved.Add(price.ParentNode);
                }
            }

            foreach (XmlNode album in albumsToBeRemoved)
            {
                rootNode.RemoveChild(album);
                Console.WriteLine("\"{0}\" removed !", album["name"].InnerText);
            }

            doc.Save("../../albumsNew.xml");
            Console.WriteLine("\nNew xml document is created as albumsNew.xml\n");
        }
    }
}
