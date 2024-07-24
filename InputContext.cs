using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class InputContext : Form
    {
        public string EnteredText { get; private set; }
        public string Path { get; private set; }
        public InputContext()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    Path = folderDialog.SelectedPath;
                    

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnteredText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
