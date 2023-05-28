using System.IO;
using Tesseract;

namespace TextRecognitionWinForm
{
    public partial class ReognitionForm : Form
    {
        private string filePath;
        private string langRecognition = "rus+eng";
        private EngineMode engineMode = EngineMode.Default;
        private Bitmap canvas;
        private Bitmap background;
        private bool isDrawing = false;
        private bool isDrawingTurnOn = false;
        private Point start = new Point(0, 0);
        private Point end = new Point(0, 0);
        private Color fieldColor = Color.White;
        private string pathDrawing = @"OCR_Test.png";
        private Pen brushPen = new Pen(System.Drawing.Color.Black, 5);
        private bool isEraser = false;
        public ReognitionForm()
        {
            InitializeComponent();
            canvas = new Bitmap(field.Width, field.Height);
            background = new Bitmap(field.Width, field.Height);
            var g = Graphics.FromImage(background);
            g.Clear(fieldColor);
            field.Image = canvas;
            canvas.Save(pathDrawing);
            field.BackgroundImage = background;
        }

        private void openFileItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                try
                {
                    isDrawingTurnOn = false;
                    isDrawingTurnStatus.Text = "Рисование: выкл";
                    field.Image = new Bitmap(filePath);
                }
                catch (Exception exp)
                {
                    statusField.Text = exp.Message;
                }
            }
        }

        private void recognizeItem_Click(object sender, EventArgs e)
        {
            langRecognition = langList.Text;
            SetMode();
            try
            {
                var path = filePath;
                if (isDrawingTurnOn)
                {
                    canvas.Save(pathDrawing);
                    path = pathDrawing;
                }
                statusField.Text = "start recognition";
                var ocrengine = new TesseractEngine(@".\tessdata", langRecognition, engineMode);
                var img = Pix.LoadFromFile(path);
                var res = ocrengine.Process(img);
                textField.Text = res.GetText();
                if (res != null && res.GetText() != string.Empty)
                    statusField.Text = "recognition success";
                else
                    statusField.Text = "Something went wrong. Your image  is not understadeble.";
            }
            catch (Exception ex)
            {
                statusField.Text = ex.Message;
            }
        }
        private void SetMode()
        {
            if (modeList.Text == "Lstm")
                engineMode = EngineMode.LstmOnly;
            if (modeList.Text == "Tesseract")
                engineMode = EngineMode.TesseractOnly;
            if (modeList.Text == "TesseractAndLstm")
                engineMode = EngineMode.TesseractAndLstm;
            if (modeList.Text == "Default")
                engineMode = EngineMode.Default;
        }

        private void updaterImage_Tick(object sender, EventArgs e)
        {
            field.Invalidate();
        }

        private void field_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            start = e.Location;
        }

        private void field_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing || !isDrawingTurnOn) return;
            end = e.Location;
            var g = Graphics.FromImage(canvas);
            // g.DrawLine(brushPen, start, end);
            var c = brushPen.Color;
            if (isEraser) c = fieldColor;
            g.FillRectangle(new SolidBrush(c),
                new Rectangle(end, new Size((int)brushPen.Width, (int)brushPen.Width)));
            start = end;
        }

        private void field_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void clearField_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ClearField()
        {
            var g = Graphics.FromImage(canvas);
            g.Clear(Color.Transparent);
        }
        private void field_SizeChanged(object sender, EventArgs e)
        {
            if (field.Width <= 0 || field.Height <= 0 || !isDrawingTurnOn) return;
            Image temp = (Image)canvas.Clone();
            background = new Bitmap(field.Width, field.Height);
            canvas = new Bitmap(field.Width, field.Height);
            var gc = Graphics.FromImage(canvas);
            var gb = Graphics.FromImage(background);
            gc.DrawImage(temp, 0, 0, (int)field.Width, (int)field.Height);
            gb.Clear(fieldColor);
            field.Image = canvas;
            field.BackgroundImage = background;
        }

        private void changeBackGround_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fieldColor = colorDialog.Color;
                var g = Graphics.FromImage(background);
                g.Clear(fieldColor);
            }
        }

        private void editBrush_Click(object sender, EventArgs e)
        {
            FormBrushEdit brushEdit = new FormBrushEdit(brushPen);
            if (brushEdit.ShowDialog() != DialogResult.OK)
                brushEdit.Close();

        }

        private void startDrawing_Click(object sender, EventArgs e)
        {
            isDrawingTurnOn = true;
            isDrawingTurnStatus.Text = "Рисование: вкл";
            field.Image = canvas;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            isEraser = !isEraser;
            var mode = isEraser ? "вкл" : "выкл";
            eraserStatus.Text = "Ластик: " + mode;
        }
    }
}