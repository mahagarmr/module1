namespace task3
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
            beepButton = new Button();
            messageBeepButton = new Button();
            frequencyTextBox = new TextBox();
            durationTextBox = new TextBox();
            durationLabel = new Label();
            frequncyLabel = new Label();
            SuspendLayout();
            // 
            // beepButton
            // 
            beepButton.Location = new Point(261, 50);
            beepButton.Name = "beepButton";
            beepButton.Size = new Size(100, 23);
            beepButton.TabIndex = 0;
            beepButton.Text = "Beep";
            beepButton.UseVisualStyleBackColor = true;
            beepButton.Click += beepButton_Click;
            // 
            // messageBeepButton
            // 
            messageBeepButton.Location = new Point(261, 5);
            messageBeepButton.Name = "messageBeepButton";
            messageBeepButton.Size = new Size(100, 23);
            messageBeepButton.TabIndex = 1;
            messageBeepButton.Text = "Message beep";
            messageBeepButton.UseVisualStyleBackColor = true;
            messageBeepButton.Click += messageBeepButton_Click;
            // 
            // frequencyTextBox
            // 
            frequencyTextBox.Location = new Point(12, 27);
            frequencyTextBox.Name = "frequencyTextBox";
            frequencyTextBox.Size = new Size(100, 23);
            frequencyTextBox.TabIndex = 2;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(133, 27);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(100, 23);
            durationTextBox.TabIndex = 3;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(133, 9);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(53, 15);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Duration";
            // 
            // frequncyLabel
            // 
            frequncyLabel.AutoSize = true;
            frequncyLabel.Location = new Point(12, 9);
            frequncyLabel.Name = "frequncyLabel";
            frequncyLabel.Size = new Size(62, 15);
            frequncyLabel.TabIndex = 5;
            frequncyLabel.Text = "Frequency";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 78);
            Controls.Add(frequncyLabel);
            Controls.Add(durationLabel);
            Controls.Add(durationTextBox);
            Controls.Add(frequencyTextBox);
            Controls.Add(messageBeepButton);
            Controls.Add(beepButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button beepButton;
        private Button messageBeepButton;
        private TextBox frequencyTextBox;
        private TextBox durationTextBox;
        private Label durationLabel;
        private Label frequncyLabel;
    }
}