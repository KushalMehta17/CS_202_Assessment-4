namespace EventPlayground
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDisplay = new Label();
            btnChangeColour = new Button();
            btnChangeText = new Button();
            cmbColours = new ComboBox();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(255, 101);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(321, 38);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "Welcome to Events Lab";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplay.Click += label1_Click;
            // 
            // btnChangeColour
            // 
            btnChangeColour.Location = new Point(139, 200);
            btnChangeColour.Name = "btnChangeColour";
            btnChangeColour.Size = new Size(170, 41);
            btnChangeColour.TabIndex = 1;
            btnChangeColour.Text = "Change Colour";
            btnChangeColour.UseVisualStyleBackColor = true;
            btnChangeColour.Click += btnChangeColour_Click;
            // 
            // btnChangeText
            // 
            btnChangeText.Location = new Point(538, 200);
            btnChangeText.Name = "btnChangeText";
            btnChangeText.Size = new Size(169, 41);
            btnChangeText.TabIndex = 2;
            btnChangeText.Text = "Change Text";
            btnChangeText.UseVisualStyleBackColor = true;
            btnChangeText.Click += btnChangeText_Click;
            // 
            // cmbColours
            // 
            cmbColours.FormattingEnabled = true;
            cmbColours.Items.AddRange(new object[] { "Red", "Green", "Blue" });
            cmbColours.Location = new Point(311, 291);
            cmbColours.Name = "cmbColours";
            cmbColours.Size = new Size(151, 28);
            cmbColours.TabIndex = 3;
            cmbColours.SelectedIndexChanged += cmbColours_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbColours);
            Controls.Add(btnChangeText);
            Controls.Add(btnChangeColour);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisplay;
        private Button btnChangeColour;
        private Button btnChangeText;
        private ComboBox cmbColours;
    }
}
