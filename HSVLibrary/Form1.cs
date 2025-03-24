using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace HSVLibrary
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> BGRImage = null;
        private Image<Hsv, Byte> hsvIMG = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            BarEnabled(false);
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {           
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    BGRImage = new Image<Bgr, byte>(openFileDialog.FileName);
                }
            }
            //imageBox1.Image = BGRImage;
            hsvIMG = new Image<Hsv, byte>(BGRImage.Width, BGRImage.Height);
            HSVProcess();
            BarEnabled(true);
        }

        private void Bar_H_LowerLimit_Scroll(object sender, EventArgs e)
        {
            LBL_H_LowerLimit.Text = "H_LowerLimit：" + Bar_H_LowerLimit.Value.ToString();
            HSVProcess();
        }

        private void Bar_H_UpperLimit_Scroll(object sender, EventArgs e)
        {
            Lbl_H_UpperLimit.Text = "H_UpperLimit：" + Bar_H_UpperLimit.Value.ToString();
            HSVProcess();
        }

        private void Bar_S_LowerLimit_Scroll(object sender, EventArgs e)
        {
            Lbl_S_LowerLimit.Text = "S_LowerLimit：" + Bar_S_LowerLimit.Value.ToString();
            HSVProcess();
        }

        private void Bar_S_UpperLimit_Scroll(object sender, EventArgs e)
        {
            Lbl_S_UpperLimit.Text = "S_UpperLimit：" + Bar_S_UpperLimit.Value.ToString();
            HSVProcess();
        }

        private void Bar_V_LowerLimit_Scroll(object sender, EventArgs e)
        {
            Lbl_V_LowerLimit.Text = "V_LowerLimit：" + Bar_V_LowerLimit.Value.ToString();
            HSVProcess();
        }

        private void Bar_V_UpperLimit_Scroll(object sender, EventArgs e)
        {
            Lbl_V_UpperLimit.Text = "V_UpperLimit：" + Bar_V_UpperLimit.Value.ToString();
            HSVProcess();
        }

        private void HSVProcess()
        {           
            CvInvoke.CvtColor(BGRImage, hsvIMG, ColorConversion.Bgr2Hsv);
            Hsv lowerLimit = new Hsv(Bar_H_LowerLimit.Value, Bar_S_LowerLimit.Value, Bar_V_LowerLimit.Value);
            Hsv upperLimit = new Hsv(Bar_H_UpperLimit.Value, Bar_S_UpperLimit.Value, Bar_V_UpperLimit.Value);
            var ResultImg = hsvIMG.InRange(lowerLimit, upperLimit);
            imageBox1.Image = ResultImg;
        }

        private void BarEnabled(bool Enabled)
        {
            Bar_H_LowerLimit.Enabled = Enabled;
            Bar_S_LowerLimit.Enabled = Enabled;
            Bar_V_LowerLimit.Enabled = Enabled;
            Bar_H_UpperLimit.Enabled = Enabled;
            Bar_S_UpperLimit.Enabled = Enabled;
            Bar_V_UpperLimit.Enabled = Enabled;
        }
    }
}
