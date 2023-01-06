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
            TriggerSettings.toggleOn();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] TRIGGER BOT ON");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            TriggerSettings.toggleOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] TRIGGER BOT OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Thread thread = new Thread(Main.Run) { IsBackground = true };
        thread.Start();
    }
}
