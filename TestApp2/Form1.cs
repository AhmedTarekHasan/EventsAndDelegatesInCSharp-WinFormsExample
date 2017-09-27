using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tripleSliders1.SliderPositionChanged += new WinFormsControlsProject.SliderPositionChangedEventHandler(tripleSliders1_SliderPositionChanged);
            lbl_1.Text = "0";
            lbl_2.Text = "0";
            lbl_3.Text = "0";
        }

        void tripleSliders1_SliderPositionChanged(object sender, WinFormsControlsProject.SliderPositionChangedEventArgs e)
        {
            switch (e.ChangedSlider)
            {
                case WinFormsControlsProject.SliderName.Slider1:
                    lbl_1.Text = e.Slider1Value.ToString();
                    break;
                case WinFormsControlsProject.SliderName.Slider2:
                    lbl_2.Text = e.Slider2Value.ToString();
                    break;
                case WinFormsControlsProject.SliderName.Slider3:
                    lbl_3.Text = e.Slider3Value.ToString();
                    break;
            }
        }
    }
}
