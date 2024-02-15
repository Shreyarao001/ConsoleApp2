// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
Console.WriteLine("Welcome to Authentication App");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@1256"));
