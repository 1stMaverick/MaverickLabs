using System;
using System.Drawing;
using System.Windows.Forms;

namespace MaverickLabs.Other
{
    public class WatermarkTextBox : TextBox
    {
        private string _placeholderText = "";
        private bool _isPlaceholderActive;

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set { _placeholderText = value; SetPlaceholder(); }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.Text = _placeholderText;
                this.ForeColor = Color.Gray;
                _isPlaceholderActive = true;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (_isPlaceholderActive)
            {
                this.Text = "";
                this.ForeColor = SystemColors.WindowText;
                _isPlaceholderActive = false;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                SetPlaceholder();
            }
        }
    }
}
