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
            string[] headersArray = headers.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            DataTable dtHeaders = new DataTable();
            dtHeaders.Columns.Add("Header", typeof(string));
            dtHeaders.Columns.Add("Value", typeof(string));

            foreach (string header in headersArray)
            {
                string[] headerParts = header.Split(new char[] { ':' }, 2);

                if (headerParts.Length == 2)
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

    }
}
