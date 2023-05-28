using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRecognitionWinForm
{
    public partial class FormBrushEdit : Form
    {
        private Pen _pen;
        public FormBrushEdit(Pen pen)
        {
            InitializeComponent();
            _pen = pen;
            colorField.BackColor = pen.Color;
            fieldSize.Value = (decimal)pen.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _pen.Width = (int)fieldSize.Value;
            _pen.Color = colorField.BackColor;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void colorField_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK) 
            {
                colorField.BackColor = dlg.Color;
            }
        }
    }
}
