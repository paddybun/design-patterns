// See https://aka.ms/new-console-template for more information

using GammaPatterns.Lib.AbstractFactoryPattern;
using Microsoft.Extensions.DependencyInjection;

var sc = new ServiceCollection();
sc.AddAbstractFactoryPattern();
var sp = sc.BuildServiceProvider();

// --- Abstract Factory Example ---
// var abstractFactoryExample = sp.GetRequiredService<AbstractFactoryUsageExample>();

Console.WriteLine("Hello, World!");