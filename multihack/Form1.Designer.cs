﻿namespace multihack;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.TriggerBot = new System.Windows.Forms.TabPage();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSwitch3 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1.SuspendLayout();
            this.TriggerBot.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.TriggerBot);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(727, 377);
            this.materialTabControl1.TabIndex = 0;
            // 
            // TriggerBot
            // 
            this.TriggerBot.Controls.Add(this.materialSwitch1);
            this.TriggerBot.Controls.Add(this.materialSlider1);
            this.TriggerBot.Location = new System.Drawing.Point(4, 24);
            this.TriggerBot.Name = "TriggerBot";
            this.TriggerBot.Padding = new System.Windows.Forms.Padding(3);
            this.TriggerBot.Size = new System.Drawing.Size(719, 349);
            this.TriggerBot.TabIndex = 0;
            this.TriggerBot.Text = "Trigger Bot";
            this.TriggerBot.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(37, 53);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(184, 37);
            this.materialSwitch1.TabIndex = 3;
            this.materialSwitch1.Text = "Enable TriggerBot";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(37, 158);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 5;
            this.materialSlider1.RangeMin = 1;
            this.materialSlider1.Size = new System.Drawing.Size(250, 40);
            this.materialSlider1.TabIndex = 2;
            this.materialSlider1.Text = "TriggerBot Intensity";
            this.materialSlider1.Click += new System.EventHandler(this.materialSlider1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialSwitch2);
            this.tabPage2.Controls.Add(this.materialComboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aim Bot";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.AutoSize = true;
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Location = new System.Drawing.Point(40, 23);
            this.materialSwitch2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch2.Name = "materialSwitch2";
            this.materialSwitch2.Ripple = true;
            this.materialSwitch2.Size = new System.Drawing.Size(161, 37);
            this.materialSwitch2.TabIndex = 2;
            this.materialSwitch2.Text = "Enable Aimbot";
            this.materialSwitch2.UseVisualStyleBackColor = true;
            this.materialSwitch2.CheckedChanged += new System.EventHandler(this.materialSwitch2_CheckedChanged);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Head",
            "Torso",
            "Right Hand",
            "Left Hand",
            "Right Leg",
            "Left Leg",
            "Right Foot",
            "Left Foot",
            "Below Legs"});
            this.materialComboBox1.Location = new System.Drawing.Point(40, 100);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(284, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCheckbox2);
            this.tabPage1.Controls.Add(this.materialCheckbox1);
            this.tabPage1.Controls.Add(this.materialSwitch3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(719, 349);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "ESP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(63, 196);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(71, 37);
            this.materialCheckbox2.TabIndex = 2;
            this.materialCheckbox2.Text = "Glow";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            this.materialCheckbox2.CheckedChanged += new System.EventHandler(this.materialCheckbox2_CheckedChanged_1);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(63, 120);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(78, 37);
            this.materialCheckbox1.TabIndex = 1;
            this.materialCheckbox1.Text = "Boxes";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // materialSwitch3
            // 
            this.materialSwitch3.AutoSize = true;
            this.materialSwitch3.Depth = 0;
            this.materialSwitch3.Location = new System.Drawing.Point(63, 36);
            this.materialSwitch3.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch3.Name = "materialSwitch3";
            this.materialSwitch3.Ripple = true;
            this.materialSwitch3.Size = new System.Drawing.Size(173, 37);
            this.materialSwitch3.TabIndex = 0;
            this.materialSwitch3.Text = "materialSwitch3";
            this.materialSwitch3.UseVisualStyleBackColor = true;
            this.materialSwitch3.CheckedChanged += new System.EventHandler(this.materialSwitch3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "CS:GO Multi-Hack by Camilatron";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.TriggerBot.ResumeLayout(false);
            this.TriggerBot.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    private TabPage TriggerBot;
    private TabPage tabPage2;
    private MaterialSkin.Controls.MaterialSlider materialSlider1;
    private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
    private TabPage tabPage1;
    private MaterialSkin.Controls.MaterialSwitch materialSwitch3;
    private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
    private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
}
