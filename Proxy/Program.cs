using Proxy;
using System.Runtime.ExceptionServices;

//News news = new News();
//news.LatestNews();

//First road ^^

INewsService news = new News();
NewsServiceProxy newsServiceProxy = new(news);

Console.WriteLine(newsServiceProxy.LatestNews());

Console.ReadLine();

Console.WriteLine(newsServiceProxy.LatestNews());
