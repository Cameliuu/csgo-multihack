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
        materialCheckbox1.Hide();
        materialCheckbox2.Hide();
        materialSlider2.Hide();
        materialSlider3.Hide();
        materialSlider4.Hide();
        materialSlider5.Hide();
        materialSlider6.Hide();
        materialSlider7.Hide();
        materialSlider8.Hide();
        materialSlider9.Hide();
        materialTextBox21.Hide();
        materialTextBox22.Hide();
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
            Console.WriteLine("[ + ] AIM BOT ON");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Show();
        }
        else
        {
            AimbotSettings.toggleOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] AIM BOT OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Hide();
        }
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void materialSwitch3_CheckedChanged(object sender, EventArgs e)
    {
        if (materialSwitch3.Checked)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] ESP ON");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Show();
            materialCheckbox2.Show();
 
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] ESP OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
            materialComboBox1.Hide();
            materialCheckbox2.Hide();
        }
    }

    private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
    {
        if (materialCheckbox1.Checked)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] BOXES ON");
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
        else
        {
  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] BOXES OFF");
            Console.ForegroundColor = ConsoleColor.Gray;            
        }
    }

    private void materialCheckbox2_CheckedChanged_1(object sender, EventArgs e)
    {
        if (materialCheckbox2.Checked)
        {
            materialSlider2.Show();
            materialSlider3.Show();
            materialSlider4.Show();
            materialSlider5.Show();
            materialSlider6.Show();
            materialSlider7.Show();
            materialSlider8.Show();
            materialSlider9.Show();
            materialTextBox21.Show();
            materialTextBox22.Show();
            ESPSettings.toggleOn();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ + ] GLOW ON");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        else
        {
            materialSlider2.Hide();
            materialSlider3.Hide();
            materialSlider4.Hide();
            materialSlider5.Hide();
            materialSlider6.Hide();
            materialSlider7.Hide();
            materialSlider8.Hide();
            materialSlider9.Hide();
            materialTextBox21.Hide();
            materialTextBox22.Hide();
            ESPSettings.toggleOff();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ + ] GLOW OFF");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    private void materialSlider2_Click(object sender, EventArgs e)
    {
        ESPSettings.SetTeamGlow(0, (float)materialSlider2.Value/10);
    }

    private void materialSlider4_Click(object sender, EventArgs e)
    {
        ESPSettings.SetTeamGlow(1, (float)materialSlider4.Value/10);
    }

    private void materialSlider3_Click(object sender, EventArgs e)
    {
        ESPSettings.SetTeamGlow(2, (float)materialSlider3.Value/10);
    }

    private void materialSlider5_Click(object sender, EventArgs e)
    {
        ESPSettings.SetTeamGlow(3, (float)materialSlider5.Value/10);
    }

    private void materialSlider6_Click(object sender, EventArgs e)
    {
        Console.WriteLine($"Setting enemy red to:{(float)materialSlider6.Value/10}");
        ESPSettings.SetEnemyGlow(0, (float)materialSlider6.Value/10);
    }

    private void materialSlider8_Click(object sender, EventArgs e)
    {
        ESPSettings.SetEnemyGlow(1, (float)materialSlider8.Value / 10);
    }

    private void materialSlider9_Click(object sender, EventArgs e)
    {
        ESPSettings.SetEnemyGlow(2, (float)materialSlider9.Value / 10);
    }

    private void materialSlider7_Click(object sender, EventArgs e)
    {
        ESPSettings.SetEnemyGlow(3, (float)materialSlider7.Value / 10);
    }
}
