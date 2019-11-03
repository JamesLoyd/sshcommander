using Terminal.Gui;

namespace SSHCommander.UI.Views
{
    public class ConnectView : View
    {
        public ConnectView()
        {
            var label = new Label("IP Address")
            {
                X = 1,
                Y = 3,
                Width = 50
            };
            var ipAddress = new TextField("")
            {
                X = Pos.Bottom(label),
                Y = Pos.Bottom(label),
                Width = Dim.Width(label)
            };

            var userNameLabel = new Label("Username")
            {
                X = 1,
                Y = 5,
                Width = Dim.Width(ipAddress)
            };

            var userNameText = new TextField("")
            {
                X = Pos.Bottom(label),
                Y = Pos.Bottom(userNameLabel),
                Width = Dim.Width(userNameLabel)
            };

            var keyFileLabel = new Label("Absolute Path to key file")
            {
                X = 1,
                Y = 7,
                Width = Dim.Width(ipAddress)
            };

            var keyFileText = new TextField("")
            {
                X = Pos.Bottom(label),
                Y = Pos.Bottom(keyFileLabel),
                Width = Dim.Width(keyFileLabel)
            };

            var button = new Button("Submit")
            {
                X = 1,
                Y = 10,
                Width = Dim.Width(ipAddress)
            };

            button.Clicked = () => label.Text = $"{userNameText.Text}@{ipAddress.Text}";
            Add(label, ipAddress, userNameLabel, userNameText, keyFileLabel, keyFileText, button);
        }



    }
}