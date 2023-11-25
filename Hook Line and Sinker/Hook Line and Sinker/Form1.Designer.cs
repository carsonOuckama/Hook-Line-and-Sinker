namespace Hook_Line_and_Sinker
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(305, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Send Email";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 6;
            label1.Text = "Hook Line and Sinker";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(4, 5);
            label2.MaximumSize = new Size(350, 0);
            label2.Name = "label2";
            label2.Size = new Size(348, 47);
            label2.TabIndex = 7;
            label2.Text = "Phishing is a very dangerous and effective form of social engineering. Testing your employees knowledge of these attacks can prevent an attacker gaining entry into your bussiness.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 8;
            label3.Text = "Status: ...Waiting";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(9, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 56);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(9, 169);
            label4.Name = "label4";
            label4.Size = new Size(235, 24);
            label4.TabIndex = 10;
            label4.Text = "Only test one employee at a time.\r\nThe employee must be an the same network as you.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(392, 206);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            MaximumSize = new Size(408, 245);
            MinimumSize = new Size(408, 245);
            Name = "Form1";
            Text = "Hook Link and Sinker";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
    }
}