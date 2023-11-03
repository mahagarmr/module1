namespace task2
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
            changeTitleButton = new Button();
            closeButton = new Button();
            newTitleTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // changeTitleButton
            // 
            changeTitleButton.Location = new Point(12, 56);
            changeTitleButton.Name = "changeTitleButton";
            changeTitleButton.Size = new Size(124, 23);
            changeTitleButton.TabIndex = 0;
            changeTitleButton.Text = "Змінити заголовок";
            changeTitleButton.UseVisualStyleBackColor = true;
            changeTitleButton.Click += changeTitleButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(254, 56);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрити вікно";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // newTitleTextBox
            // 
            newTitleTextBox.Location = new Point(12, 27);
            newTitleTextBox.Name = "newTitleTextBox";
            newTitleTextBox.Size = new Size(124, 23);
            newTitleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Новий заголовок:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 117);
            Controls.Add(label1);
            Controls.Add(newTitleTextBox);
            Controls.Add(closeButton);
            Controls.Add(changeTitleButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeTitleButton;
        private Button closeButton;
        private TextBox newTitleTextBox;
        private Label label1;
    }
}