using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CUITe_ObjectRecorder
{
    public partial class Form1 : Form
    {
        private HtmlDocument document;
        private bool isCodeLanguageVB;

        public Form1()
        {
            InitializeComponent();

            isCodeLanguageVB = false;
        }

        private void webBrowser1_ClickHandler(object sender, HtmlElementEventArgs e)
        {
            var values = (string)document.InvokeScript("getValues");
            if (values != null && !listBox1.Items.Contains(values))
            {
                bool objectIdentified = isCodeLanguageVB ? !values.Contains("Property var()") : !values.StartsWith("public type ");
                if (objectIdentified)
                {
                    listBox1.Items.Add(values);
                    toolStripStatusLabel1.Text = "Object added!";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Warning: Object not identified!";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Warning: This object was recorded already!!!";
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            var frmWB = new Form1();
            var webBrowser = (WebBrowser)sender;
            HtmlElement link = webBrowser.Document.ActiveElement;
            if (link.GetAttribute("href") != null)
            {
                var urlNavigated = new Uri(link.GetAttribute("href"));
                frmWB.webBrowser1.Navigate(urlNavigated);
            }
            else if (link.GetAttribute("onclick") != null)
            {
                string js = link.GetAttribute("onclick");
                frmWB.webBrowser1.Navigate(js);
            }
            e.Cancel = true;
            frmWB.Show(this);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            document = webBrowser1.Document;
            btnRecord.Checked = false;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (document == null)
            {
                toolStripStatusLabel1.Text = "Error: Document not loaded yet, please try again!";
                return;
            }
            if (btnRecord.Checked)
            {
                toolStripDropDownButton1.Enabled = true;
                document.Click += webBrowser1_ClickHandler;
                document.GetElementsByTagName("head")[0].AppendChild(GetScript(document));
                foreach (HtmlWindow frame in document.Window.Frames)
                {
                    HtmlDocument frameDoc;
                    try
                    {
                        frameDoc = frame.Document;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    frameDoc.GetElementsByTagName("head")[0].AppendChild(GetScript(frameDoc));
                    frameDoc.Click += webBrowser1_ClickHandler;
                }
            }
            else
            {
                toolStripDropDownButton1.SelectedIndex = 0;
                toolStripDropDownButton1.Enabled = false;
                document.Click -= webBrowser1_ClickHandler;
                document.InvokeScript("removeScript");
                foreach (HtmlWindow frame in document.Window.Frames)
                {
                    HtmlDocument frameDoc;
                    try
                    {
                        frameDoc = frame.Document;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    frameDoc.InvokeScript("removeScript");
                    frameDoc.Click -= webBrowser1_ClickHandler;
                }
            }
        }

        private HtmlElement GetScript(HtmlDocument pDoc)
        {
            HtmlElement script;
            script = pDoc.CreateElement("script");
            script.SetAttribute("id", "CUITe_Script");
            script.SetAttribute("type", "text/javascript");
            script.SetAttribute("text", @"
                var isCodeLanguageVB = " + isCodeLanguageVB.ToString().ToLowerInvariant() + @";
                var oStyle;
                var sCode;
                var sOutHtml;
                var sFilter;
                var objInQuestion;
                var vTempCounter = 0;
                /**
                * http://www.javascripttoolbox.com/lib/objectposition/source.php
                * Copyright (c)2005-2009 Matt Kruse (javascripttoolbox.com)
                *
                * Permission is hereby granted, free of charge, to any person obtaining
                * a copy of this software and associated documentation files (the
                * 'Software'), to deal in the Software without restriction, including
                * without limitation the rights to use, copy, modify, merge, publish,
                * distribute, sublicense, and/or sell copies of the Software, and to
                * permit persons to whom the Software is furnished to do so, subject to
                * the following conditions:
                *
                * The above copyright notice and this permission notice shall be
                * included in all copies or substantial portions of the Software.
                *
                * THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
                * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
                * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
                * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
                * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
                * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
                * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
                *
                 */
                var Position = (function() {
                    // Resolve a string identifier to an object
                    // ========================================
                    function resolveObject(s) {
                        if (document.getElementById && document.getElementById(s) != null) {
                            return document.getElementById(s);
                        }
                        else if (document.all && document.all[s] != null) {
                            return document.all[s];
                        }
                        else if (document.anchors && document.anchors.length && document.anchors.length > 0 && document.anchors[0].x) {
                            for (var i = 0; i < document.anchors.length; i++) {
                                if (document.anchors[i].name == s) {
                                    return document.anchors[i]
                                }
                            }
                        }
                    }

                    var pos = {};
                    pos.$VERSION = 1.0;

                    // Set the position of an object
                    // =============================
                    pos.set = function(o, left, top) {
                        if (typeof(o) == 'string') {
                            o = resolveObject(o);
                        }
                        if (o == null || !o.style) {
                            return false;
                        }

                        // If the second parameter is an object, it is assumed to be the result of getPosition()
                        if (typeof(left) == 'object') {
                            var pos = left;
                            left = pos.left;
                            top = pos.top;
                        }

                        o.style.left = left + 'px';
                        o.style.top = top + 'px';
                        o.style.width = pos.width;
                        o.style.height = pos.height;
                        return true;
                    };

                    // Retrieve the position and size of an object
                    // ===========================================
                    pos.get = function(o) {
                        var fixBrowserQuirks = true;
                        // If a string is passed in instead of an object ref, resolve it
                        if (typeof(o) == 'string') {
                            o = resolveObject(o);
                        }

                        if (o == null) {
                            return null;
                        }

                        var left = 0;
                        var top = 0;
                        var width = 0;
                        var height = 0;
                        var parentNode = null;
                        var offsetParent = null;

                        offsetParent = o.offsetParent;
                        var originalObject = o;
                        var el = o; // 'el' will be nodes as we walk up, 'o' will be saved for offsetParent references
                        while (el.parentNode != null) {
                            el = el.parentNode;
                            if (el.offsetParent == null) {
                            }
                            else {
                                var considerScroll = true;
                                if (fixBrowserQuirks && window.opera) {
                                    if (el == originalObject.parentNode || el.nodeName == 'TR') {
                                        considerScroll = false;
                                    }
                                }
                                if (considerScroll) {
                                    if (el.scrollTop && el.scrollTop > 0) {
                                        top -= el.scrollTop;
                                    }
                                    if (el.scrollLeft && el.scrollLeft > 0) {
                                        left -= el.scrollLeft;
                                    }
                                }
                            }
                            // If this node is also the offsetParent, add on the offsets and reset to the new offsetParent
                            if (el == offsetParent) {
                                left += o.offsetLeft;
                                if (el.clientLeft && el.nodeName != 'TABLE') {
                                    left += el.clientLeft;
                                }
                                top += o.offsetTop;
                                if (el.clientTop && el.nodeName != 'TABLE') {
                                    top += el.clientTop;
                                }
                                o = el;
                                if (o.offsetParent == null) {
                                    if (o.offsetLeft) {
                                        left += o.offsetLeft;
                                    }
                                    if (o.offsetTop) {
                                        top += o.offsetTop;
                                    }
                                }
                                offsetParent = o.offsetParent;
                            }
                        }

                        if (originalObject.offsetWidth) {
                            width = originalObject.offsetWidth;
                        }
                        if (originalObject.offsetHeight) {
                            height = originalObject.offsetHeight;
                        }

                        return {'left':left, 'top':top, 'width':width, 'height':height };
                    };

                    // Retrieve the position of an object's center point
                    // =================================================
                    pos.getCenter = function(o) {
                        var c = this.get(o);
                        if (c == null) {
                            return null;
                        }
                        c.left = c.left + (c.width / 2);
                        c.top = c.top + (c.height / 2);
                        return c;
                    };

                    return pos;
                })();

                document.onmouseover = function(e) {
                    var evt = window.event || e;
                    evt.returnValue = false;
                    evt.cancelBubble = true;
                    if (evt.stopPropagation) evt.stopPropagation();
                    objInQuestion = evt.srcElement;
                    if (objInQuestion != null && objInQuestion.id != 'CUITe_div2') {
                        if (sFilter != null && sFilter != 'Filter:') {
                            objInQuestion = FindParentForFilter(objInQuestion);
                        }
                        if ((objInQuestion != null) && (!isElementIframe(objInQuestion.nodeName)) && (objInQuestion.nodeName != 'XMP') && (objInQuestion.nodeName != 'BODY')) {
                            sOutHtml = objInQuestion.outerHTML;
                            var posdic = Position.get(objInQuestion);
                            var divTag2 = AddDiv2();
                            divTag2.style.left = posdic.left + 'px';
                            divTag2.style.top = parseInt(posdic.top) + 4 + parseInt(posdic.height) + 'px';
                            divTag2.style.width = document.body.clientWidth - posdic.left - 10;
                            divTag2.innerHTML = '<span style=\'background:orange;\'><xmp>' + sOutHtml + '</xmp></span>';
                            oStyle = objInQuestion.style.cssText;
                            objInQuestion.style.border = '2px solid red';
                        }
                    }
                }
                document.onmouseout = function(e) {
                    var evt = window.event || e;
                    evt.returnValue = false;
                    evt.cancelBubble = true;
                    if (evt.stopPropagation) evt.stopPropagation();
                    if (objInQuestion != null && objInQuestion.id != 'CUITe_div2') {
                        objInQuestion.style.cssText = oStyle;
                        var div2 = document.getElementById('CUITe_div2');
                        if (div2 != null)
                        {
                            div2.style.visibility = 'hidden';
                        }
                    }
                }
                document.onclick = function(e) {
                    var evt = window.event || e;
                    evt.returnValue = false;
                    evt.cancelBubble = true;
                    if (evt.stopPropagation) evt.stopPropagation();
                    if (event.preventDefault) event.preventDefault();

                    sCode = isCodeLanguageVB ? 'Public ReadOnly Property var() As type Get Return Find(Of type)(By.SearchProperties(searchparams)) End Get End Property' : 'public type var { get { return Find<type>(By.SearchProperties(searchparams)); } }';
                    var sProperties = '';
                    var sNodeName, sNodeType, sId, sName, sClass, sInnerText, sTitle, sValue;
                    if (objInQuestion != null && objInQuestion.id != 'CUITe_div2') {
                        sNodeName = objInQuestion.nodeName != null ? objInQuestion.nodeName.toLowerCase() : '';
                        sNodeType = objInQuestion.getAttribute('type') != null ? objInQuestion.getAttribute('type').toLowerCase() : '';
                        sId = objInQuestion.id != null ? objInQuestion.id : '';
                        sName = objInQuestion.name != null ? objInQuestion.name : '';
                        sClass = objInQuestion.getAttribute('class') != null ? objInQuestion.getAttribute('class') : '';
                        sInnerText = objInQuestion.innerText != null ? objInQuestion.innerText : '';
                        sTitle = objInQuestion.getAttribute('title') != null ? objInQuestion.getAttribute('title') : '';
                        sValue = objInQuestion.getAttribute('value') != null ? objInQuestion.getAttribute('value') : '';
                    }

                    var sVarPrefix;

                    if (sNodeName == 'button') {
                        sVarPrefix = 'btn';
                        sCode = sCode.replace(/type/g, 'HtmlButton');
                    }
                    if (sNodeName == 'input' && (sNodeType == 'button' || sNodeType == 'submit' || sNodeType == 'image')) {
                        sVarPrefix = 'btn';
                        sCode = sCode.replace(/type/g, 'HtmlInputButton');
                    }
                    if (sNodeName == 'input' && sNodeType == 'checkbox') {
                        sVarPrefix = 'chk';
                        sCode = sCode.replace(/type/g, 'HtmlCheckBox');
                    }
                    if (sNodeName == 'input' && sNodeType == 'radio') {
                        sVarPrefix = 'rad';
                        sCode = sCode.replace(/type/g, 'HtmlRadioButton');
                    }
                    if (sNodeName == 'a') {
                        sVarPrefix = 'lnk';
                        sCode = sCode.replace(/type/g, 'HtmlHyperlink');
                    }
                    if (sNodeName == 'input' && sNodeType == 'text') {
                        sVarPrefix = 'txt';
                        sCode = sCode.replace(/type/g, 'HtmlEdit');
                    }
                    if (sNodeName == 'input' && sNodeType == 'password') {
                        sVarPrefix = 'txt';
                        sCode = sCode.replace(/type/g, 'HtmlPassword');
                    }
                    if (sNodeName == 'textarea') {
                        sVarPrefix = 'txt';
                        sCode = sCode.replace(/type/g, 'HtmlTextArea');
                    }
                    if (sNodeName == 'img') {
                        sVarPrefix = 'img';
                        sCode = sCode.replace(/type/g, 'HtmlImage');
                    }
                    if (sNodeName == 'table') {
                        sVarPrefix = 'tbl';
                        sCode = sCode.replace(/type/g, 'HtmlTable');
                    }
                    if (sNodeName == 'label') {
                        sVarPrefix = 'lbl';
                        sCode = sCode.replace(/type/g, 'HtmlLabel');
                    }
                    if (sNodeName == 'select') {
                        sVarPrefix = 'cbo';
                        sCode = sCode.replace(/type/g, 'HtmlComboBox');
                    }
                    if (sNodeName == 'div') {
                        sVarPrefix = 'div';
                        sCode = sCode.replace(/type/g, 'HtmlDiv');
                    }
                    if (sNodeName == 'span') {
                        sVarPrefix = 'spn';
                        sCode = sCode.replace(/type/g, 'HtmlSpan');
                    }
                    if (sNodeName == 'td') {
                        sVarPrefix = 'cel';
                        sCode = sCode.replace(/type/g, 'HtmlCell');
                    }

                    if (sId != '') {
                        sProperties += ';Id=' + sId;
                    }
                    else {
                        if (sName != '') {
                            sProperties += ';Name=' + sName;
                        }
                        if (sClass != '') {
                            sProperties += ';Class=' + sClass;
                        }
                        if (sName != '') {
                            sProperties += ';Name=' + sName;
                        }
                        if (sInnerText != '') {
                            sProperties += ';InnerText=' + sInnerText;
                        }
                        if (sTitle != '') {
                            sProperties += ';Title=' + sTitle;
                        }
                        if (sValue != '') {
                            sProperties += ';Value=' + sValue;
                        }
                    }
                    sProperties = sProperties.substring(1);

                    var sVarNameEval = setVarNameFromId(sId);
                    if (sVarNameEval == '') {
                        sVarNameEval = sVarPrefix + getVarName(sInnerText, sTitle, sValue, sName, sId).replace(/ /g, '');
                    }

                    sCode = sCode.replace('searchparams', String.fromCharCode(34) + sProperties + String.fromCharCode(34));
                    sCode = isCodeLanguageVB ? sCode.replace(' var() ', ' ' + sVarNameEval + '() ') : sCode.replace(' var ', ' ' + sVarNameEval + ' ');
                    top.sCode = sCode;
                }
                function isElementIframe(elementName) {
                    return elementName !== undefined && elementName !== null && elementName.toString() === 'iframe';
                }
                function AddDiv2() {
                    var divTag2 = document.getElementById('CUITe_div2');
                    if (divTag2 == null) {
                        divTag2 = document.createElement('div');
                        divTag2.id = 'CUITe_div2';
                        divTag2.style.margin = '0px auto';
                        divTag2.style.filter = 'alpha(opacity=\'100\')';
                        divTag2.style.position = 'fixed';
                        divTag2.style.wordWrap = 'break-word';
                        divTag2.style.zIndex = 77777;
                        document.body.appendChild(divTag2);
                    }
                    divTag2.style.border = 'none';
                    divTag2.style.visibility = 'visible';
                    return divTag2;
                }
                function getValues() {
                    return top.sCode;
                }
                function getHtmlCode() {
                    return sOutHtml;
                }
                function removeScript() {
                    var scriptele = document.getElementById('CUITe_Script');
                    scriptele.parentNode.removeChild(scriptele);
                    scriptele = null;
                    document.onmouseover = null;
                    document.onmouseout = null;
                    document.onclick = null;
                }
                function setVarNameFromId(sId) {
                    var sVarEval = '';
                    if (sId.indexOf('_btn') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_btn') + 1);
                    }
                    else if (sId.indexOf('_chk') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_chk') + 1);
                    }
                    else if (sId.indexOf('_rad') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_rad') + 1);
                    }
                    else if (sId.indexOf('_txt') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_txt') + 1);
                    }
                    else if (sId.indexOf('_lst') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_lst') + 1);
                    }
                    else if (sId.indexOf('_cbo') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_cbo') + 1);
                    }
                    else if (sId.indexOf('_lnk') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_lnk') + 1);
                    }
                    else if (sId.indexOf('_dg') > 0) {
                        sVarEval = sId.substring(sId.indexOf('_dg') + 1);
                    }
                    return sVarEval;
                }
                function getVarName(sInnerText, sTitle, sValue, sName, sId) {
                    var sVarName;
                    if (sInnerText != '') {
                        sVarName = sInnerText;
                    }
                    else if (sTitle != '') {
                        sVarName = sTitle;
                    }
                    else if (sValue != '') {
                        sVarName = sValue;
                    }
                    else if (sName != '') {
                        sVarName = sName;
                    }
                    else if (sId != '') {
                        sVarName = sId;
                    }
                    else
                    {
                        sVarName = 'Undefined';
                    }

                    sVarName = sVarName.camelCase();
                    sVarName = sVarName.replace(/ /g, '');
                    sVarName = sVarName.replace(/[^a-zA-Z 0-9]+/g, '');
                    if (sVarName.length > 25) {
                        vTempCounter++;
                        sVarName = 'Temp' + vTempCounter.toString();
                    }
                    return sVarName;
                }
                function getWindowTitle() {
                    return String.fromCharCode(34) + document.title + String.fromCharCode(34);
                }
                function getWinTitForClassName() {
                    return document.title.camelCase().replace(/ /g, '').replace(/[^a-zA-Z 0-9]+/g, '');
                }
                function setFilter(sFil) {
                    sFilter = sFil;
                }
                function FindParentForFilter(child) {
                    while (child.nodeName != sFilter) {
                        child = child.parentNode;
                        if (child != null) {
                            return FindParentForFilter(child);
                        }
                        else {
                            break;
                        }
                    }
                    return child;
                }
                String.prototype.camelCase = function() {
                    var s = this;
                    return ( /\S[A-Z]/.test(s) ) ?
                        s.replace(/(.)([A-Z])/g, function(t, a, b) {
                            return a + ' ' + b.toUpperCase();
                        }) :
                        s.replace(/( )([a-z])/g, function(t, a, b) {
                            return b.toUpperCase();
                        });
                };
            ");
            return script;
        }

        // remove
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var sb = new StringBuilder();

                sb.AppendLine(isCodeLanguageVB ? "Imports System" : "using System;");
                sb.AppendLine(isCodeLanguageVB ? "Imports System.Collections.Generic" : "using System.Collections.Generic;");
                sb.AppendLine(isCodeLanguageVB ? "Imports System.Linq" : "using System.Linq;");
                sb.AppendLine(isCodeLanguageVB ? "Imports System.Text" : "using System.Text;");
                sb.AppendLine(isCodeLanguageVB ? "Imports CUITe.SearchConfigurations" : "using CUITe.SearchConfigurations;");
                sb.AppendLine(isCodeLanguageVB ? "Imports Microsoft.VisualStudio.TestTools.UITesting" : "using Microsoft.VisualStudio.TestTools.UITesting;");
                sb.AppendLine(isCodeLanguageVB ? "Imports CUITe.Controls.HtmlControls" : "using CUITe.Controls.HtmlControls;");
                sb.AppendLine(isCodeLanguageVB ? "Imports CUITe.PageObjects" : "using CUITe.PageObjects;");
                sb.AppendLine();
                sb.AppendLine(isCodeLanguageVB ? "Namespace PageObjects" : "namespace $ProjectNameSpace$.PageObjects");
                
                if (!isCodeLanguageVB) sb.AppendLine("{");
                
                string sWinTitle = (string)document.InvokeScript("getWinTitForClassName");
                sb.AppendLine(isCodeLanguageVB ? "\tPublic Class " + sWinTitle : "\tpublic class " + sWinTitle + " : Page");
                if (isCodeLanguageVB) sb.AppendLine("\t\tInherits Page");
                if (!isCodeLanguageVB) sb.AppendLine("\t{");

                foreach (string sLine in listBox1.Items)
                {
                    sb.AppendLine("\t\t" + sLine.Replace("\n", ""));
                }

                sb.AppendLine(isCodeLanguageVB ? "\tEnd Class" : "\t}");
                sb.AppendLine(isCodeLanguageVB ? "End Namespace" : "}");

                File.WriteAllText(mydocpath + @"\CUITe_ObjectRecorder_temp.txt", sb.ToString());

                Process.Start("notepad.exe", mydocpath + @"\CUITe_ObjectRecorder_temp.txt");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var sHtml = (string)document.InvokeScript("getHtmlCode");
            Clipboard.SetText(sHtml);
            string commentMarker = isCodeLanguageVB ? "' " : "// ";
            listBox1.Items.Add(commentMarker + sHtml);
        }

        private void toolStripDropDownButton1_TextChanged(object sender, EventArgs e)
        {
            if (document != null)
            {
                document.InvokeScript("setFilter", new object[] { toolStripDropDownButton1.Text.Trim() });
            }
            else
            {
                toolStripStatusLabel1.Text = "ERROR: Document not loaded yet.";
            }
        }

        private void btnLanguage_ButtonClick(object sender, EventArgs e)
        {

        }

        private void menuItemVB_Click(object sender, EventArgs e)
        {
            checkLanguage(CodeLanguage.VB);
        }

        private void menuItemCSharp_Click(object sender, EventArgs e)
        {
            checkLanguage(CodeLanguage.CSharp);
        }

        private void checkLanguage(CodeLanguage lang)
        {
            menuItemVB.Checked = false;
            menuItemCSharp.Checked = false;
            string btnLanguageText = string.Empty;
            if (lang == CodeLanguage.VB)
            {
                menuItemVB.Checked = true;
                btnLanguageText = menuItemVB.Text;
            }
            if (lang == CodeLanguage.CSharp)
            {
                menuItemCSharp.Checked = true;
                btnLanguageText = menuItemCSharp.Text;
            }
            btnLanguage.Text = btnLanguageText;
            isCodeLanguageVB = lang == CodeLanguage.VB;

            //clear
            listBox1.Items.Clear();
            btnRecord.Checked = false;
            btnRecord.PerformClick();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripTextBox1.Text);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Navigate(toolStripTextBox1.Text);
        }

        private void Navigate(String address)
        {
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
        }
    }
}