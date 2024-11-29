using QuizApp;
using System;
using System.Windows.Forms;

namespace Quiz_Jatek
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
