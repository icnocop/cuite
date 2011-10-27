using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Collections;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlControl<T> : CUITe_ControlBase<T> where T : HtmlControl
    {
        public CUITe_HtmlControl() : base() { }
        public CUITe_HtmlControl(string sSearchParameters) : base(sSearchParameters) { }

        public string InnerText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.InnerText;
            }
        }

        public string HelpText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.HelpText;
            }
        }

        public string Title
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Title;
            }
        }

        public string ValueAttribute
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ValueAttribute;
            }
        }

        public string AccessKey
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.AccessKey;
            }
        }

        public List<ICUITe_ControlBase> GetChildren()
        {
            List<ICUITe_ControlBase> uicol = new List<ICUITe_ControlBase>();
            foreach (UITestControl uitestcontrol in this._control.GetChildren())
            {
                if (uitestcontrol.GetType() == typeof(HtmlButton))
                {
                    var _con = new CUITe_HtmlButton();
                    _con.WrapReady((HtmlButton)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlCheckBox))
                {
                    var _con = new CUITe_HtmlCheckBox();
                    _con.WrapReady((HtmlCheckBox)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlComboBox))
                {
                    var _con = new CUITe_HtmlComboBox();
                    _con.WrapReady((HtmlComboBox)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlDiv))
                {
                    var _con = new CUITe_HtmlDiv();
                    _con.WrapReady((HtmlDiv)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlEdit))
                {
                    var _con = new CUITe_HtmlEdit();
                    _con.WrapReady((HtmlEdit)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlFileInput))
                {
                    var _con = new CUITe_HtmlFileInput();
                    _con.WrapReady((HtmlFileInput)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlHyperlink))
                {
                    var _con = new CUITe_HtmlHyperlink();
                    _con.WrapReady((HtmlHyperlink)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlImage))
                {
                    var _con = new CUITe_HtmlImage();
                    _con.WrapReady((HtmlImage)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlInputButton))
                {
                    var _con = new CUITe_HtmlInputButton();
                    _con.WrapReady((HtmlInputButton)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlLabel))
                {
                    var _con = new CUITe_HtmlLabel();
                    _con.WrapReady((HtmlLabel)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlList))
                {
                    var _con = new CUITe_HtmlList();
                    _con.WrapReady((HtmlList)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlRadioButton))
                {
                    var _con = new CUITe_HtmlRadioButton();
                    _con.WrapReady((HtmlRadioButton)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlSpan))
                {
                    var _con = new CUITe_HtmlSpan();
                    _con.WrapReady((HtmlSpan)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlTable))
                {
                    var _con = new CUITe_HtmlTable();
                    _con.WrapReady((HtmlTable)uitestcontrol);
                    uicol.Add(_con);
                }
                if (uitestcontrol.GetType() == typeof(HtmlTextArea))
                {
                    var _con = new CUITe_HtmlTextArea();
                    _con.WrapReady((HtmlTextArea)uitestcontrol);
                    uicol.Add(_con);
                }
            }
            return uicol;
        }
    }
}
