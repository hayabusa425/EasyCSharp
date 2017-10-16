using System;
using System.Drawing;
using System.Windows.Forms;

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        int w;
        w = 100;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:\\EasyCSharp\\logo.bmp");
        pb.Top = w;

        pb.Parent = fm;

        Application.Run(fm);
    }
}