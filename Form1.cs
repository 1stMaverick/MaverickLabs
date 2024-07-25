using Maverick_Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static Maverick_Utility.GlobalKeyboardHook;

namespace MaverickLabs
{
    public partial class Form1 : Form
    {
        private ContextMenuSaveLoad saveLoad = new ContextMenuSaveLoad();
        private FastContextForm FastContext;
        private GlobalKeyboardHook globalKeyboardHook;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            notifyIcon1.BalloonTipTitle = "Maverick Lab's";
            notifyIcon1.BalloonTipText = "Maverick Lab's in tray";
            notifyIcon1.Text = "Maverick Lab's";
            FastContext = new FastContextForm(contextMenu);

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

                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var cursorPos = Cursor.Position;
            contextMenu.Show(cursorPos);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }
    }
}
