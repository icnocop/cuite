﻿using System;
using CUITe.Controls.WinControls;

namespace Sut.WinForms.ControlsTest.ScreenObjects
{
    public class MainScreen : WinWindow
    {
        public MainScreen()
            : base("Name=System Under Test (WinForms)")
        {
        }

        public WinButton Button
        {
            get { return Find<WinButton>("Name=This is a button"); }
        }

        public WinCheckBox CheckBox
        {
            get { return Find<WinCheckBox>("Name=This is a check box"); }
        }

        public WinComboBox ComboBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinDateTimePicker DateTimePicker
        {
            get { return Find<WinDateTimePicker>("Name=" + DateTime.Now.ToLongDateString()); }
        }

        public WinGroup GroupBox
        {
            get { return Find<WinGroup>("Name=Group box"); }
        }

        public WinText Label
        {
            get { return Find<WinText>("Name=This is a label"); }
        }

        public WinHyperlink LinkLabel
        {
            get { return Find<WinHyperlink>("Name=This is a link label"); }
        }

        public WinList ListBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinTable ListView
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinEdit MaskedTextBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinCalendar MonthCalendar
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinEdit NumericUpDown
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinEdit PictureBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinProgressBar ProgressBar
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinRadioButton RadioButton
        {
            get { return Find<WinRadioButton>("Name=This is a radio button"); }
        }

        public WinEdit RichTextBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinTabList TabControl
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinEdit TextBox
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinTree TreeView
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }

        public WinEdit WebBrowser
        {
            get { throw new NotImplementedException("CUITe support for WinForms needs some work before this control can be found."); }
        }
    }
}