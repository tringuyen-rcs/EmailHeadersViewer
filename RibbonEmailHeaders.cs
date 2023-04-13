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
            if (mailItem.MessageClass == "IPM.Note" || mailItem.MessageClass == "IPM.Note.SMIME")
            {
                // This is an email message, so return its headers
                return mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001E")?.ToString() ?? string.Empty;
            }
            else if (mailItem.Attachments.Count > 0)
            {
                // This email contains an attachment, so recursively search for the innermost email within the attachment
                Outlook.Attachment attachment = mailItem.Attachments[1];
                if (attachment.Type == Outlook.OlAttachmentType.olEmbeddeditem)
                {
                    Outlook.MailItem innerMailItem = attachment.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x37010102") as Outlook.MailItem;
                    return GetEmailHeaders(innerMailItem);
                }
                else if (attachment.FileName.EndsWith(".msg", StringComparison.OrdinalIgnoreCase) || attachment.FileName.EndsWith(".eml", StringComparison.OrdinalIgnoreCase))
                {
                    Outlook.MailItem innerMailItem = null;
                    try
                    {
                        innerMailItem = attachment.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x37010102") as Outlook.MailItem;
                    }
                    catch (System.Exception)
                    {
                        // Unable to retrieve inner message from attachment, return headers of outer message
                        return GetEmailHeaders(mailItem);
                    }
                    return GetEmailHeaders(innerMailItem);
                }
            }
            // This is not an email message, so return an empty string
            return string.Empty;
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
        }
    }
}
