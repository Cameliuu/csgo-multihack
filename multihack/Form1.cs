namespace multihack;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        
        if(checkBox1.Checked) {
            Settings.toggleTriggerOn();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] TRIGGER BOT ON");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Settings.toggleTriggerOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] TRIGGER BOT OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
    }
}
