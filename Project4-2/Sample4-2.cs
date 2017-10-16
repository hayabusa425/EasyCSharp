using System;
using System.Drawing;
using System.Windows.Forms;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 300;
        fm.Height = 300;

        Label lb = new Label();
        lb.Width = fm.Width;
        lb.Height = fm.Height;

        for(int i = 0; i < 5; i++)
        {
            lb.Text += i + 1 + " logo !\n";
        }

        lb.Parent = fm;

        Application.Run(fm);
    }
}