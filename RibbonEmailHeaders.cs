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

        private void RibbonEmailHeaders_Load(object sender, RibbonUIEventArgs e)
        {
            // Subscribe to the ActiveInspector events
            Outlook.Inspectors inspectors = Globals.ThisAddIn.Application.Inspectors;
            inspectors.NewInspector += new Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);

            Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
            if (inspector != null)
            {
                ((Outlook.InspectorEvents_10_Event)inspector).Activate += new Outlook.InspectorEvents_10_ActivateEventHandler(Inspector_Activate);
                ((Outlook.InspectorEvents_10_Event)inspector).Deactivate += new Outlook.InspectorEvents_10_DeactivateEventHandler(Inspector_Deactivate);
            }
        }

        private void Inspectors_NewInspector(Outlook.Inspector Inspector)
        {
            ((Outlook.InspectorEvents_10_Event)Inspector).Activate += new Outlook.InspectorEvents_10_ActivateEventHandler(Inspector_Activate);
            ((Outlook.InspectorEvents_10_Event)Inspector).Deactivate += new Outlook.InspectorEvents_10_DeactivateEventHandler(Inspector_Deactivate);
        }

        private void Inspector_Activate()
        {
            // Get the selected email's headers
            if (userControl != null)
            {
                string headers = GetSelectedEmailHeaders();
                userControl.DisplayHeaders(headers);
                userControl.DisplayHeadersAll(headers);
            }
        }

        private void Inspector_Deactivate()
        {
            // Clear the headers
            if (userControl != null)
            {
                userControl.DisplayHeaders("");
                userControl.DisplayHeadersAll("");
            }
        }

        public static string GetSelectedEmailHeaders()
        {
            string headers = string.Empty;
            Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();

            if (inspector != null && inspector.CurrentItem is Outlook.MailItem mailItem)
            {
                headers = mailItem.PropertyAccessor.GetProperty("http://schemas.microsoft.com/mapi/proptag/0x007D001E")?.ToString();
            }

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

            RibbonEmailHeaders ribbonEmailHeaders = Globals.Ribbons.GetRibbon<RibbonEmailHeaders>();

            // Get the selected email's headers
            string headers = GetSelectedEmailHeaders();
            userControl.DisplayHeaders(headers);
            userControl.DisplayHeadersAll(headers);
        }
    }
}
