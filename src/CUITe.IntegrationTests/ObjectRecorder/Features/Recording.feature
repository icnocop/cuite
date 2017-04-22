Feature: Recording
    
Scenario: Record
    Given an html file with the contents
"""
<html>
    <head>
        <title>test</title>
    </head>
    <body>
        <div id=""div1"">
            <input type=""text""/>
        </div>
    </body>
</html>
"""
    And the html file is launched with the recorder
    When recording is started
    And the textbox is clicked
    Then the generated file should contain
"""
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;

namespace $ProjectNameSpace$.PageObjects
{
	public class test : Page
	{
		public HtmlEdit txtUndefined { get { return Find<HtmlEdit>(By.SearchProperties("")); } }
	}
}
"""
