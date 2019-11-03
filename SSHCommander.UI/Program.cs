using System;
using SSHCommander.UI.Views;
using Terminal.Gui;

namespace SSHCommander.UI
{
    public class Program
    {
        public static void Main(string[] args)
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
            var menu = GetMenu(window);
            top.Add(menu);
            window.Add(new ConnectView());
            Application.Run();
        }

        private static MenuBar GetMenu(Window window)
        {
            return new MenuBar(new MenuBarItem[] {new MenuBarItem("_File", new[] {
                new MenuItem("_Quit", "It quits the application", () =>
                {
                    Application.RequestStop();
                })
            })});
        }
    }
}
