namespace OptimizeLite
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
            buttonCloseAll = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCloseAll
            // 
            buttonCloseAll.Location = new Point(12, 12);
            buttonCloseAll.Name = "buttonCloseAll";
            buttonCloseAll.Size = new Size(200, 23);
            buttonCloseAll.TabIndex = 3;
            buttonCloseAll.Text = "Programları Kapat";
            buttonCloseAll.UseVisualStyleBackColor = true;
            buttonCloseAll.Click += buttonCloseAll_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 12);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 4;
            button1.Text = "Geçici Veri Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(366, 12);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 5;
            button2.Text = "Ağ Ayarlarını Onar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(514, 12);
            button3.Name = "button3";
            button3.Size = new Size(142, 23);
            button3.TabIndex = 6;
            button3.Text = "DNS Önbelleğini Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(514, 70);
            button4.Name = "button4";
            button4.Size = new Size(142, 23);
            button4.TabIndex = 7;
            button4.Text = "Oyunu Başlat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 451);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 477);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 11;
            label1.Text = "BSD 3-Clause License";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 504);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonCloseAll);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCloseAll;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}