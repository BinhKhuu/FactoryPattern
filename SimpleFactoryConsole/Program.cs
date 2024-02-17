// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");
var fanFactory = new Factory.SimpleFactory();
var myFan = fanFactory.CreateFan(typeof(CeilingFan));
myFan.SwitchOn();
myFan.SwitchOff();

var tableFanFactory = new TableFanFactory();
var tableFan = tableFanFactory.CreateFan();

tableFan.SwitchOn();
tableFan.SwitchOff();