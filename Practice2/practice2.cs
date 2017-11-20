using System;
using System.Drawing;
using System.Windows.Forms;

/*
class practice2
{
    public static void Main()
    {
        Console.WriteLine("Hello.");
        Console.WriteLine("Good bye.");
    }
}
*/

class practice2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        Label lb = new Label();
        lb.Text = "See you again!";
        lb.Parent = fm;

        Application.Run(fm);
    }
}