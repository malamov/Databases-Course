using System;
using System.Collections.Generic;
using System.Xml;
namespace ExtractArtists
{
    class Program
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../catalog.xml");
            string xPathQuery = "/albums/album/artist";

            var artistsAlbumsCount = new Dictionary<string, int>();

            XmlNodeList artisstList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode item in artisstList)
            {
                var artistName = item.InnerText;

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
