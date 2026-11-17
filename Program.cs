// See https://aka.ms/new-console-template for more information
using typl.src;

Console.WriteLine("Hello, World!");

TypingTest test = new("quick brown fox");
Console.WriteLine(test.ToString());
test.ConsumeChar('q');
test.Start();
test.ConsumeChar('q');
test.ConsumeChar('u');
test.ConsumeChar('i');
Console.WriteLine(test.ToString());