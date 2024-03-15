namespace LevKep
{
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
            pictureBox1 = new PictureBox();
            button_left = new Button();
            button_right = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            kepMegnyitasaToolStripMenuItem = new ToolStripMenuItem();
            mappaMegnyitasaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1055, 608);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_left
            // 
            button_left.Anchor = AnchorStyles.Bottom;
            button_left.Location = new Point(475, 597);
            button_left.Name = "button_left";
            button_left.Size = new Size(50, 23);
            button_left.TabIndex = 1;
            button_left.Text = "<";
            button_left.UseVisualStyleBackColor = true;
            button_left.Click += button_left_Click;
            // 
            // button_right
            // 
            button_right.Anchor = AnchorStyles.Bottom;
            button_right.Location = new Point(532, 597);
            button_right.Name = "button_right";
            button_right.Size = new Size(50, 23);
            button_right.TabIndex = 2;
            button_right.Text = ">";
            button_right.UseVisualStyleBackColor = true;
            button_right.Click += button_right_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1055, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kepMegnyitasaToolStripMenuItem, mappaMegnyitasaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // kepMegnyitasaToolStripMenuItem
            // 
            kepMegnyitasaToolStripMenuItem.Name = "kepMegnyitasaToolStripMenuItem";
            kepMegnyitasaToolStripMenuItem.Size = new Size(180, 22);
            kepMegnyitasaToolStripMenuItem.Text = "Kep megnyitasa";
            kepMegnyitasaToolStripMenuItem.Click += kepMegnyitasaToolStripMenuItem_Click;
            // 
            // mappaMegnyitasaToolStripMenuItem
            // 
            mappaMegnyitasaToolStripMenuItem.Name = "mappaMegnyitasaToolStripMenuItem";
            mappaMegnyitasaToolStripMenuItem.Size = new Size(180, 22);
            mappaMegnyitasaToolStripMenuItem.Text = "Mappa megnyitasa";
            mappaMegnyitasaToolStripMenuItem.Click += mappaMegnyitasaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1055, 632);
            Controls.Add(button_right);
            Controls.Add(button_left);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "LevKep";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_left;
        private Button button_right;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem kepMegnyitasaToolStripMenuItem;
        private ToolStripMenuItem mappaMegnyitasaToolStripMenuItem;
    }
}
