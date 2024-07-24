using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MaverickLabs
{
    public partial class Form1 : Form
    {
        private ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            notifyIcon1.BalloonTipTitle = "Maverick Lab's";
            notifyIcon1.BalloonTipText = "Maverick Lab's in tray";
            notifyIcon1.Text = "Maverick Lab's";
            LoadContext();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                var cursorPos = Cursor.Position;
                contextMenu.Show(cursorPos);
            }
            if (e.KeyCode == Keys.Delete)
            {
                contextMenu.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> namePathPairs = new Dictionary<string, string>();
            using (var inputForm = new FastContextForm(contextMenu))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    namePathPairs = inputForm.namePathPairs;

                    AddItemToContext(namePathPairs);
                    saveLoad.SaveDictionary("dictionary.json", namePathPairs);
                }
            }
        }

        private void AddItemToContext(Dictionary<string, string> keyValues)
        {
            foreach (var kvp in keyValues)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(kvp.Key);
                menuItem.Tag = kvp.Value;
                menuItem.Click += MenuItem_Click;
                contextMenu.Items.Add(menuItem);
            }
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                string folderPath = menuItem.Tag as string;
                if (!string.IsNullOrEmpty(folderPath))
                {
                    Process.Start("explorer.exe", folderPath);
                }
            }
        }
        private void LoadContext()
        {
            AddItemToContext(saveLoad.LoadDictionary("dictionary.json"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cursorPos = Cursor.Position;
            contextMenu.Show(cursorPos);
        }
    }
}
