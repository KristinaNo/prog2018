using System.IO;
using System.Xml.Serialization;

namespace ДизайнерскоеБюроDLL
{
    public class OrderHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(Order));
        //запись в файл
        public static void WriteToFile(string fileName, Order data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        //загрузка из файла
        public static Order LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (Order)Xs.Deserialize(fileStream);
            }
        }
    }
}
