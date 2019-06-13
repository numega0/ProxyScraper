namespace ProxyScraper
{
    partial class frmMain
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
            this.btnGetProxy = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnProxyTest = new System.Windows.Forms.Button();
            this.listProxy = new System.Windows.Forms.ListBox();
            this.btnProxySifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetProxy
            // 
            this.btnGetProxy.Location = new System.Drawing.Point(245, 8);
            this.btnGetProxy.Name = "btnGetProxy";
            this.btnGetProxy.Size = new System.Drawing.Size(201, 23);
            this.btnGetProxy.TabIndex = 2;
            this.btnGetProxy.Text = "Proxy Getir";
            this.btnGetProxy.UseVisualStyleBackColor = true;
            this.btnGetProxy.Click += new System.EventHandler(this.btnGetProxy_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(245, 37);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(201, 59);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnProxyTest
            // 
            this.btnProxyTest.Location = new System.Drawing.Point(245, 102);
            this.btnProxyTest.Name = "btnProxyTest";
            this.btnProxyTest.Size = new System.Drawing.Size(75, 23);
            this.btnProxyTest.TabIndex = 4;
            this.btnProxyTest.Text = "Proxy Test";
            this.btnProxyTest.UseVisualStyleBackColor = true;
            this.btnProxyTest.Click += new System.EventHandler(this.btnProxyTest_Click);
            // 
            // listProxy
            // 
            this.listProxy.FormattingEnabled = true;
            this.listProxy.Location = new System.Drawing.Point(12, 8);
            this.listProxy.Name = "listProxy";
            this.listProxy.Size = new System.Drawing.Size(227, 511);
            this.listProxy.TabIndex = 5;
            // 
            // btnProxySifirla
            // 
            this.btnProxySifirla.Location = new System.Drawing.Point(371, 102);
            this.btnProxySifirla.Name = "btnProxySifirla";
            this.btnProxySifirla.Size = new System.Drawing.Size(75, 23);
            this.btnProxySifirla.TabIndex = 6;
            this.btnProxySifirla.Text = "Proxy Reset";
            this.btnProxySifirla.UseVisualStyleBackColor = true;
            this.btnProxySifirla.Click += new System.EventHandler(this.btnProxySifirla_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 527);
            this.Controls.Add(this.btnProxySifirla);
            this.Controls.Add(this.listProxy);
            this.Controls.Add(this.btnProxyTest);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnGetProxy);
            this.Name = "frmMain";
            this.Text = "Proxy Scraper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetProxy;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnProxyTest;
        private System.Windows.Forms.ListBox listProxy;
        private System.Windows.Forms.Button btnProxySifirla;
    }
}

