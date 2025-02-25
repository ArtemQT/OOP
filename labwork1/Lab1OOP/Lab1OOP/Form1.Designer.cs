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
            this.PrintParallelogramButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PaintRectangleButton = new System.Windows.Forms.Button();
            this.PaintSquarebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintParallelogramButton
            // 
            this.PrintParallelogramButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintParallelogramButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PrintParallelogramButton.Location = new System.Drawing.Point(12, 23);
            this.PrintParallelogramButton.Name = "PrintParallelogramButton";
            this.PrintParallelogramButton.Size = new System.Drawing.Size(219, 50);
            this.PrintParallelogramButton.TabIndex = 0;
            this.PrintParallelogramButton.Text = "Паралелограмм";
            this.PrintParallelogramButton.UseVisualStyleBackColor = true;
            this.PrintParallelogramButton.Click += new System.EventHandler(this.PrintParallelogramButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // PaintRectangleButton
            // 
            this.PaintRectangleButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaintRectangleButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PaintRectangleButton.Location = new System.Drawing.Point(12, 79);
            this.PaintRectangleButton.Name = "PaintRectangleButton";
            this.PaintRectangleButton.Size = new System.Drawing.Size(219, 50);
            this.PaintRectangleButton.TabIndex = 1;
            this.PaintRectangleButton.Text = "Прямоугольник";
            this.PaintRectangleButton.UseVisualStyleBackColor = true;
            this.PaintRectangleButton.Click += new System.EventHandler(this.PaintRectangleButton_Click);
            // 
            // PaintSquarebutton
            // 
            this.PaintSquarebutton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaintSquarebutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PaintSquarebutton.Location = new System.Drawing.Point(12, 135);
            this.PaintSquarebutton.Name = "PaintSquarebutton";
            this.PaintSquarebutton.Size = new System.Drawing.Size(219, 50);
            this.PaintSquarebutton.TabIndex = 2;
            this.PaintSquarebutton.Text = "Квадрат";
            this.PaintSquarebutton.UseVisualStyleBackColor = true;
            this.PaintSquarebutton.Click += new System.EventHandler(this.PaintSquarebutton_Click);
            this.PaintSquarebutton.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintSquarebutton_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PaintSquarebutton);
            this.Controls.Add(this.PaintRectangleButton);
            this.Controls.Add(this.PrintParallelogramButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintParallelogramButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button PaintRectangleButton;
        private System.Windows.Forms.Button PaintSquarebutton;
    }
}

