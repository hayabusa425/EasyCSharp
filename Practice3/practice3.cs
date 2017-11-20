using System;
using System.Drawing;
using System.Windows.Forms;

/*
class practice3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 300;
        fm.Height = 200;

        Label lb = new Label();
        lb.Text = "Hello.";
        lb.Top = 50;
        lb.Left = 100;
        lb.Parent = fm;

        Application.Run(fm);
    }
}
*/

class practice3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 300;
        fm.Height = 200;

        Label lb1 = new Label();
        Label lb2 = new Label();
        lb1.Text = "hello";
        lb2.Text = "Good bye";
        lb2.Top = 20;
        lb1.Parent = fm;
        lb2.Parent = fm;

        Application.Run(fm);
    }
}