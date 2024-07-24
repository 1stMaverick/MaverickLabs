using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaverickLabs
{
    public partial class FastContextForm : Form
    {
        private ContextMenuStrip contextMenu;
        public Dictionary<string, string> namePathPairs = new Dictionary<string, string>();
        public FastContextForm(ContextMenuStrip menu)
        {
            InitializeComponent();
            contextMenu = menu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputContext())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {

                    string customEventName = inputForm.EnteredText;
                    string folderPath = inputForm.Path;
                    listBox1.Items.Add($"Name: {inputForm.EnteredText}  Path: {inputForm.Path}");
                    namePathPairs.Add(inputForm.EnteredText, inputForm.Path);
                    MessageBox.Show($"Text {inputForm.EnteredText}  Path {inputForm.Path}");
                }
            }
        }
        private void DisplayDictionaryInListBox()
        {
            ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
            Dictionary<string, string> dick = saveLoad.LoadDictionary("dictionary.xml");
            listBox1.Items.Clear();
            foreach (var pair in dick)
            {
                listBox1.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
