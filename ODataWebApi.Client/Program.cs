// See https://aka.ms/new-console-template for more information


using Default;
using ODataWebApi.Models;

Console.WriteLine("Hello, World!");

var serviceRoot = "http://localhost:5252/odata";
var context = new Container(new Uri(serviceRoot));
var rate = context.Articles.ByKey(1).Rate().GetValue();
var message = context.ExecuteSomeFunction().GetValue();

Console.WriteLine(rate.ToString());
Console.WriteLine(message);
