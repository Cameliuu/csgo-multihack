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

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        switch(trackBar1.Value)
        {
            case 1:
                TriggerSettings.setIntensity(2000);
                break;
            case 2:
                TriggerSettings.setIntensity(1000);
                break;
            case 3:
                TriggerSettings.setIntensity(500);
                break;
            case 4:
                TriggerSettings.setIntensity(50);             
                break;
            case 5:
                TriggerSettings.setIntensity(0);
                break;


        }
        Console.WriteLine($"[ + ] TRIGGER BOT INTENSITY SET TO {trackBar1.Value}");
    }
}
