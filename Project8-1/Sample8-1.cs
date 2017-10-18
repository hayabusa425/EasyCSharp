using System;
using System.Windows.Forms;
using System.Drawing;

// 画像の回転
/*
class Sample1 : Form
{
    private Image im;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 250;
        this.Height = 200;

        im = Image.FromFile("c:\\EasyCSharp\\logo.bmp");

        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        im.RotateFlip(RotateFlipType.Rotate90FlipNone);
        this.Invalidate();
    }

    public void fm_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawImage(im, 0, 0);
    }
}
*/

// 画像の拡大・縮小
class Sample2 : Form
{
    private Image im;
    private RadioButton rb1, rb2, rb3;
    private GroupBox gb;
    private int i;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "Sample";
        this.Width = 300;
        this.Height = 300;
        im = Image.FromFile("c:\\EasyCSharp\\logo.bmp");

        rb1 = new RadioButton();
        rb2 = new RadioButton();
        rb3 = new RadioButton();
        rb1.Text = "Normal";
        rb2.Text = "Enlargement";
        rb3.Text = "Shrinking";
        rb1.Dock = DockStyle.Bottom;
        rb2.Dock = DockStyle.Bottom;
        rb3.Dock = DockStyle.Bottom;
        rb1.Checked = true;

        gb = new GroupBox();
        gb.Text = "Type";
        gb.Dock = DockStyle.Bottom;

        rb1.Parent = gb;
        rb2.Parent = gb;
        rb3.Parent = gb;
        gb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
        rb3.Click += new EventHandler(rb_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;
        if (tmp == rb1)
            i = 1;
        else if (tmp == rb2)
            i = 2;
        else if (tmp == rb3)
            i = 3;
        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        if (i == 1)
            g.DrawImage(im, 0, 0);
        else if (i == 2)
            g.DrawImage(im, 0, 0, im.Width * 2, im.Height * 2);
        else if (i == 3)
            g.DrawImage(im, 0, 0, im.Width / 2, im.Height / 2);
    }
}