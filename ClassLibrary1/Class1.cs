using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void MySerialize<T>(T hum, string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = JsonConvert.SerializeObject(hum);
            File.WriteAllText(desktop + "\\" + fileName, json);
        }

        public static T MyDeserialize<T>(string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = File.ReadAllText(desktop + "\\" + fileName);
            T hum = JsonConvert.DeserializeObject<T>(json);
            return hum;
        }
    }
}