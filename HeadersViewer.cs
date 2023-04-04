using Microsoft.Office.Tools.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmailHeadersViewer
{
    public partial class HeadersViewer : UserControl
    {
        public HeadersViewer()
        {
            InitializeComponent();
        }

        public void DisplayHeaders(string headers)
        {
            string[] headersArray = headers.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            DataTable dtHeaders = new DataTable();
            dtHeaders.Columns.Add("Header", typeof(string));
            dtHeaders.Columns.Add("Value", typeof(string));

            string[] headersToDisplay = { "authentication-results", "delivered-to", "from", "x-originating-ip", "x-original-ip", "return-path" }; // add more headers to display here

            foreach (string header in headersArray)
            {
                string[] headerParts = header.Split(new char[] { ':' }, 2);

                if (headerParts.Length == 2 && headersToDisplay.Contains(headerParts[0].Trim().ToLower()))
                {
                    DataRow dr = dtHeaders.NewRow();
                    dr[0] = headerParts[0];
                    dr[1] = headerParts[1].Trim();
                    dtHeaders.Rows.Add(dr);
                }
            }

            dataGridViewHeaders.DataSource = dtHeaders;
            DataGridViewColumn column = dataGridViewHeaders.Columns[1];
            dataGridViewHeaders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string headers = RibbonEmailHeaders.GetSelectedEmailHeaders();
            Clipboard.SetText(headers);
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Copied All Headers!", copyButton, 4, copyButton.Height+4, 1000);
        }

        private void copyImportantButton_Click(object sender, EventArgs e)
        {
            string headers = RibbonEmailHeaders.GetSelectedEmailHeaders();
            string[] headersToDisplay = { "authentication-results", "delivered-to", "from", "x-originating-ip", "x-original-ip", "return-path" };

            StringBuilder sb = new StringBuilder();
            foreach (string header in headersToDisplay)
            {
                int startIndex = headers.IndexOf(header + ":", StringComparison.InvariantCultureIgnoreCase);
                if (startIndex != -1)
                {
                    int endIndex = headers.IndexOf("\r\n", startIndex);
                    if (endIndex != -1)
                    {
                        string headerValue = headers.Substring(startIndex, endIndex - startIndex).Trim();
                        sb.AppendLine(headerValue);
                    }
                }
            }
            string clipboardText = sb.ToString().Trim();
            if (!string.IsNullOrEmpty(clipboardText))
            {
                Clipboard.SetText(clipboardText);
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.DisplayHeaders(RibbonEmailHeaders.GetSelectedEmailHeaders());
        }

        private void CopyAllButton2_Click(object sender, EventArgs e)
        {
            string headers = RibbonEmailHeaders.GetSelectedEmailHeaders();
            Clipboard.SetText(headers);
            ToolTip tooltip = new ToolTip();
            tooltip.Show("Copied All Headers!", copyButton, 4, copyButton.Height + 4, 1000);
        }

        public void DisplayHeadersAll(string headers)
        {
            string[] headersArrayAll = headers.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            DataTable dtHeadersAll = new DataTable();
            dtHeadersAll.Columns.Add("Header", typeof(string));
            dtHeadersAll.Columns.Add("Value", typeof(string));

            foreach (string header in headersArrayAll)
            {
                string[] headerParts = header.Split(new char[] { ':' }, 2);

                if (headerParts.Length == 2)
                {
                    DataRow dr = dtHeadersAll.NewRow();
                    dr[0] = headerParts[0];
                    dr[1] = headerParts[1].Trim();
                    dtHeadersAll.Rows.Add(dr);
                }
            }

            dataGridViewHeadersAll.DataSource = dtHeadersAll;
            DataGridViewColumn column = dataGridViewHeadersAll.Columns[1];
            dataGridViewHeadersAll.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = 1;
        }

        private void reloadButton2_Click(object sender, EventArgs e)
        {
            this.DisplayHeadersAll(RibbonEmailHeaders.GetSelectedEmailHeaders());
        }
    }
}
