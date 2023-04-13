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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHeaders = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reloadButton = new System.Windows.Forms.Button();
            this.copyImportantButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reloadButton2 = new System.Windows.Forms.Button();
            this.CopyAllButton2 = new System.Windows.Forms.Button();
            this.dataGridViewHeadersAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeaders)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadersAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHeaders
            // 
            this.dataGridViewHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewHeaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHeaders.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewHeaders.Name = "dataGridViewHeaders";
            this.dataGridViewHeaders.RowHeadersVisible = false;
            this.dataGridViewHeaders.RowHeadersWidth = 4;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHeaders.Size = new System.Drawing.Size(271, 275);
            this.dataGridViewHeaders.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 453);
            this.tabControl1.TabIndex = 2;
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
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeadersAll.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewHeadersAll.Size = new System.Drawing.Size(277, 392);
            this.dataGridViewHeadersAll.TabIndex = 1;
            // 
            // HeadersViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "HeadersViewer";
            this.Size = new System.Drawing.Size(297, 459);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeaders)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeadersAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewHeaders;
        private System.Windows.Forms.DataGridView dataGridViewHeadersAll;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button copyImportantButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button CopyAllButton2;
        private System.Windows.Forms.Button reloadButton2;
    }
}
