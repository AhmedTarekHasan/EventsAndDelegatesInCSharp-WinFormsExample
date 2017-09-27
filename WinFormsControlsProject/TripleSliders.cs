using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsControlsProject
{
    public partial class TripleSliders : UserControl
    {
        #region Constructor
        public TripleSliders()
        {
            InitializeComponent();
        }
        #endregion

        #region Custom Events
        public event SliderPositionChangedEventHandler SliderPositionChanged;
        #endregion

        #region Custom Event Handlers
        public virtual void OnSliderPositionChanged(object sender, SliderPositionChangedEventArgs e)
        {
            if (null != SliderPositionChanged)
            {
                SliderPositionChanged(sender, e);
            }
        }
        #endregion

        #region Control Events
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            SliderPositionChangedEventArgs args = new SliderPositionChangedEventArgs(SliderName.Slider1, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            OnSliderPositionChanged(this, args);
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            SliderPositionChangedEventArgs args = new SliderPositionChangedEventArgs(SliderName.Slider2, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            OnSliderPositionChanged(this, args);
        }

        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            SliderPositionChangedEventArgs args = new SliderPositionChangedEventArgs(SliderName.Slider3, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            OnSliderPositionChanged(this, args);
        }
        #endregion
    }

    #region Delegate
    public delegate void SliderPositionChangedEventHandler(object sender, SliderPositionChangedEventArgs e);
    #endregion

    #region EventArgs
    public class SliderPositionChangedEventArgs : EventArgs
    {
        #region Fields & Properties
        SliderName changedSlider;
        public SliderName ChangedSlider
        {
            get { return changedSlider; }
            set { changedSlider = value; }
        }

        int slider1Value;
        public int Slider1Value
        {
            get { return slider1Value; }
            set { slider1Value = value; }
        }

        int slider2Value;
        public int Slider2Value
        {
            get { return slider2Value; }
            set { slider2Value = value; }
        }

        int slider3Value;
        public int Slider3Value
        {
            get { return slider3Value; }
            set { slider3Value = value; }
        }
        #endregion

        #region Constructors
        public SliderPositionChangedEventArgs()
        {
        }
        public SliderPositionChangedEventArgs(SliderName _changedSlider, int _slider1Value, int _slider2Value, int _slider3Value)
        {
            ChangedSlider = _changedSlider;
            Slider1Value = _slider1Value;
            Slider2Value = _slider2Value;
            Slider3Value = _slider3Value;
        }
        #endregion
    }
    #endregion

    #region SliderName enum
    public enum SliderName
    {
        Slider1 = 1,
        Slider2 = 2,
        Slider3 = 3
    }
    #endregion
}


