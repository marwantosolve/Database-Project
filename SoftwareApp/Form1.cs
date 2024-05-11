namespace SoftwareApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Button1.Click += Button1_Click;
    }
    private void Button1_Click(object sender, EventArgs e)
    {
        Form2 form2 = new Form2();
        form2.Show();
    }
}
