using System;
using System.Windows.Forms;

/*

class Sample2 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "Sample";
        this.Width = 250;
        this.Height = 250;

        lb = new Label();
        lb.Text = "Welcome";
        lb.Width = 150;
        bt = new Button();
        bt.Text = "Purchase";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        bt.Parent = this;
        lb.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "Thank you";
    }
}

*/

/*

class Sample3 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample3());
    }

    public Sample3()
    {
        this.Text = "Sample";
        this.Width = 250;
        this.Height = 250;

        lb = new Label();
        lb.Text = "Welcome";

        lb.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);
        this.MouseLeave += new EventHandler(fm_MouseLeave);
    }

    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb.Text = "Hello";
    }

    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb.Text = "See you";
    }
}

*/

class Sample4 : Form
{
    private Label lb1, lb2;

    public static void Main()
    {
        Application.Run(new Sample4());
    }

    public Sample4()
    {
        this.Text = "Sample";
        this.Width = 250;
        this.Height = 250;
        
        lb1 = new Label();
        lb1.Text = "Push with arrow keys";
        lb1.Width = this.Width;

        lb2 = new Label();
        lb2.Top = lb1.Bottom;

        lb1.Parent = this;
        lb2.Parent = this;

        this.KeyDown += new KeyEventHandler(fm_KeyDown);
    }

    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        String str;
        
        if(e.KeyCode == Keys.Up)
        {
            str = "Up";
        }
        else if(e.KeyCode == Keys.Down)
        {
            str = "Down";
        }
        else if(e.KeyCode == Keys.Right)
        {
            str = "Right";
        }
        else if(e.KeyCode == Keys.Left)
        {
            str = "Left";
        }
        else
        {
            str = "Ather keys";
        }

        lb2.Text = "It's " + str;
    }
}