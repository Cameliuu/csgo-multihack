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
           
            Entities.SetAimbotHeight(Height);
            Entities.SetAimbotWitdh(Width);
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
            Graphics g =e.Graphics;
            float pixdist = 50;
            Pen fovpen = new Pen(Color.LightGray, 2);
            Entities.SetAimbotFOV(pixdist);
            g.DrawEllipse(fovpen, (Width / 2) - 50, (Height / 2) - 36, 100, 100);

        }
            
        }
    }



