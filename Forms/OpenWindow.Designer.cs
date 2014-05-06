namespace WikiBrowser
{
    partial class OpenWindow
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
            this.labelWikiRpcUri = new System.Windows.Forms.Label();
            this.textBoxWikiRpcUri = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWikiRpcUri
            // 
            this.labelWikiRpcUri.AutoSize = true;
            this.labelWikiRpcUri.Location = new System.Drawing.Point(13, 13);
            this.labelWikiRpcUri.Name = "labelWikiRpcUri";
            this.labelWikiRpcUri.Size = new System.Drawing.Size(71, 12);
            this.labelWikiRpcUri.TabIndex = 0;
            this.labelWikiRpcUri.Text = "WikiRpc &URI:";
            // 
            // textBoxWikiRpcUri
            // 
            this.textBoxWikiRpcUri.Location = new System.Drawing.Point(15, 29);
            this.textBoxWikiRpcUri.Name = "textBoxWikiRpcUri";
            this.textBoxWikiRpcUri.Size = new System.Drawing.Size(337, 19);
            this.textBoxWikiRpcUri.TabIndex = 1;
            this.textBoxWikiRpcUri.Text = "http://pukiwiki.logue.be/?cmd=xmlrpc";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(277, 54);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen.Location = new System.Drawing.Point(196, 54);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "&Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // OpenWindow
            // 
            this.AcceptButton = this.buttonOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(364, 89);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxWikiRpcUri);
            this.Controls.Add(this.labelWikiRpcUri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWindow";
            this.ShowInTaskbar = false;
            this.Text = "OpenWindow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWikiRpcUri;
        private System.Windows.Forms.TextBox textBoxWikiRpcUri;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOpen;
    }
}