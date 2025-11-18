namespace EventPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Subscribe to our custom events
            ColorChangedEvent += HandleColorChange;
            ColorChangedEvent += ShowNotification;
            TextChangedEvent += HandleTextChange;
        }

        // Custom delegates declaration
        public delegate void ColorChangedEventHandler(object sender, ColorEventArgs e);
        public delegate void TextChangedEventHandler(object sender, EventArgs e);

        // Custom events declaration  
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        // Method to raise ColorChangedEvent
        protected virtual void OnColorChanged(ColorEventArgs e)
        {
            ColorChangedEvent?.Invoke(this, e);
        }

        // Method to raise TextChangedEvent  
        protected virtual void OnTextChanged(EventArgs e)
        {
            TextChangedEvent?.Invoke(this, e);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void cmbColours_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            string selectedColor = cmbColours.SelectedItem?.ToString() ?? "Unknown";
            ColorEventArgs colorArgs = new ColorEventArgs(selectedColor);
            OnColorChanged(colorArgs);  // Pass color data through event
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            OnTextChanged(EventArgs.Empty);   // This triggers our custom event
        }

        private void HandleColorChange(object sender, ColorEventArgs e)
        {
            // Now we get color directly from EventArgs instead of combobox
            string selectedColor = e.SelectedColor;

            if (!string.IsNullOrEmpty(selectedColor) && selectedColor != "Unknown")
            {
                switch (selectedColor.ToLower())
                {
                    case "red":
                        lblDisplay.ForeColor = Color.Red;
                        break;
                    case "green":
                        lblDisplay.ForeColor = Color.Green;
                        break;
                    case "blue":
                        lblDisplay.ForeColor = Color.Blue;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a color first!");
            }
        }

        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show($"Selected color: {e.SelectedColor}",
                           "Color Change Notification",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void HandleTextChange(object sender, EventArgs e)
        {
            // Update label text to current date and time
            lblDisplay.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

    // Custom EventArgs class for color data
    public class ColorEventArgs : EventArgs
    {
        public string SelectedColor { get; }

        public ColorEventArgs(string colorName)
        {
            SelectedColor = colorName;
        }
    }
}
