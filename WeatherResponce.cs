using System.Collections.Generic;

namespace WebApiFrameWork
{
    class WeatherResponce
    {
        public TemperatureInfo Main { get; set; }

        public string Name { get; set; }
        public CloudsInfo Clouds { get; set; }


        public List<CloudsInfo> Weather { get; set; }
    }
}
