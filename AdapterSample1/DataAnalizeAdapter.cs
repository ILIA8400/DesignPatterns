using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample1
{
    public class DataAnalizeAdapter : IDataAnalize
    {
        private readonly ChartXML chart;

        public DataAnalizeAdapter(ChartXML chart)
        {
            this.chart = chart;
        }


        public void Analizer(string json)
        {
            //json convert to xml
            string xml = json;

            chart.Data(xml);

        }
    }
}
