using System;
using Gtk;

namespace HourglassGTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            TimerWindow win = new TimerWindow();
            win.Show();
            Application.Run();
        }
    }
}
