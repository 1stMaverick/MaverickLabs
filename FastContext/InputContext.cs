using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class InputContext : Form
    {
        public string EnteredText { get; private set; }
        public string PathFolder { get; private set; }
        public string PathExe { get; private set; }
        public InputContext(string name,string path)
        {
            InitializeComponent();
            EnteredText = name;
            PathFolder = path;
            textBox1.Text = EnteredText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if(PathFolder != null) folderDialog.SelectedPath = PathFolder;
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    PathFolder = folderDialog.SelectedPath;
                    button1.BackColor = Color.Green;

                }
                else button1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnteredText = textBox1.Text;
            if(EnteredText == "")
            {
                textBox1.BackColor = Color.Red;
                //MessageBox.Show("Name = null", "Maverick Lab's", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return;
            }
            if (PathFolder == null)
            {
                button1.BackColor = Color.Red;
                //MessageBox.Show("Folder path = null", "Maverick Lab's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }else if(PathExe == null)
            {
                pickExe.BackColor = Color.Red;

                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pickExe_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    MessageBox.Show("Выбранный файл: " + filePath);
                    PathExe = filePath;
                }
            }
        }
    }
}
