namespace project_file
{
    partial class course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Gill Sans Ultra Bold", 18F);
            label1.Location = new Point(181, 28);
            label1.Name = "label1";
            label1.Size = new Size(437, 48);
            label1.TabIndex = 0;
            label1.Text = "Manage Course";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Britannic Bold", 16.2F);
            label2.Location = new Point(181, 156);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 1;
            label2.Text = "Course ID";
            // 
            // label3
            // 
            label3.Font = new Font("Britannic Bold", 16.2F);
            label3.Location = new Point(181, 100);
            label3.Name = "label3";
            label3.Size = new Size(183, 44);
            label3.TabIndex = 2;
            label3.Text = "Course Name";
            // 
            // label4
            // 
            label4.Font = new Font("Britannic Bold", 16.2F);
            label4.Location = new Point(181, 215);
            label4.Name = "label4";
            label4.Size = new Size(220, 39);
            label4.TabIndex = 3;
            label4.Text = "Course Duration";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 156);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 41);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 215);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 39);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 100);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 38);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Bold);
            button1.Location = new Point(40, 295);
            button1.Name = "button1";
            button1.Size = new Size(125, 60);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Bold);
            button2.Location = new Point(181, 295);
            button2.Name = "button2";
            button2.Size = new Size(122, 60);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Bold);
            button3.Location = new Point(532, 295);
            button3.Name = "button3";
            button3.Size = new Size(125, 60);
            button3.TabIndex = 9;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Bold);
            button4.Location = new Point(676, 295);
            button4.Name = "button4";
            button4.Size = new Size(131, 60);
            button4.TabIndex = 10;
            button4.Text = "Display";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(181, 381);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 244);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(835, 651);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "course";
            Text = "course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}