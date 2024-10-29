using AdapterSample1;

ChartXML chart = new();
DataAnalizeAdapter adapter = new(chart);

string json = "json convert to xml";

adapter.Analizer(json);