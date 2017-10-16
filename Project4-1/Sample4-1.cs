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

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:\\EasyCSharp\\logo.bmp");
        pb.Left = 200;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        //pb.Top = lb.Bottom;
        lb.Text = "It is logo.";

        if(pb.Left >= 150)
        {
            lb.Text = "Logo in west.";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);
    }
}