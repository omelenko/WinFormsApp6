namespace WinFormsApp6
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 321);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(713, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(586, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(9, 365);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 4;
            button2.Text = "Всі однокорис. ігри";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(9, 394);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 5;
            button3.Text = "Всі багатокорис. ігри";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(146, 365);
            button4.Name = "button4";
            button4.Size = new Size(184, 23);
            button4.TabIndex = 6;
            button4.Text = "Макс кількість проданих копій";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 394);
            button5.Name = "button5";
            button5.Size = new Size(184, 23);
            button5.TabIndex = 7;
            button5.Text = "Мін кількість проданих копій";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(336, 365);
            button6.Name = "button6";
            button6.Size = new Size(124, 23);
            button6.TabIndex = 8;
            button6.Text = "Топ-3 популярність";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(336, 394);
            button7.Name = "button7";
            button7.Size = new Size(137, 23);
            button7.TabIndex = 9;
            button7.Text = "Топ-3 непопулярність";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(713, 365);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 10;
            button8.Text = "Додати";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(713, 394);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 11;
            button9.Text = "Редагувати";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(713, 423);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 12;
            button10.Text = "Видалити";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(479, 394);
            button11.Name = "button11";
            button11.Size = new Size(131, 23);
            button11.TabIndex = 13;
            button11.Text = "Кільк. однокор. ігор";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(466, 365);
            button12.Name = "button12";
            button12.Size = new Size(135, 23);
            button12.TabIndex = 14;
            button12.Text = "Кільк. багатокор. ігор";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(9, 423);
            button13.Name = "button13";
            button13.Size = new Size(206, 23);
            button13.TabIndex = 15;
            button13.Text = "Стиль з макс. кільк. проданих ігор";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(9, 452);
            button14.Name = "button14";
            button14.Size = new Size(286, 23);
            button14.TabIndex = 16;
            button14.Text = "Топ-5 ігор за макс. кільк. продаж. певного стилю";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(301, 452);
            button15.Name = "button15";
            button15.Size = new Size(279, 23);
            button15.TabIndex = 17;
            button15.Text = "Топ-5 ігор за мін. кільк. продаж. певного стилю";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}
