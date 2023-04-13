using Microsoft.Office.Tools.Ribbon;
using System;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EmailHeadersViewer
{
    public partial class RibbonEmailHeaders
    {
        private Microsoft.Office.Tools.CustomTaskPane taskPane;
        public HeadersViewer userControl;

        private void RibbonEmailHeaders_Load(object sender, RibbonUIEventArgs e)
        {
            Globals.ThisAddIn.Application.Inspectors.NewInspector += Inspectors_NewInspector;
        }

        private void Inspectors_NewInspector(Outlook.Inspector inspector)
        {
            if (inspector.CurrentItem is Outlook.MailItem mailItem)
            {
                mailItem.Read += MailItem_Read;
            }
        }

        private void MailItem_Read()
        {
            string headers = GetSelectedEmailHeaders();
            if (userControl != null)
            {
                userControl.DisplayHeaders(headers);
                userControl.DisplayHeadersAll(headers);
            }
        }

        public static string GetSelectedEmailHeaders()
        {
            string headers = string.Empty;
            Outlook.Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
            if (explorer != null && explorer.Selection.Count == 1 && explorer.Selection[1] is Outlook.MailItem mailItem)
            {
                headers = GetEmailHeaders(mailItem);
            }
            return headers;
        }

        private static string GetEmailHeaders(Outlook.MailItem mailItem)
        {
            if (mailItem == null) return string.Empty;
            string headers = string.Empty;
            headers = mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001E")?.ToString();
            return headers;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            if (taskPane == null || !taskPane.Visible)
            {
                userControl = new HeadersViewer();
                taskPane = Globals.ThisAddIn.CustomTaskPanes.Add(userControl, "Headers Viewer");
                taskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
                taskPane.Width = 400;
                taskPane.Visible = true;
            }

            string headers = GetSelectedEmailHeaders();
            userControl.DisplayHeaders(headers);
            userControl.DisplayHeadersAll(headers);
            userControl.ReloadHeaders();
        }
    }
}
