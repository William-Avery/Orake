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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.p_menubar = new System.Windows.Forms.Panel();
            this.p_minimize = new System.Windows.Forms.Panel();
            this.p_exitbutton = new System.Windows.Forms.Panel();
            this.p_menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // p_menubar
            // 
            this.p_menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_menubar.Controls.Add(this.p_minimize);
            this.p_menubar.Controls.Add(this.p_exitbutton);
            this.p_menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_menubar.Location = new System.Drawing.Point(0, 0);
            this.p_menubar.Name = "p_menubar";
            this.p_menubar.Size = new System.Drawing.Size(380, 21);
            this.p_menubar.TabIndex = 2;
            this.p_menubar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_menubar_MouseDown);
            // 
            // p_minimize
            // 
            this.p_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_minimize.Location = new System.Drawing.Point(296, 0);
            this.p_minimize.Name = "p_minimize";
            this.p_minimize.Size = new System.Drawing.Size(42, 21);
            this.p_minimize.TabIndex = 4;
            // 
            // p_exitbutton
            // 
            this.p_exitbutton.BackgroundImage = global::OrakeBot.Properties.Resources.ExitButton;
            this.p_exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_exitbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_exitbutton.Location = new System.Drawing.Point(338, 0);
            this.p_exitbutton.Name = "p_exitbutton";
            this.p_exitbutton.Size = new System.Drawing.Size(42, 21);
            this.p_exitbutton.TabIndex = 3;
            this.p_exitbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseClick);
            this.p_exitbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseDown);
            this.p_exitbutton.MouseEnter += new System.EventHandler(this.p_exitbutton_MouseEnter);
            this.p_exitbutton.MouseLeave += new System.EventHandler(this.p_exitbutton_MouseLeave);
            this.p_exitbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_exitbutton_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(380, 353);
            this.Controls.Add(this.p_menubar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrakeBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_menubar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel p_menubar;
        private System.Windows.Forms.Panel p_minimize;
        private System.Windows.Forms.Panel p_exitbutton;
    }
}

