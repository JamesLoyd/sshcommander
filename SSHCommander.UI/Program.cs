using System;
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

            var menu = new MenuBar(new MenuBarItem[] {new MenuBarItem("_File", new[] {
                new MenuItem("_Quit", "It quits the application", () =>
                {
                    Application.RequestStop();
                })
            })});

            top.Add(menu);

            var label = new Label("IP Address"){
                X = 1,
                Y = 3,
                Width = 50
            };
            var ipAddress = new TextField("") {
                X = Pos.Bottom(label),
                Y= Pos.Bottom(label),
                Width = Dim.Width(label)
            };
            
            var button = new Button("Submit") {
                X = 1,
                Y = 10,
                Width = Dim.Width(ipAddress)
            };

            button.Clicked = () => label.Text = ipAddress.Text;
            window.Add(label, ipAddress, button);

            Application.Run();
        }
    }
}
