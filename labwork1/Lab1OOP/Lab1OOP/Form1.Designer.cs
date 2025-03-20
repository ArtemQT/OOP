namespace Lab1OOP
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.FigurecomboBox = new System.Windows.Forms.ComboBox();
            this.СhoseFigurelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Cleanbutton = new System.Windows.Forms.Button();
            this.DeleteLastbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.BackColor = System.Drawing.SystemColors.Control;
            this.HistoryListBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 20;
            this.HistoryListBox.Location = new System.Drawing.Point(249, 20);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(219, 144);
            this.HistoryListBox.TabIndex = 7;
            // 
            // FigurecomboBox
            // 
            this.FigurecomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.FigurecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FigurecomboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FigurecomboBox.FormattingEnabled = true;
            this.FigurecomboBox.Items.AddRange(new object[] {
            "Параллелограмм",
            "Прямоугольник",
            "Квадрат",
            "Эллипс",
            "Круг",
            "Линия"});
            this.FigurecomboBox.Location = new System.Drawing.Point(12, 72);
            this.FigurecomboBox.Name = "FigurecomboBox";
            this.FigurecomboBox.Size = new System.Drawing.Size(219, 30);
            this.FigurecomboBox.TabIndex = 8;
            this.FigurecomboBox.SelectedIndexChanged += new System.EventHandler(this.FigurecomboBox_SelectedIndexChanged);
            // 
            // СhoseFigurelabel
            // 
            this.СhoseFigurelabel.AutoSize = true;
            this.СhoseFigurelabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.СhoseFigurelabel.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.СhoseFigurelabel.Location = new System.Drawing.Point(13, 20);
            this.СhoseFigurelabel.Name = "СhoseFigurelabel";
            this.СhoseFigurelabel.Size = new System.Drawing.Size(218, 31);
            this.СhoseFigurelabel.TabIndex = 9;
            this.СhoseFigurelabel.Text = "Выбор фигуры";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Параметр 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Параметр 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(731, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 14;
            // 
            // Cleanbutton
            // 
            this.Cleanbutton.Location = new System.Drawing.Point(485, 118);
            this.Cleanbutton.Name = "Cleanbutton";
            this.Cleanbutton.Size = new System.Drawing.Size(184, 46);
            this.Cleanbutton.TabIndex = 15;
            this.Cleanbutton.Text = "Очистить холст";
            this.Cleanbutton.UseVisualStyleBackColor = true;
            this.Cleanbutton.Click += new System.EventHandler(this.Cleanbutton_Click);
            // 
            // DeleteLastbutton
            // 
            this.DeleteLastbutton.Location = new System.Drawing.Point(731, 118);
            this.DeleteLastbutton.Name = "DeleteLastbutton";
            this.DeleteLastbutton.Size = new System.Drawing.Size(184, 46);
            this.DeleteLastbutton.TabIndex = 16;
            this.DeleteLastbutton.Text = "Удалить последнюю фигуру";
            this.DeleteLastbutton.UseVisualStyleBackColor = true;
            this.DeleteLastbutton.Click += new System.EventHandler(this.DeleteLastbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1029, 743);
            this.Controls.Add(this.DeleteLastbutton);
            this.Controls.Add(this.Cleanbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.СhoseFigurelabel);
            this.Controls.Add(this.FigurecomboBox);
            this.Controls.Add(this.HistoryListBox);
            this.Name = "Form1";
            this.Text = "PaintForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.ComboBox FigurecomboBox;
        private System.Windows.Forms.Label СhoseFigurelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Cleanbutton;
        private System.Windows.Forms.Button DeleteLastbutton;
    }
}

