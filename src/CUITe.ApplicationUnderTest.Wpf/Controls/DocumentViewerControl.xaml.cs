using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Xps.Packaging;

namespace CUITe.ApplicationUnderTest.Wpf.Controls
{
    public partial class DocumentViewerControl
    {
        public DocumentViewerControl()
        {
            InitializeComponent();

            // Prevent Visual Studio from trying to load the document in designer mode
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                var document = new XpsDocument(DocumentPath, FileAccess.Read);
                documentViewer.Document = document.GetFixedDocumentSequence();    
            }
        }

        private static string DocumentPath
        {
            get
            {
                return Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "Resources",
                    "Sample.xps");
            }
        }
    }
}