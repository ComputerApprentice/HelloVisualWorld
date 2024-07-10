namespace HelloVisualWorld
{
    partial class HelloForm
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
            displayOutputButton = new Button();
            SuspendLayout();
            // 
            // displayOutputButton
            // 
            displayOutputButton.Location = new Point(80, 50);
            displayOutputButton.Name = "displayOutputButton";
            displayOutputButton.Size = new Size(77, 38);
            displayOutputButton.TabIndex = 0;
            displayOutputButton.Text = "Click here";
            displayOutputButton.UseVisualStyleBackColor = true;
            displayOutputButton.Click += button1_Click;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayOutputButton);
            Name = "HelloForm";
            Text = "Hello Visual World";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button displayOutputButton;
    }
}
