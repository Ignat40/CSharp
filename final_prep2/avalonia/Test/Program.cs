using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace Test;

/*

    MVVM PATTERN: Simplifies UI Updates and Improves code modularity, reusability and testing. 

        Model -> Manages the data
        View -> Defines the UI
        ViewModel -> Connects the Model with
        the View, handling logic.

        Avalonia UI: 


*/


sealed class Program
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
            .LogToTrace()
            .UseReactiveUI();
}
