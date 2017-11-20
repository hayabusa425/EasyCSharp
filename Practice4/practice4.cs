using System;
using System.Drawing;
using System.Windows.Forms;

/*
class practice4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 300;
        fm.Height = 200;

        Label[] lb = new Label[5];
        for (int i = 0; i<lb.Length; i++)
        {
            lb[i] = new Label();
            lb[i].Text = "display number " + (i * 2 + 2);
            lb[i].Top = i * 30;
            lb[i].Parent = fm;
        }

        //Console.WriteLine(lb.Length);

        Application.Run(fm);
    }
}
*/

class practice4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";
        fm.Width = 600;
        fm.Height = 250;

        PictureBox[,] pb = new PictureBox[5, 5];

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                pb[i, j] = new PictureBox();
                pb[i, j].Image = Image.FromFile("c:\\EasyCSharp\\logo.bmp");
                pb[i, j].Top = i * 50;
                pb[i, j].Left = j * 100;
                pb[i, j].Parent = fm;
            }
        }

        Console.WriteLine(pb.Length);

        Application.Run(fm);
    }
}