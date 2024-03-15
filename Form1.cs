namespace LevKep
{
    public partial class Form1 : Form
    {
        FileHandler fileHandler;
        string appBaseName;

        public Form1()
        {
            InitializeComponent();
            SetFeatureToAllControls(this.Controls);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeFromImage(StartupFileHandler.filePath);
        }

        private void InitializeFromImage(string imagePath)
        {
            appBaseName = this.Text;
            this.BackColor = Color.White;
            fileHandler = new FileHandler(imagePath);
            if (!fileHandler.IsValid)
            {
                button_left.Enabled = false;
                button_right.Enabled = false;
            }
            else
            {
                button_left.Enabled = true;
                button_right.Enabled = true;
                this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
            }
            pictureBox1.Image = fileHandler.GetCurrentImage();
            
        }

        private void InitializeFromFolder(string folderPath)
        {
            appBaseName = this.Text;
            this.BackColor = Color.White;
            fileHandler = new FileHandler(folderPath, 0);
            if (!fileHandler.IsValid)
            {
                button_left.Enabled = false;
                button_right.Enabled = false;
            }
            else
            {
                button_left.Enabled = true;
                button_right.Enabled = true;
                this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
            }
            pictureBox1.Image = fileHandler.GetCurrentImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_left_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = fileHandler.GetPreviousImage();
            this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = fileHandler.GetNextImage();
            this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!fileHandler.IsValid)
            {
                e.Handled = true;
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Space:
                    button_left.Visible = !button_left.Visible;
                    button_right.Visible = !button_right.Visible;
                    menuStrip1.Visible = !menuStrip1.Visible;
                    break;
                case Keys.Left:
                    pictureBox1.Image = fileHandler.GetPreviousImage();
                    this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
                    break;
                case Keys.Right:
                    pictureBox1.Image = fileHandler.GetNextImage();
                    this.Text = appBaseName + ": " + fileHandler.GetCurrentImageName();
                    break;
                case Keys.T:
                    if (this.BackColor == Color.Black) this.BackColor = Color.White;
                    else this.BackColor = Color.Black;
                    break;
            }
            e.Handled = true;
        }

        private void SetFeatureToAllControls(Control.ControlCollection cc)
        {
            if (cc != null)
            {
                foreach (Control control in cc)
                {
                    control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
                    SetFeatureToAllControls(control.Controls);
                }
            }
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kepMegnyitasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Valassz ki egy kepet";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
            {
                InitializeFromImage(ofd.FileName);
            }
        }

        private void mappaMegnyitasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                InitializeFromFolder(fbd.SelectedPath);
            }
        }
    }
}
