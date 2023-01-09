namespace multihack;

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
            this.materialSlider10 = new MaterialSkin.Controls.MaterialSlider();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialSlider9 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider8 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider7 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider6 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider5 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider3 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider4 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider2 = new MaterialSkin.Controls.MaterialSlider();
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
            this.tabPage2.Controls.Add(this.materialSlider10);
            this.tabPage2.Controls.Add(this.materialCheckbox3);
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
            // materialSlider10
            // 
            this.materialSlider10.Depth = 0;
            this.materialSlider10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider10.Location = new System.Drawing.Point(438, 115);
            this.materialSlider10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider10.Name = "materialSlider10";
            this.materialSlider10.RangeMax = 50;
            this.materialSlider10.Size = new System.Drawing.Size(233, 40);
            this.materialSlider10.TabIndex = 4;
            this.materialSlider10.Text = "Sensitivity";
            this.materialSlider10.Value = 1;
            this.materialSlider10.Click += new System.EventHandler(this.materialSlider10_Click);
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(438, 23);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(160, 37);
            this.materialCheckbox3.TabIndex = 3;
            this.materialCheckbox3.Text = "Enable Sensitivity";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            this.materialCheckbox3.CheckedChanged += new System.EventHandler(this.materialCheckbox3_CheckedChanged);
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
            this.tabPage1.Controls.Add(this.materialTextBox22);
            this.tabPage1.Controls.Add(this.materialTextBox21);
            this.tabPage1.Controls.Add(this.materialSlider9);
            this.tabPage1.Controls.Add(this.materialSlider8);
            this.tabPage1.Controls.Add(this.materialSlider7);
            this.tabPage1.Controls.Add(this.materialSlider6);
            this.tabPage1.Controls.Add(this.materialSlider5);
            this.tabPage1.Controls.Add(this.materialSlider3);
            this.tabPage1.Controls.Add(this.materialSlider4);
            this.tabPage1.Controls.Add(this.materialSlider2);
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
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.LeadingIcon = null;
            this.materialTextBox22.Location = new System.Drawing.Point(466, 53);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox22.TabIndex = 13;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.Text = "Enemy Team";
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(53, 53);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(250, 48);
            this.materialTextBox21.TabIndex = 12;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "Team";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialSlider9
            // 
            this.materialSlider9.Depth = 0;
            this.materialSlider9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider9.Location = new System.Drawing.Point(473, 235);
            this.materialSlider9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider9.Name = "materialSlider9";
            this.materialSlider9.RangeMax = 10;
            this.materialSlider9.Size = new System.Drawing.Size(250, 40);
            this.materialSlider9.TabIndex = 11;
            this.materialSlider9.Text = "Red";
            this.materialSlider9.Value = 1;
            this.materialSlider9.Click += new System.EventHandler(this.materialSlider9_Click);
            // 
            // materialSlider8
            // 
            this.materialSlider8.Depth = 0;
            this.materialSlider8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider8.Location = new System.Drawing.Point(473, 168);
            this.materialSlider8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider8.Name = "materialSlider8";
            this.materialSlider8.RangeMax = 10;
            this.materialSlider8.Size = new System.Drawing.Size(250, 40);
            this.materialSlider8.TabIndex = 10;
            this.materialSlider8.Text = "Red";
            this.materialSlider8.Value = 1;
            this.materialSlider8.Click += new System.EventHandler(this.materialSlider8_Click);
            // 
            // materialSlider7
            // 
            this.materialSlider7.Depth = 0;
            this.materialSlider7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider7.Location = new System.Drawing.Point(473, 292);
            this.materialSlider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider7.Name = "materialSlider7";
            this.materialSlider7.RangeMax = 10;
            this.materialSlider7.Size = new System.Drawing.Size(250, 40);
            this.materialSlider7.TabIndex = 10;
            this.materialSlider7.Text = "Red";
            this.materialSlider7.Value = 1;
            this.materialSlider7.Click += new System.EventHandler(this.materialSlider7_Click);
            // 
            // materialSlider6
            // 
            this.materialSlider6.Depth = 0;
            this.materialSlider6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider6.Location = new System.Drawing.Point(469, 104);
            this.materialSlider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider6.Name = "materialSlider6";
            this.materialSlider6.RangeMax = 10;
            this.materialSlider6.Size = new System.Drawing.Size(250, 40);
            this.materialSlider6.TabIndex = 9;
            this.materialSlider6.Text = "Red";
            this.materialSlider6.Value = 1;
            this.materialSlider6.Click += new System.EventHandler(this.materialSlider6_Click);
            // 
            // materialSlider5
            // 
            this.materialSlider5.Depth = 0;
            this.materialSlider5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider5.Location = new System.Drawing.Point(53, 292);
            this.materialSlider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider5.Name = "materialSlider5";
            this.materialSlider5.RangeMax = 10;
            this.materialSlider5.Size = new System.Drawing.Size(250, 40);
            this.materialSlider5.TabIndex = 8;
            this.materialSlider5.Text = "Red";
            this.materialSlider5.Value = 1;
            this.materialSlider5.Click += new System.EventHandler(this.materialSlider5_Click);
            // 
            // materialSlider3
            // 
            this.materialSlider3.Depth = 0;
            this.materialSlider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider3.Location = new System.Drawing.Point(53, 235);
            this.materialSlider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider3.Name = "materialSlider3";
            this.materialSlider3.RangeMax = 10;
            this.materialSlider3.Size = new System.Drawing.Size(250, 40);
            this.materialSlider3.TabIndex = 7;
            this.materialSlider3.Text = "Red";
            this.materialSlider3.Value = 1;
            this.materialSlider3.Click += new System.EventHandler(this.materialSlider3_Click);
            // 
            // materialSlider4
            // 
            this.materialSlider4.Depth = 0;
            this.materialSlider4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider4.Location = new System.Drawing.Point(53, 168);
            this.materialSlider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider4.Name = "materialSlider4";
            this.materialSlider4.RangeMax = 10;
            this.materialSlider4.Size = new System.Drawing.Size(250, 40);
            this.materialSlider4.TabIndex = 6;
            this.materialSlider4.Text = "Red";
            this.materialSlider4.Value = 1;
            this.materialSlider4.Click += new System.EventHandler(this.materialSlider4_Click);
            // 
            // materialSlider2
            // 
            this.materialSlider2.Depth = 0;
            this.materialSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider2.Location = new System.Drawing.Point(53, 104);
            this.materialSlider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider2.Name = "materialSlider2";
            this.materialSlider2.RangeMax = 10;
            this.materialSlider2.RangeMin = 1;
            this.materialSlider2.Size = new System.Drawing.Size(250, 40);
            this.materialSlider2.TabIndex = 3;
            this.materialSlider2.Text = "Red";
            this.materialSlider2.Value = 1;
            this.materialSlider2.Click += new System.EventHandler(this.materialSlider2_Click);
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(558, 13);
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
            this.materialCheckbox1.Location = new System.Drawing.Point(327, 13);
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
            this.materialSwitch3.Location = new System.Drawing.Point(53, 13);
            this.materialSwitch3.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch3.Name = "materialSwitch3";
            this.materialSwitch3.Ripple = true;
            this.materialSwitch3.Size = new System.Drawing.Size(208, 37);
            this.materialSwitch3.TabIndex = 0;
            this.materialSwitch3.Text = "Enable ESP Wallhack";
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
    private MaterialSkin.Controls.MaterialSlider materialSlider2;
    private MaterialSkin.Controls.MaterialSlider materialSlider9;
    private MaterialSkin.Controls.MaterialSlider materialSlider8;
    private MaterialSkin.Controls.MaterialSlider materialSlider7;
    private MaterialSkin.Controls.MaterialSlider materialSlider6;
    private MaterialSkin.Controls.MaterialSlider materialSlider5;
    private MaterialSkin.Controls.MaterialSlider materialSlider3;
    private MaterialSkin.Controls.MaterialSlider materialSlider4;
    private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
    private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
    private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
    private MaterialSkin.Controls.MaterialSlider materialSlider10;
}
