// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");
Console.WriteLine($"The current time is {DateTime.Now}\n");

DateTime targetDate = new DateTime(2024, 12, 25);
int daysUntil = (targetDate - DateTime.Now).Days;
Console.WriteLine($"Days left until Christmas: {daysUntil}\n");