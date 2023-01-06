using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
namespace multihack;

public partial class Form1 : MaterialForm
{
    public Form1()
    {
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green800, Accent.Green700, TextShade.BLACK); ;
        InitializeComponent();
        
    }

 

    private void Form1_Load(object sender, EventArgs e)
    {
        Thread thread = new Thread(Main.Run) { IsBackground = true };
        thread.Start();
        materialSlider1.Hide();
        materialComboBox1.Hide();
    }

    private void mterialTrackbar1_Scroll(object sender, EventArgs e)
    {
       
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
       

    }

  
   

    private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    private void materialSlider1_Click(object sender, EventArgs e)
    {
        switch (materialSlider1.Value)
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
        Console.WriteLine($"[ + ] TRIGGER BOT INTENSITY SET TO {materialSlider1.Value}");
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {

    }

    private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
    {

        if (materialSwitch1.Checked)
        {
            TriggerSettings.toggleOn();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] TRIGGER BOT ON");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialSlider1.Show();
        }
        else
        {
            TriggerSettings.toggleOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] TRIGGER BOT OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialSlider1.Hide();
        }

    }

    private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        AimbotSettings.SetBone(materialComboBox1.Text.ToLower());
        Console.WriteLine($"[ + ] AIMBOT: BONE {materialComboBox1.Text} SELECTED");
    }

    private void materialSwitch2_CheckedChanged(object sender, EventArgs e)
    {
        if (materialSwitch2.Checked)
        {
            AimbotSettings.toggleOn();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] TRIGGER BOT ON");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Show();
        }
        else
        {
            AimbotSettings.toggleOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] TRIGGER BOT OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Hide();
        }
    }
}
