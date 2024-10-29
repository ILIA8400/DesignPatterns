using Creational.Builder;

var basicApp = new BasicApplicationBuilder();
var builder = new Builder(basicApp);

builder.BuildName();
builder.BuildDescription();
builder.BuildDependencies();


var app = builder.Build();

app.Run();