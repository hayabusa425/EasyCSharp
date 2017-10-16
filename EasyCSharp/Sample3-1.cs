using System;
using System.Drawing;
using System.Windows.Forms;

/*
class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:\\EasyCSharp\\logo.bmp");
        pb.Top = 100;

        pb.Parent = fm;

        Application.Run(fm);
    }
}
*/

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("c:\\EasyCSharp\\logo.bmp");
        pb.Top = 100;
        pb.Left = pb.Width;

        pb.Parent = fm;

        Application.Run(fm);
    }
}