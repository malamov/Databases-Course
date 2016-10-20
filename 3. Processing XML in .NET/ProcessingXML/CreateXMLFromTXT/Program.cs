namespace CreateXMLFromTXT
{
    using System.IO;
    using System.Xml.Linq;
    class Program
    {
        static void Main()
        {
            string[] data = File.ReadAllLines("../../TextFile.txt");

            XElement person = new XElement("person");

            person.Add(new XElement("name",data[0]));
            person.Add(new XElement("adress", data[1]));
            person.Add(new XElement("phone-number", data[2]));

            person.Save("../../PersonInfo.xml");
        }
    }
}
