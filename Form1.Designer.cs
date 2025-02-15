namespace ISO_maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            iso = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            Folder = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Identifier = new TextBox();
            SuspendLayout();
            // 
            // iso
            // 
            iso.Location = new Point(8, 78);
            iso.Name = "iso";
            iso.Size = new Size(247, 23);
            iso.TabIndex = 0;
            iso.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 39);
            label1.Name = "label1";
            label1.Size = new Size(608, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter the name of the folder to make the ISO with the iso on the end with .iso. this is not checked unlike the others";
            // 
            // button1
            // 
            button1.Location = new Point(167, 300);
            button1.Name = "button1";
            button1.Size = new Size(111, 49);
            button1.TabIndex = 2;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(664, 391);
            button2.Name = "button2";
            button2.Size = new Size(124, 47);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Folder
            // 
            Folder.Location = new Point(5, 161);
            Folder.Name = "Folder";
            Folder.Size = new Size(250, 23);
            Folder.TabIndex = 4;
            Folder.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(266, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter the path where the folder with the files exist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(323, 15);
            label3.TabIndex = 6;
            label3.Text = "Please enter the name the iso is identified as when mounted";
            // 
            // Identifier
            // 
            Identifier.Location = new Point(5, 232);
            Identifier.Name = "Identifier";
            Identifier.Size = new Size(250, 23);
            Identifier.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Identifier);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Folder);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(iso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ISO maker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox iso;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox Folder;
        private Label label2;
        private Label label3;
        private TextBox Identifier;
    }
}
