using System;
using Terminal.Gui;

namespace SSHCommander.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            var top = Application.Top;
            var window = new Window("SSH Commander")
            {
                X = 0,
                Y = 1, //leaves one row for the toplevel menu
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            top.Add(window);

            var menu = new MenuBar(new MenuBarItem[] {new MenuBarItem("_File", new[] {
                new MenuItem("_Quit", "It quits the application", () =>
                {
                    Application.RequestStop();
                })
            })});

            top.Add(menu);

            Application.Run();
        }
    }
}
