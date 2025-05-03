namespace Kelime_İşlemci_Uygulaması
{
    partial class FindAndReplace
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
            this.findTxt = new System.Windows.Forms.TextBox();
            this.replaceTxt = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.replaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findTxt
            // 
            this.findTxt.Location = new System.Drawing.Point(12, 12);
            this.findTxt.Name = "findTxt";
            this.findTxt.Size = new System.Drawing.Size(100, 22);
            this.findTxt.TabIndex = 0;
            // 
            // replaceTxt
            // 
            this.replaceTxt.Location = new System.Drawing.Point(12, 40);
            this.replaceTxt.Name = "replaceTxt";
            this.replaceTxt.Size = new System.Drawing.Size(100, 22);
            this.replaceTxt.TabIndex = 1;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(118, 12);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(148, 24);
            this.find.TabIndex = 2;
            this.find.Text = "Ara";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(118, 39);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(61, 24);
            this.replace.TabIndex = 3;
            this.replace.Text = "Değiştir";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // replaceAll
            // 
            this.replaceAll.Location = new System.Drawing.Point(185, 39);
            this.replaceAll.Name = "replaceAll";
            this.replaceAll.Size = new System.Drawing.Size(81, 24);
            this.replaceAll.TabIndex = 4;
            this.replaceAll.Text = "H. Değiştir";
            this.replaceAll.UseVisualStyleBackColor = true;
            this.replaceAll.Click += new System.EventHandler(this.replaceAll_Click);
            // 
            // FindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 67);
            this.Controls.Add(this.replaceAll);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.find);
            this.Controls.Add(this.replaceTxt);
            this.Controls.Add(this.findTxt);
            this.Name = "FindAndReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindAndReplace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindAndReplace_FormClosing);
            this.Load += new System.EventHandler(this.FindAndReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findTxt;
        private System.Windows.Forms.TextBox replaceTxt;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button replaceAll;
    }
}