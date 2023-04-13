namespace EmailHeadersViewer
{
    partial class HeadersViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHeaders = new System.Windows.Forms.DataGridView();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reloadButton = new System.Windows.Forms.Button();
            this.copyImportantButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reloadButton2 = new System.Windows.Forms.Button();
            this.CopyAllButton2 = new System.Windows.Forms.Button();
            this.dataGridViewHeadersAll = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeaders)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadersAll)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHeaders
            // 
            this.dataGridViewHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewHeaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaders.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewHeaders.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewHeaders.Name = "dataGridViewHeaders";
            this.dataGridViewHeaders.RowHeadersVisible = false;
            this.dataGridViewHeaders.RowHeadersWidth = 4;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaders.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewHeaders.Size = new System.Drawing.Size(271, 275);
            this.dataGridViewHeaders.TabIndex = 1;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(291, 453);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reloadButton);
            this.tabPage1.Controls.Add(this.copyImportantButton);
            this.tabPage1.Controls.Add(this.dataGridViewHeaders);
            this.tabPage1.Controls.Add(this.copyButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Important";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.LimeGreen;
            this.reloadButton.Location = new System.Drawing.Point(6, 6);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(97, 23);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload Headers";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // copyImportantButton
            // 
            this.copyImportantButton.Location = new System.Drawing.Point(6, 35);
            this.copyImportantButton.Name = "copyImportantButton";
            this.copyImportantButton.Size = new System.Drawing.Size(97, 23);
            this.copyImportantButton.TabIndex = 2;
            this.copyImportantButton.Text = "Copy Important";
            this.copyImportantButton.UseVisualStyleBackColor = true;
            this.copyImportantButton.Visible = false;
            this.copyImportantButton.Click += new System.EventHandler(this.copyImportantButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Transparent;
            this.copyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copyButton.Location = new System.Drawing.Point(6, 345);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(115, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Copy ALL Headers";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reloadButton2);
            this.tabPage2.Controls.Add(this.CopyAllButton2);
            this.tabPage2.Controls.Add(this.dataGridViewHeadersAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(283, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Headers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reloadButton2
            // 
            this.reloadButton2.BackColor = System.Drawing.Color.LimeGreen;
            this.reloadButton2.Location = new System.Drawing.Point(124, 6);
            this.reloadButton2.Name = "reloadButton2";
            this.reloadButton2.Size = new System.Drawing.Size(75, 23);
            this.reloadButton2.TabIndex = 3;
            this.reloadButton2.Text = "Reload";
            this.reloadButton2.UseVisualStyleBackColor = false;
            this.reloadButton2.Click += new System.EventHandler(this.reloadButton2_Click);
            // 
            // CopyAllButton2
            // 
            this.CopyAllButton2.Location = new System.Drawing.Point(3, 6);
            this.CopyAllButton2.Name = "CopyAllButton2";
            this.CopyAllButton2.Size = new System.Drawing.Size(115, 23);
            this.CopyAllButton2.TabIndex = 2;
            this.CopyAllButton2.Text = "Copy ALL Headers";
            this.CopyAllButton2.UseVisualStyleBackColor = true;
            this.CopyAllButton2.Click += new System.EventHandler(this.CopyAllButton2_Click);
            // 
            // dataGridViewHeadersAll
            // 
            this.dataGridViewHeadersAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHeadersAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewHeadersAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHeadersAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeadersAll.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewHeadersAll.Name = "dataGridViewHeadersAll";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeadersAll.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewHeadersAll.Size = new System.Drawing.Size(277, 392);
            this.dataGridViewHeadersAll.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(283, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 226);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Developed by Tri Nguyen\r\ntri.nguyen@telus.com\r\n\r\nVersion: 0.2.0-beta";
            // 
            // HeadersViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl3);
            this.Name = "HeadersViewer";
            this.Size = new System.Drawing.Size(297, 459);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeaders)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadersAll)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewHeaders;
        private System.Windows.Forms.DataGridView dataGridViewHeadersAll;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button copyImportantButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button CopyAllButton2;
        private System.Windows.Forms.Button reloadButton2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
