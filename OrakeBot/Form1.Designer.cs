namespace OrakeBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b_start = new System.Windows.Forms.Button();
            this.p_menubar = new System.Windows.Forms.Panel();
            this.p_minimize = new System.Windows.Forms.Panel();
            this.p_exitbutton = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_playerx = new System.Windows.Forms.Label();
            this.l_playery = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_map = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_hp = new System.Windows.Forms.Label();
            this.l_stamina = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.t_updatePlayer = new System.Windows.Forms.Timer(this.components);
            this.p_menubar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(232, 110);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_menubar
            // 
            this.p_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_menubar.Controls.Add(this.label3);
            this.p_menubar.Controls.Add(this.p_minimize);
            this.p_menubar.Controls.Add(this.p_exitbutton);
            this.p_menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_menubar.Location = new System.Drawing.Point(0, 0);
            this.p_menubar.Name = "p_menubar";
            this.p_menubar.Size = new System.Drawing.Size(391, 21);
            this.p_menubar.TabIndex = 2;
            this.p_menubar.Paint += new System.Windows.Forms.PaintEventHandler(this.p_menubar_Paint);
            this.p_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_menubar_MouseDown);
            // 
            // p_minimize
            // 
            this.p_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_minimize.Location = new System.Drawing.Point(307, 0);
            this.p_minimize.Name = "p_minimize";
            this.p_minimize.Size = new System.Drawing.Size(42, 21);
            this.p_minimize.TabIndex = 4;
            // 
            // p_exitbutton
            // 
            this.p_exitbutton.BackgroundImage = global::OrakeBot.Properties.Resources.ExitButton;
            this.p_exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_exitbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_exitbutton.Location = new System.Drawing.Point(349, 0);
            this.p_exitbutton.Name = "p_exitbutton";
            this.p_exitbutton.Size = new System.Drawing.Size(42, 21);
            this.p_exitbutton.TabIndex = 3;
            this.p_exitbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseClick);
            this.p_exitbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseDown);
            this.p_exitbutton.MouseEnter += new System.EventHandler(this.p_exitbutton_MouseEnter);
            this.p_exitbutton.MouseLeave += new System.EventHandler(this.p_exitbutton_MouseLeave);
            this.p_exitbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_stamina);
            this.groupBox1.Controls.Add(this.l_hp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.l_map);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.l_playery);
            this.groupBox1.Controls.Add(this.l_playerx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // l_playerx
            // 
            this.l_playerx.AutoSize = true;
            this.l_playerx.Location = new System.Drawing.Point(63, 23);
            this.l_playerx.Name = "l_playerx";
            this.l_playerx.Size = new System.Drawing.Size(17, 20);
            this.l_playerx.TabIndex = 5;
            this.l_playerx.Text = "0";
            // 
            // l_playery
            // 
            this.l_playery.AutoSize = true;
            this.l_playery.Location = new System.Drawing.Point(63, 43);
            this.l_playery.Name = "l_playery";
            this.l_playery.Size = new System.Drawing.Size(17, 20);
            this.l_playery.TabIndex = 6;
            this.l_playery.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rebirth Bot v1.0";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Map:";
            // 
            // l_map
            // 
            this.l_map.AutoSize = true;
            this.l_map.Location = new System.Drawing.Point(63, 63);
            this.l_map.Name = "l_map";
            this.l_map.Size = new System.Drawing.Size(17, 20);
            this.l_map.TabIndex = 8;
            this.l_map.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "HP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "ST:";
            // 
            // l_hp
            // 
            this.l_hp.AutoSize = true;
            this.l_hp.Location = new System.Drawing.Point(63, 83);
            this.l_hp.Name = "l_hp";
            this.l_hp.Size = new System.Drawing.Size(17, 20);
            this.l_hp.TabIndex = 11;
            this.l_hp.Text = "0";
            // 
            // l_stamina
            // 
            this.l_stamina.AutoSize = true;
            this.l_stamina.Location = new System.Drawing.Point(63, 103);
            this.l_stamina.Name = "l_stamina";
            this.l_stamina.Size = new System.Drawing.Size(17, 20);
            this.l_stamina.TabIndex = 12;
            this.l_stamina.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(315, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "HP Pot";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(315, 70);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "ST Pot";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // t_updatePlayer
            // 
            this.t_updatePlayer.Enabled = true;
            this.t_updatePlayer.Tick += new System.EventHandler(this.t_updatePlayer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(391, 163);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.p_menubar);
            this.Controls.Add(this.b_start);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrakeBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_menubar.ResumeLayout(false);
            this.p_menubar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Panel p_menubar;
        private System.Windows.Forms.Panel p_minimize;
        private System.Windows.Forms.Panel p_exitbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_playery;
        private System.Windows.Forms.Label l_playerx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_map;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_stamina;
        private System.Windows.Forms.Label l_hp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Timer t_updatePlayer;
    }
}

