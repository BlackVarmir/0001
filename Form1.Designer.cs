namespace _0001
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
            OpenNotepad = new Button();
            CloseNotepad = new Button();
            SuspendLayout();
            // 
            // OpenNotepad
            // 
            OpenNotepad.Location = new Point(44, 30);
            OpenNotepad.Name = "OpenNotepad";
            OpenNotepad.Size = new Size(106, 23);
            OpenNotepad.TabIndex = 0;
            OpenNotepad.Text = "Open Notepad";
            OpenNotepad.UseVisualStyleBackColor = true;
            OpenNotepad.Click += OpenNotepad_Click;
            // 
            // CloseNotepad
            // 
            CloseNotepad.Location = new Point(44, 79);
            CloseNotepad.Name = "CloseNotepad";
            CloseNotepad.Size = new Size(106, 23);
            CloseNotepad.TabIndex = 1;
            CloseNotepad.Text = "Close Notepad";
            CloseNotepad.UseVisualStyleBackColor = true;
            CloseNotepad.Click += CloseNotepad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 161);
            Controls.Add(CloseNotepad);
            Controls.Add(OpenNotepad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button OpenNotepad;
        private Button CloseNotepad;
    }
}