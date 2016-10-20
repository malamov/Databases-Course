namespace ExtractArtists
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

            var artistsAlbumsCount = new Dictionary<string, int>();

            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (!artistsAlbumsCount.ContainsKey(artistName))
                {
                    artistsAlbumsCount.Add(artistName, 0);
                }

                artistsAlbumsCount[artistName]++;
            }

            foreach (var artist in artistsAlbumsCount)
            {
                Console.WriteLine("Number of albums of {0} at this collection is : \n|{1}| \n------------", artist.Key, artist.Value);
            }
        }
    }
}
