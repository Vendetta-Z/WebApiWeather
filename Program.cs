using Newtonsoft.Json;
using System.IO;
using System.Net;
using WebApiFrameWork;

namespace CPU_and_memory_Counter
{
    class Program
    {
        static void Main()
        {
            string APPID = "9d77367ce0f3a999706f3d9cbb05dd69";
            string City = "Grozny";

            string URl = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", City, APPID);

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URl);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string responce;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }



            WeatherResponce weatherResponce = JsonConvert.DeserializeObject<WeatherResponce>(responce);
            System.Console.WriteLine("Temperature {0}:  {1} C , {2} " , weatherResponce.Name , weatherResponce.Main.Temp ,weatherResponce.Weather[0].Description);
            
        }
    }
}
