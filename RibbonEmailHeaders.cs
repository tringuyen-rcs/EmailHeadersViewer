using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EmailHeadersViewer
{
    public partial class RibbonEmailHeaders
    {
        private Microsoft.Office.Tools.CustomTaskPane taskPane;
        public HeadersViewer userControl;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        public static string GetSelectedEmailHeaders()
        {
            string headers = string.Empty;
            Outlook.Selection selectedItems = Globals.ThisAddIn.Application.ActiveExplorer().Selection;

            if (selectedItems.Count == 1 && selectedItems[1] is Outlook.MailItem mailItem)
            {
                headers = mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001E")?.ToString();
            }

            return headers;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            if (taskPane == null)
            {
                userControl = new HeadersViewer();
                taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(userControl, "Headers Viewer");
                taskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
                taskPane.Width = 400;
                taskPane.Visible = true;

            }

            RibbonEmailHeaders ribbonEmailHeaders = Globals.Ribbons.GetRibbon<RibbonEmailHeaders>();

            // Get the selected email's headers
            string headers = GetSelectedEmailHeaders();
            userControl.DisplayHeaders(headers);
        }
    }
}
