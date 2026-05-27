using CreationalPatterns.Creational.Singleton;
using CreationalPatterns.Creational.Factory;
using CreationalPatterns.Creational.FactoryMethod;
using CreationalPatterns.Creational.AbstractFactory;
using CreationalPatterns.Creational.Builder;
using CreationalPatterns.Creational.Prototype;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Лабораторна робота №1: Породжувальні патерни ===\n");

// ------------------ 1. SINGLETON ------------------
Console.WriteLine("--- 1. Singleton ---");
var logger1 = Logger.Instance;
var logger2 = Logger.Instance;
logger1.Log("Перше повідомлення");
logger2.Log("Друге повідомлення");
Console.WriteLine($"logger1 === logger2 ? {ReferenceEquals(logger1, logger2)}\n");

// ------------------ 2. SIMPLE FACTORY ------------------
// Один клас зі статичним методом створення обирає потрібний продукт за параметром.
Console.WriteLine("--- 2. Factory (Simple Factory) ---");
INotification email = NotificationFactory.Create(NotificationType.Email);
INotification sms = NotificationFactory.Create(NotificationType.Sms);
INotification push = NotificationFactory.Create(NotificationType.Push);
email.Send("Ваше замовлення підтверджено");
sms.Send("Код підтвердження: 1234");
push.Send("У вас нове повідомлення");
Console.WriteLine();

// ------------------ 3. FACTORY METHOD ------------------
// На відміну від Simple Factory, тут є ієрархія творців: підклас вирішує,
// який саме продукт створити, через перевизначення методу.
Console.WriteLine("--- 3. Factory Method ---");
Logistics road = new RoadLogistics();
Logistics sea = new SeaLogistics();
road.PlanDelivery();
sea.PlanDelivery();
Console.WriteLine();

// ------------------ 4. ABSTRACT FACTORY ------------------
// Фабрика створює одразу цілу РОДИНУ узгоджених продуктів.
Console.WriteLine("--- 4. Abstract Factory ---");
RenderUI(new WindowsFactory());
RenderUI(new MacFactory());
Console.WriteLine();

static void RenderUI(IGUIFactory factory)
{
    factory.CreateButton().Render();
    factory.CreateCheckbox().Render();
}

// ------------------ 5. BUILDER ------------------
Console.WriteLine("--- 5. Builder ---");
var director = new ComputerDirector();

var gamingBuilder = new GamingComputerBuilder();
director.Construct(gamingBuilder);
Console.WriteLine("  Gaming PC: " + gamingBuilder.GetResult());

var officeBuilder = new OfficeComputerBuilder();
director.Construct(officeBuilder);
Console.WriteLine("  Office PC: " + officeBuilder.GetResult());
Console.WriteLine();

// ------------------ 6. PROTOTYPE ------------------
Console.WriteLine("--- 6. Prototype ---");
var circle = new Circle { X = 10, Y = 20, Radius = 5, Color = "Червоний" };
var circleClone = (Circle)circle.Clone();
circleClone.Color = "Синій";
circleClone.X = 100;
Console.WriteLine($"  Оригінал: {circle}");
Console.WriteLine($"  Клон:     {circleClone}");

var rect = new Rectangle { X = 0, Y = 0, Width = 200, Height = 100, Color = "Зелений" };
Console.WriteLine($"  Клон Rectangle: {rect.Clone()}");

Console.WriteLine("\n=== Усі патерни продемонстровано. ===");