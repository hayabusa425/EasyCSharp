using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

class Sample1 : Form
{
    private Button bt;
    private Label[] lb = new Label[3];

    [STAThread]

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 300;
        this.Height = 200;

        for(int i = 0; i < lb.Length ; i++)
        {
            lb[i] = new Label();
            lb[i].Top = i * lb[0].Height;
            lb[i].Width = 300;
        }

        bt = new Button();
        bt.Text = "Display";
        bt.Dock = DockStyle.Bottom;

        bt.Parent = this;

        for(int i = 0; i < lb.Length; i++)
        {
            lb[i].Parent = this;
        }

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();

        if(ofd.ShowDialog() == DialogResult.OK)
        {
            FileInfo fi = new FileInfo(ofd.FileName);
            lb[0].Text = "File name is " + ofd.FileName + ".";
            lb[1].Text = "Absolute path is " + Path.GetFullPath(ofd.FileName) + ".";
            lb[2].Text = "Size is " + Convert.ToString(fi.Length) + ".";
        }
    }
}