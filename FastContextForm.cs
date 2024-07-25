using Maverick_Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static Maverick_Utility.GlobalKeyboardHook;

namespace MaverickLabs
{
    public partial class FastContextForm : Form
    {
        private ContextMenuStrip contextMenu;
        private Dictionary<string, string> namePathPairs = new Dictionary<string, string>();
        private ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
        private GlobalKeyboardHook globalKeyboardHook;
        public FastContextForm(ContextMenuStrip menu)
        {
            InitializeComponent();
            contextMenu = menu;
            DisplayDictionaryInListBox();
            LoadContext();

            globalKeyboardHook = new GlobalKeyboardHook();
            globalKeyboardHook.KeyboardPressed += OnKeyPressed;
            contextTimer.Interval = 100;
            contextTimer.Tick += HideContextMenu;
        }

        private void HideContextMenu(object sender, EventArgs e)
        {
            if (contextMenu.Visible)
            {
                Point cursorPosition = Cursor.Position;
                Rectangle menuBounds = contextMenu.Bounds;

                if (DistanceToRectangle(cursorPosition, menuBounds) > 50)
                {
                    contextMenu.Hide();
                    contextTimer.Stop();
                }
            }
            else
            {
                contextTimer.Stop();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputContext("",null))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {

                    string customEventName = inputForm.EnteredText;
                    string folderPath = inputForm.Path;
                    listBox1.Items.Add($"Name: {inputForm.EnteredText}  Path: {inputForm.Path}");
                    namePathPairs.Add(inputForm.EnteredText, inputForm.Path);
                    SaveContext();
                    DisplayDictionaryInListBox();
                    //MessageBox.Show($"Text {inputForm.EnteredText}  Path {inputForm.Path}");
                }
            }
        }
        private void DisplayDictionaryInListBox()
        {
            ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
            Dictionary<string, string> dick = saveLoad.LoadDictionary("dictionary.json");
            listBox1.Items.Clear();
            foreach (var pair in dick)
            {
                listBox1.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            AddItemToContext(namePathPairs);
            SaveContext();
        }
        private void LoadContext()
        {
           namePathPairs = saveLoad.LoadDictionary("dictionary.json");
           AddItemToContext(namePathPairs);
        }
        private void SaveContext()
        {
            saveLoad.SaveDictionary("dictionary.json", namePathPairs);
        }
        private void AddItemToContext(Dictionary<string, string> keyValues)
        {
            contextMenu.Items.Clear();
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string selectedKey = listBox1.SelectedItems[0].ToString();
            string key = selectedKey.Split(':')[0].Trim();
            string path = null;
            if (namePathPairs.TryGetValue(key, out string value)) path = value;

            using (var inputForm = new InputContext(key,path))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    namePathPairs.Remove(key);
                    string customEventName = inputForm.EnteredText;
                    string folderPath = inputForm.Path;
                    listBox1.Items.Add($"Name: {inputForm.EnteredText}  Path: {inputForm.Path}");
                    namePathPairs.Add(inputForm.EnteredText, inputForm.Path);

                    SaveContext();
                    DisplayDictionaryInListBox();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string selectedKey = listBox1.SelectedItems[0].ToString();
            if (selectedKey != null)
            {
                string key = selectedKey.Split(':')[0].Trim();
                namePathPairs.Remove(key);
                SaveContext();
                DisplayDictionaryInListBox();
            }
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.VirtualCode == (int)Keys.F && Control.ModifierKeys == Keys.Shift)
            {
                var cursorPos = Cursor.Position;
                contextTimer.Start();
                contextMenu.Show(cursorPos);
            }
        }
        private int DistanceToRectangle(Point point, Rectangle rect)
        {
            int dx = Math.Max(rect.Left - point.X, Math.Max(0, point.X - rect.Right));
            int dy = Math.Max(rect.Top - point.Y, Math.Max(0, point.Y - rect.Bottom));
            return (int)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
