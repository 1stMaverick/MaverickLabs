using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class InputContext : Form
    {
        public string EnteredText { get; private set; }
        public string Path { get; private set; }
        public InputContext(string name,string path)
        {
            InitializeComponent();
            EnteredText = name;
            Path = path;
            textBox1.Text = EnteredText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if(Path != null) folderDialog.SelectedPath = Path;
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    Path = folderDialog.SelectedPath;
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
                MessageBox.Show("Name = null", "Maverick Lab's", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return;
            }
            if (Path == null)
            {
                button1.BackColor = Color.Red;
                MessageBox.Show("Folder path = null", "Maverick Lab's", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

    }
}
