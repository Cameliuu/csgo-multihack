using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using ezOverLay;
using MaterialSkin.Controls;

namespace multihack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ez ez = new ez();
            ez.SetInvi(this);
            ez.DoStuff("Counter-Strike: Global Offensive - Direct3D 9", this);
            RefreshForm();

        }

        public  void RefreshForm()
        {
            Form2 f = this;
            f.Refresh();
            Thread.Sleep(20);
            Console.WriteLine("[ + ] REFRESHING ESP FORM");
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen red = new Pen(Color.Red, 3);
            Pen green = new Pen(Color.Green, 3);
           if(Entities.GetEntitiesList().Count > 0)
            {
                foreach (var ent in Entities.GetEntitiesList())
                {
                    
                    if (ent.GetTeam() == Entities.GetLocalPlayer().GetTeam())// && ent.GetBot().X > 0 && ent.GetBot().X < Width && ent.GetBot().Y > 0 && ent.GetBot().Y < Height)
                    {
                        g.DrawRectangle(green, ent.rect());
                        
                    }
                    else if (ent.GetTeam() != Entities.GetLocalPlayer().GetTeam())// && ent.GetBot().X > 0 && ent.GetBot().X < Width && ent.GetBot().Y > 0 && ent.GetBot().Y < Height)
                    {
                        g.DrawRectangle(red, ent.rect());
                        Console.WriteLine(ent.rect());

                    }
                }
            }
        }
    }
}

