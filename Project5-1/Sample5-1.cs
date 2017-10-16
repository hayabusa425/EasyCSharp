using System;
using System.Drawing;
using System.Windows.Forms;

class Sample
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "Sample";

        PictureBox pb = new PictureBox();

        Car c = new Car();
        c.Move();
        c.Move();

        pb.Image = c.img;
        pb.Top = c.top;
        pb.Left = c.left;

        pb.Parent = fm;

        Application.Run(fm);
    }
}

class Car
{
    public Image img;
    public int top;
    public int left;
    public Car()
    {
        img = Image.FromFile("c:\\EasyCSharp\\car.bmp");
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
}