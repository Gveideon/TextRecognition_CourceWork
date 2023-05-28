namespace TextRecognitionWinForm
{
    partial class ReognitionForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            langList = new ToolStripComboBox();
            modeList = new ToolStripComboBox();
            режимРаботыToolStripMenuItem = new ToolStripMenuItem();
            startDrawing = new ToolStripMenuItem();
            editBrush = new ToolStripMenuItem();
            clearField = new ToolStripMenuItem();
            changeBackGround = new ToolStripMenuItem();
            eraserButton = new ToolStripMenuItem();
            openFileItem = new ToolStripMenuItem();
            recognizeItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            field = new PictureBox();
            textField = new RichTextBox();
            panel1 = new Panel();
            isDrawingTurnStatus = new Label();
            eraserStatus = new Label();
            statusField = new Label();
            updaterImage = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)field).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.ImeMode = ImeMode.Katakana;
            menuStrip1.Items.AddRange(new ToolStripItem[] { langList, modeList, режимРаботыToolStripMenuItem, openFileItem, recognizeItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(948, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // langList
            // 
            langList.Items.AddRange(new object[] { "rus+eng", "rus", "eng" });
            langList.Name = "langList";
            langList.Size = new Size(165, 28);
            langList.Text = "rus+eng";
            // 
            // modeList
            // 
            modeList.Items.AddRange(new object[] { "TesseractAndLstm", "Tesseract", "Lstm", "Default" });
            modeList.Name = "modeList";
            modeList.Size = new Size(165, 28);
            modeList.Text = "TesseractAndLstm";
            // 
            // режимРаботыToolStripMenuItem
            // 
            режимРаботыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startDrawing, editBrush, clearField, changeBackGround, eraserButton });
            режимРаботыToolStripMenuItem.Name = "режимРаботыToolStripMenuItem";
            режимРаботыToolStripMenuItem.Size = new Size(150, 28);
            режимРаботыToolStripMenuItem.Text = "Режим рисования";
            // 
            // startDrawing
            // 
            startDrawing.Name = "startDrawing";
            startDrawing.Size = new Size(204, 26);
            startDrawing.Text = "Запустить";
            startDrawing.Click += startDrawing_Click;
            // 
            // editBrush
            // 
            editBrush.Name = "editBrush";
            editBrush.Size = new Size(204, 26);
            editBrush.Text = "Изменить кисть";
            editBrush.Click += editBrush_Click;
            // 
            // clearField
            // 
            clearField.Name = "clearField";
            clearField.Size = new Size(204, 26);
            clearField.Text = "Очистить";
            clearField.Click += clearField_Click;
            // 
            // changeBackGround
            // 
            changeBackGround.Name = "changeBackGround";
            changeBackGround.Size = new Size(204, 26);
            changeBackGround.Text = "Изменить фон";
            changeBackGround.Click += changeBackGround_Click;
            // 
            // eraserButton
            // 
            eraserButton.Name = "eraserButton";
            eraserButton.Size = new Size(204, 26);
            eraserButton.Text = "ластик вкл/выкл";
            eraserButton.Click += eraserButton_Click;
            // 
            // openFileItem
            // 
            openFileItem.Name = "openFileItem";
            openFileItem.Size = new Size(183, 28);
            openFileItem.Text = "Выбрать изображение";
            openFileItem.Click += openFileItem_Click;
            // 
            // recognizeItem
            // 
            recognizeItem.Name = "recognizeItem";
            recognizeItem.Size = new Size(102, 28);
            recognizeItem.Text = "Распознать";
            recognizeItem.Click += recognizeItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 34);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(field);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textField);
            splitContainer1.Size = new Size(948, 440);
            splitContainer1.SplitterDistance = 442;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // field
            // 
            field.BackColor = SystemColors.Info;
            field.Dock = DockStyle.Fill;
            field.Location = new Point(0, 0);
            field.Margin = new Padding(4);
            field.Name = "field";
            field.Size = new Size(442, 440);
            field.SizeMode = PictureBoxSizeMode.StretchImage;
            field.TabIndex = 0;
            field.TabStop = false;
            field.SizeChanged += field_SizeChanged;
            field.MouseDown += field_MouseDown;
            field.MouseMove += field_MouseMove;
            field.MouseUp += field_MouseUp;
            // 
            // textField
            // 
            textField.Dock = DockStyle.Fill;
            textField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textField.ImeMode = ImeMode.NoControl;
            textField.Location = new Point(0, 0);
            textField.Margin = new Padding(4);
            textField.Name = "textField";
            textField.Size = new Size(500, 440);
            textField.TabIndex = 0;
            textField.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(isDrawingTurnStatus);
            panel1.Controls.Add(eraserStatus);
            panel1.Controls.Add(statusField);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 439);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 35);
            panel1.TabIndex = 2;
            // 
            // isDrawingTurnStatus
            // 
            isDrawingTurnStatus.AutoSize = true;
            isDrawingTurnStatus.Dock = DockStyle.Right;
            isDrawingTurnStatus.Location = new Point(653, 0);
            isDrawingTurnStatus.Margin = new Padding(4, 0, 4, 0);
            isDrawingTurnStatus.Name = "isDrawingTurnStatus";
            isDrawingTurnStatus.Size = new Size(166, 28);
            isDrawingTurnStatus.TabIndex = 2;
            isDrawingTurnStatus.Text = "Рисование: выкл";
            // 
            // eraserStatus
            // 
            eraserStatus.AutoSize = true;
            eraserStatus.Dock = DockStyle.Right;
            eraserStatus.Location = new Point(819, 0);
            eraserStatus.Margin = new Padding(4, 0, 4, 0);
            eraserStatus.Name = "eraserStatus";
            eraserStatus.Size = new Size(129, 28);
            eraserStatus.TabIndex = 1;
            eraserStatus.Text = "Ластик: выкл";
            // 
            // statusField
            // 
            statusField.AutoSize = true;
            statusField.Dock = DockStyle.Left;
            statusField.Location = new Point(0, 0);
            statusField.Margin = new Padding(4, 0, 4, 0);
            statusField.Name = "statusField";
            statusField.Size = new Size(69, 28);
            statusField.TabIndex = 0;
            statusField.Text = "Status:";
            // 
            // updaterImage
            // 
            updaterImage.Enabled = true;
            updaterImage.Interval = 33;
            updaterImage.Tick += updaterImage_Tick;
            // 
            // ReognitionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 474);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "ReognitionForm";
            Text = "Форма распознования текта";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)field).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripComboBox langList;
        private ToolStripComboBox modeList;
        private ToolStripMenuItem recognizeItem;
        private SplitContainer splitContainer1;
        private PictureBox field;
        private RichTextBox textField;
        private Panel panel1;
        private Label statusField;
        private ToolStripMenuItem режимРаботыToolStripMenuItem;
        private ToolStripMenuItem startDrawing;
        private ToolStripMenuItem editBrush;
        private ToolStripMenuItem clearField;
        private ToolStripMenuItem openFileItem;
        private ToolStripMenuItem changeBackGround;
        private System.Windows.Forms.Timer updaterImage;
        private ToolStripMenuItem eraserButton;
        private Label isDrawingTurnStatus;
        private Label eraserStatus;
    }
}