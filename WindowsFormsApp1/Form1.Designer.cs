namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConnectToDataBase);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(803, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 279);
            this.dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DisconnectToDataBase);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Получить чаи";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SelectTeaInfo);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 48);
            this.button5.TabIndex = 8;
            this.button5.Text = "Получить название чаев";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SelectNamesOfTea);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 48);
            this.button6.TabIndex = 9;
            this.button6.Text = "Получить зеленые чаи";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SelectGreenTeas);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 48);
            this.button7.TabIndex = 10;
            this.button7.Text = "Получить черные чаи\r\n";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SelectBlackTeas);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 48);
            this.button8.TabIndex = 11;
            this.button8.Text = "Получить другие чаи";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SelectOtherTeas);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 48);
            this.button9.TabIndex = 13;
            this.button9.Text = "Отсортировать по граммам";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SelectTeasPerGrammes);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(637, 160);
            this.button3.TabIndex = 14;
            this.button3.Text = "Обновить датасет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UpdateDataset);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 425);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 48);
            this.button10.TabIndex = 15;
            this.button10.Text = "Минимальная, максимальная средняя себестоимость";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SelectMinMaxAvgCost);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 479);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 35);
            this.button11.TabIndex = 16;
            this.button11.Text = "Последнее задание 1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.LastZadaniye1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(155, 479);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(137, 35);
            this.button12.TabIndex = 17;
            this.button12.Text = "Последнее задание 2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.LastZadaniye2);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(298, 479);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(137, 35);
            this.button13.TabIndex = 18;
            this.button13.Text = "Последнее задание 3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.LastZadaniye3);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(441, 479);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(137, 35);
            this.button14.TabIndex = 19;
            this.button14.Text = "Последнее задание 4";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.LastZadaniye4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 705);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

