using System;
using System.Windows.Forms;

class Sample1 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample1());
    }

    public Sample1()
    {
        this.Text = "Sample";
        this.Width = 250;
        this.Height = 250;

        lb = new Label();
        lb.Text = "Welcome!";

        lb.Parent = this;

        // フォームがクリックされたときにイベントハンドラを呼び出す
        this.Click += new EventHandler(fm_Click);
    }

    // イベントハンドラを設計
    public void fm_Click(Object sender, EventArgs e)
    {
        lb.Text = "Hello";
    }
}