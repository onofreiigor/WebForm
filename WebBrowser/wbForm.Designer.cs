namespace WebBrowser
{
    partial class wbForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbMainBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbMainBrowser
            // 
            this.wbMainBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMainBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbMainBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMainBrowser.Name = "wbMainBrowser";
            this.wbMainBrowser.Size = new System.Drawing.Size(1124, 534);
            this.wbMainBrowser.TabIndex = 0;
            this.wbMainBrowser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.wbMainBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMainBrowser_DocumentCompleted);
            // 
            // wbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 534);
            this.Controls.Add(this.wbMainBrowser);
            this.Name = "wbForm";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.wbForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wbForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMainBrowser;
    }
}

