using Avalonia;
using System;
using RiptideEngine;

namespace RiptideGUI;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
    
    
    

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
    
    public static void PrintGreeting()
    {
        Console.WriteLine($"{EngineInfo.Name} version {EngineInfo.Version} \n { EngineInfo.Motd[ Random.Shared.Next(0,2) ] }");
    }
}