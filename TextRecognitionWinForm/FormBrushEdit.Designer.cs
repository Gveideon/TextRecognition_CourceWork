namespace TextRecognitionWinForm
{
    partial class FormBrushEdit
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
            fieldSize = new NumericUpDown();
            colorField = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorField).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Размер кисти";
            // 
            // fieldSize
            // 
            fieldSize.Location = new Point(153, 7);
            fieldSize.Margin = new Padding(4);
            fieldSize.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            fieldSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fieldSize.Name = "fieldSize";
            fieldSize.Size = new Size(57, 34);
            fieldSize.TabIndex = 1;
            fieldSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // colorField
            // 
            colorField.Location = new Point(153, 54);
            colorField.Name = "colorField";
            colorField.Size = new Size(57, 34);
            colorField.TabIndex = 2;
            colorField.TabStop = false;
            colorField.Click += colorField_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 3;
            label2.Text = "Цвет кисти";
            // 
            // button1
            // 
            button1.Location = new Point(12, 104);
            button1.Name = "button1";
            button1.Size = new Size(74, 40);
            button1.TabIndex = 4;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBrushEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 156);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(colorField);
            Controls.Add(fieldSize);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FormBrushEdit";
            Text = "Редактирование кисти";
            ((System.ComponentModel.ISupportInitialize)fieldSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown fieldSize;
        private PictureBox colorField;
        private Label label2;
        private Button button1;
    }
}