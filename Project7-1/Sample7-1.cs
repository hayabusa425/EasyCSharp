using System;
using System.Windows.Forms;

/*
class Sample1 : Form
{
    private Button[] bt = new Button[6];
    private FlowLayoutPanel flp;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 600;
        this.Height = 100;

        flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Fill;

        for(int i=0;i<bt.Length;i++)
        {
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = flp;
        }
        
        flp.Parent = this;
    }
}
*/

class Sample2 : Form
{
    private Button[] bt = new Button[6];
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample2());
    }

    public Sample2()
    {
        this.Text = "Sample";
        this.Width = 300;
        this.Height = 200;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;
        tlp.ColumnCount = 3;
        tlp.RowCount = 2;

        for(int i=0;i<bt.Length;i++)
        {
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = tlp;
        }

        tlp.Parent = this;
    }
}