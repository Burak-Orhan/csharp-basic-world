namespace Kelime_İşlemci_Uygulaması
{
    partial class Editor
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.colorDiyalog = new System.Windows.Forms.ColorDialog();
            this.fontColor = new System.Windows.Forms.Button();
            this.bold = new System.Windows.Forms.Button();
            this.italic = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.normal = new System.Windows.Forms.Button();
            this.backgroundColor = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.sup = new System.Windows.Forms.Button();
            this.strikeout = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recessRomanNumber = new System.Windows.Forms.Button();
            this.recessNumber = new System.Windows.Forms.Button();
            this.recess = new System.Windows.Forms.Button();
            this.alignCenter = new System.Windows.Forms.Button();
            this.alignRight = new System.Windows.Forms.Button();
            this.alignLeft = new System.Windows.Forms.Button();
            this.saveDiyalog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.image = new System.Windows.Forms.Button();
            this.findAndReplace = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontColor
            // 
            this.fontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontColor.ForeColor = System.Drawing.Color.DarkViolet;
            this.fontColor.Location = new System.Drawing.Point(317, 55);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(35, 28);
            this.fontColor.TabIndex = 0;
            this.fontColor.Text = "A";
            this.fontColor.UseVisualStyleBackColor = true;
            this.fontColor.Click += new System.EventHandler(this.fontColor_Click);
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bold.Location = new System.Drawing.Point(6, 55);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(39, 28);
            this.bold.TabIndex = 1;
            this.bold.Text = "K";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.italic.Location = new System.Drawing.Point(51, 55);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(39, 28);
            this.italic.TabIndex = 2;
            this.italic.Text = "T";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.underline.Location = new System.Drawing.Point(96, 55);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(39, 28);
            this.underline.TabIndex = 3;
            this.underline.Text = "A";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // fontBox
            // 
            this.fontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Location = new System.Drawing.Point(6, 21);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(202, 28);
            this.fontBox.TabIndex = 5;
            this.fontBox.SelectedIndexChanged += new System.EventHandler(this.fontBox_SelectedIndexChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(214, 22);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(97, 28);
            this.sizeBox.TabIndex = 6;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normal);
            this.groupBox1.Controls.Add(this.backgroundColor);
            this.groupBox1.Controls.Add(this.sizeBox);
            this.groupBox1.Controls.Add(this.sub);
            this.groupBox1.Controls.Add(this.fontColor);
            this.groupBox1.Controls.Add(this.sup);
            this.groupBox1.Controls.Add(this.strikeout);
            this.groupBox1.Controls.Add(this.fontBox);
            this.groupBox1.Controls.Add(this.underline);
            this.groupBox1.Controls.Add(this.italic);
            this.groupBox1.Controls.Add(this.bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazı Tipi";
            // 
            // normal
            // 
            this.normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.normal.Location = new System.Drawing.Point(186, 56);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(39, 28);
            this.normal.TabIndex = 13;
            this.normal.Text = "x";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.Color.Black;
            this.backgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backgroundColor.ForeColor = System.Drawing.Color.White;
            this.backgroundColor.Location = new System.Drawing.Point(317, 22);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.Size = new System.Drawing.Size(35, 28);
            this.backgroundColor.TabIndex = 12;
            this.backgroundColor.Text = "B";
            this.backgroundColor.UseVisualStyleBackColor = false;
            this.backgroundColor.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sub.Location = new System.Drawing.Point(231, 56);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(35, 28);
            this.sub.TabIndex = 9;
            this.sub.Text = "x₂";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // sup
            // 
            this.sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sup.Location = new System.Drawing.Point(272, 55);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(39, 28);
            this.sup.TabIndex = 8;
            this.sup.Text = "x²";
            this.sup.UseVisualStyleBackColor = true;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // strikeout
            // 
            this.strikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.strikeout.Location = new System.Drawing.Point(141, 55);
            this.strikeout.Name = "strikeout";
            this.strikeout.Size = new System.Drawing.Size(39, 28);
            this.strikeout.TabIndex = 7;
            this.strikeout.Text = "ab";
            this.strikeout.UseVisualStyleBackColor = true;
            this.strikeout.Click += new System.EventHandler(this.strikeout_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 137);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(776, 301);
            this.richTextBox.TabIndex = 8;
            this.richTextBox.Text = "";
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menu Strip";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recessRomanNumber);
            this.groupBox2.Controls.Add(this.recessNumber);
            this.groupBox2.Controls.Add(this.recess);
            this.groupBox2.Controls.Add(this.alignCenter);
            this.groupBox2.Controls.Add(this.alignRight);
            this.groupBox2.Controls.Add(this.alignLeft);
            this.groupBox2.Location = new System.Drawing.Point(366, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paragraf";
            // 
            // recessRomanNumber
            // 
            this.recessRomanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recessRomanNumber.Location = new System.Drawing.Point(96, 56);
            this.recessRomanNumber.Name = "recessRomanNumber";
            this.recessRomanNumber.Size = new System.Drawing.Size(39, 28);
            this.recessRomanNumber.TabIndex = 7;
            this.recessRomanNumber.Text = "Ⅺ";
            this.recessRomanNumber.UseVisualStyleBackColor = true;
            this.recessRomanNumber.Click += new System.EventHandler(this.recessRomanNumber_Click);
            // 
            // recessNumber
            // 
            this.recessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recessNumber.Location = new System.Drawing.Point(51, 56);
            this.recessNumber.Name = "recessNumber";
            this.recessNumber.Size = new System.Drawing.Size(39, 28);
            this.recessNumber.TabIndex = 6;
            this.recessNumber.Text = "1.";
            this.recessNumber.UseVisualStyleBackColor = true;
            this.recessNumber.Click += new System.EventHandler(this.recessNumber_Click);
            // 
            // recess
            // 
            this.recess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recess.Location = new System.Drawing.Point(6, 55);
            this.recess.Name = "recess";
            this.recess.Size = new System.Drawing.Size(39, 28);
            this.recess.TabIndex = 5;
            this.recess.Text = "•";
            this.recess.UseVisualStyleBackColor = true;
            this.recess.Click += new System.EventHandler(this.recess_Click);
            // 
            // alignCenter
            // 
            this.alignCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignCenter.Location = new System.Drawing.Point(51, 22);
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(39, 28);
            this.alignCenter.TabIndex = 4;
            this.alignCenter.Text = "⇈";
            this.alignCenter.UseVisualStyleBackColor = true;
            this.alignCenter.Click += new System.EventHandler(this.alignCenter_Click);
            // 
            // alignRight
            // 
            this.alignRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignRight.Location = new System.Drawing.Point(96, 22);
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(39, 28);
            this.alignRight.TabIndex = 3;
            this.alignRight.Text = "⇉";
            this.alignRight.UseVisualStyleBackColor = true;
            this.alignRight.Click += new System.EventHandler(this.alignRight_Click);
            // 
            // alignLeft
            // 
            this.alignLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alignLeft.Location = new System.Drawing.Point(6, 22);
            this.alignLeft.Name = "alignLeft";
            this.alignLeft.Size = new System.Drawing.Size(39, 28);
            this.alignLeft.TabIndex = 2;
            this.alignLeft.Text = "⮄";
            this.alignLeft.UseVisualStyleBackColor = true;
            this.alignLeft.Click += new System.EventHandler(this.alignLeft_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.image);
            this.groupBox3.Controls.Add(this.findAndReplace);
            this.groupBox3.Controls.Add(this.print);
            this.groupBox3.Controls.Add(this.paste);
            this.groupBox3.Controls.Add(this.copy);
            this.groupBox3.Controls.Add(this.cut);
            this.groupBox3.Location = new System.Drawing.Point(517, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aksiyonlar";
            // 
            // image
            // 
            this.image.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.image.Location = new System.Drawing.Point(96, 55);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(39, 28);
            this.image.TabIndex = 9;
            this.image.Text = "📷";
            this.image.UseVisualStyleBackColor = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // findAndReplace
            // 
            this.findAndReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findAndReplace.Location = new System.Drawing.Point(51, 56);
            this.findAndReplace.Name = "findAndReplace";
            this.findAndReplace.Size = new System.Drawing.Size(39, 28);
            this.findAndReplace.TabIndex = 8;
            this.findAndReplace.Text = "⌕";
            this.findAndReplace.UseVisualStyleBackColor = true;
            this.findAndReplace.Click += new System.EventHandler(this.findAndReplace_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.print.Location = new System.Drawing.Point(6, 56);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(39, 28);
            this.print.TabIndex = 7;
            this.print.Text = "🖶";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // paste
            // 
            this.paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paste.Location = new System.Drawing.Point(96, 21);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(39, 28);
            this.paste.TabIndex = 6;
            this.paste.Text = "⌘";
            this.paste.UseVisualStyleBackColor = true;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.copy.Location = new System.Drawing.Point(51, 20);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(39, 28);
            this.copy.TabIndex = 5;
            this.copy.Text = "📋";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // cut
            // 
            this.cut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cut.Location = new System.Drawing.Point(6, 21);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(39, 28);
            this.cut.TabIndex = 4;
            this.cut.Text = "✄";
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Text = "Baskı önizleme";
            this.printPreviewDialog.Visible = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editör ";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDiyalog;
        private System.Windows.Forms.Button fontColor;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Button strikeout;
        private System.Windows.Forms.Button backgroundColor;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.Button normal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveDiyalog;
        private System.Windows.Forms.Button alignLeft;
        private System.Windows.Forms.Button alignRight;
        private System.Windows.Forms.Button alignCenter;
        private System.Windows.Forms.Button recess;
        private System.Windows.Forms.Button recessNumber;
        private System.Windows.Forms.Button recessRomanNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button findAndReplace;
        private System.Windows.Forms.Button image;
    }
}

