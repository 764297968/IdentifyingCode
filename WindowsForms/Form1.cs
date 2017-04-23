using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MODI.Document doc = new MODI.Document();

            doc.Create("C:\\Users\\W_ang\\Pictures\\Camera Roll\\无标题.png");
            MODI.Image image;
            MODI.Layout layout;
            doc.OCR(MODI.MiLANGUAGES.miLANG_CHINESE_SIMPLIFIED, true, true);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < doc.Images.Count; i++)
            {
                image = (MODI.Image)doc.Images[i];
                layout = image.Layout;
                sb.Append(layout.Text);
            }

            textBox1.Text = sb.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str=new OpenFileDialog();
            MessageBox.Show("11");
        }
    }
}
