using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp1
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
        }

        void tripleSliders1_SliderPositionChanged(object sender, WinFormsControlsProject.SliderPositionChangedEventArgs e)
        {
            this.BackColor = Color.FromArgb(e.Slider1Value, e.Slider2Value, e.Slider3Value);
        }
    }
}
