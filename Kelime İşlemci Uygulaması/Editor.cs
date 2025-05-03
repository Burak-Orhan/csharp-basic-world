using Kelime_İşlemci_Uygulaması;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_İşlemci_Uygulaması
{
    public partial class Editor: Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            //Font
            foreach (FontFamily font in FontFamily.Families)
                fontBox.Items.Add(font.Name);
            fontBox.SelectedIndex = 165;

            //Size 
            float[] fontSizes = new float[]
            {
                2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 14, 16, 18, 20, 22,
                24, 26, 28, 36, 48, 72
            };

            foreach (float size in fontSizes)
                sizeBox.Items.Add(size);
            sizeBox.SelectedIndex = 10;
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            if (colorDiyalog.ShowDialog() == DialogResult.OK)
            {
                var color = colorDiyalog.Color;
                fontColor.ForeColor = color;

                if (richTextBox.SelectionLength > 0)
                {
                    richTextBox.SelectionColor = color;
                }
                else
                {
                    richTextBox.SelectionColor = color;
                }
            }
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            if (colorDiyalog.ShowDialog() == DialogResult.OK)
            {
                var color = colorDiyalog.Color;
                backgroundColor.BackColor = color;

                if (richTextBox.SelectionLength > 0)
                {
                    richTextBox.SelectionBackColor = color;
                }
                else
                {
                    richTextBox.SelectionBackColor = color;
                }
            }
        }

        private void fontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

            private void ApplyFont()
            {
                if (fontBox.SelectedItem != null && sizeBox.SelectedItem != null)
                {
                    string secilenFont = fontBox.SelectedItem.ToString();
                    float secilenBoyut = float.Parse(sizeBox.SelectedItem.ToString());

                    richTextBox.SelectionFont = new Font(secilenFont, secilenBoyut);
                }
            }

        private void bold_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Bold))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Bold;
                }

                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Italic))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Italic;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Italic;
                }

                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void underline_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Underline))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void strikeout_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                Font currentFont = richTextBox.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Style.HasFlag(FontStyle.Strikeout))
                {
                    newFontStyle = currentFont.Style & ~FontStyle.Strikeout;
                }
                else
                {
                    newFontStyle = currentFont.Style | FontStyle.Strikeout;
                }

                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionCharOffset = -5;
        }

        private void sup_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionCharOffset = +5;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionCharOffset = 0;
        }

        private void alignLeft_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignRight_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void alignCenter_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void recess_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionBullet = !richTextBox.SelectionBullet;
            richTextBox.BulletIndent = 10;
        }

        bool isAutoNumberingActive = false;
        bool isRomanNumberingActive = false;
        int lineNumber = 1;
        int romanLineNumber = 1;


        private void recessNumber_Click(object sender, EventArgs e)
        {
            isAutoNumberingActive = !isAutoNumberingActive;

            if (isAutoNumberingActive)
            {
                isRomanNumberingActive = false;
                richTextBox.Text = "1. ";
                lineNumber = 2;
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.Focus();
            }
        }

        private void recessRomanNumber_Click(object sender, EventArgs e)
        {
            isRomanNumberingActive = !isRomanNumberingActive;

            if (isRomanNumberingActive)
            {
                isAutoNumberingActive = false;

                romanLineNumber = 1;
                richTextBox.Text = ToRoman(romanLineNumber) + ". ";
                romanLineNumber++;
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.Focus();
            }
        }

        private string ToRoman(int number)
        {
            if (number < 1) return "";

            string[] romanNumerals = {
                "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X",
                "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX",
                "XXI", "XXII", "XXIII", "XXIV", "XXV", "XXVI", "XXVII", "XXVIII", "XXIX", "XXX"
            };

            if (number <= romanNumerals.Length)
                return romanNumerals[number - 1];
            else
                return number.ToString(); // Eğer çok büyükse düz sayı döndür
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (isAutoNumberingActive && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                richTextBox.SelectedText = "\n" + lineNumber + ". ";
                lineNumber++;
            }
            else if (isRomanNumberingActive && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                richTextBox.SelectedText = "\n" + ToRoman(romanLineNumber) + ". ";
                romanLineNumber++;
            }

            //Kısayol ile kes
            if (e.Control && e.KeyCode == Keys.X)
            {
                richTextBox.Cut();
            }

            //Kısayol ile kopyala
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (richTextBox.SelectionLength > 0)
                {
                    richTextBox.Copy();
                    e.SuppressKeyPress = true;
                }
            }

            //Kısayol ile yapıştır
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    richTextBox.Paste();
                    e.SuppressKeyPress = true;
                }
            }

            //Kısayol ile hepsini seç
            if (e.Control && e.KeyCode == Keys.A)
            {
                richTextBox.SelectAll();
                e.SuppressKeyPress = true;
            }

            //Yazdır
            if(e.Control && e.KeyCode == Keys.P)
            {
                printDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

            // Ara
            if (e.Control && e.KeyCode == Keys.F)
            {
                FindAndReplace findForm = new FindAndReplace();
                findForm.RichTextBox = richTextBox;
                findForm.ShowDialog();
                e.SuppressKeyPress = true;
            }

            // Değiştir
            if (e.Control && e.KeyCode == Keys.H)
            {
                FindAndReplace findForm = new FindAndReplace();
                findForm.RichTextBox = richTextBox;
                findForm.ShowDialog();
                e.SuppressKeyPress = true;
            }

            // Kısayol ile kaydet
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Dosya türlerini belirtin
                saveFileDialog.Title = "Dosya Kaydet";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        if (Path.GetExtension(filePath).ToLower() == ".rtf")
                        {
                            richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            richTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                        }
                        MessageBox.Show("Dosya başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                e.SuppressKeyPress = true;
            }

            // Kısayol ile aç
            if (e.Control && e.KeyCode == Keys.O)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Dosya Aç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;

                        if (Path.GetExtension(filePath).ToLower() == ".rtf")
                        {
                            // RTF dosyası olarak yükle
                            richTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            // Düz metin dosyası olarak yükle
                            richTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                        }

                        MessageBox.Show("Dosya başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                e.SuppressKeyPress = true;
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.Paste();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string textToPrint = richTextBox.Text;
            Font printFont = richTextBox.Font;
            Brush brush = Brushes.Black;
            e.Graphics.DrawString(textToPrint, printFont, brush, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void findAndReplace_Click(object sender, EventArgs e)
        {
            FindAndReplace findReplaceForm = new FindAndReplace();
            findReplaceForm.RichTextBox = richTextBox;
            findReplaceForm.ShowDialog();
        }

        private void image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                ofd.Title = "Resim Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(ofd.FileName);
                    Clipboard.SetImage(img);

                    if (richTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    {
                        richTextBox.Paste();
                    }
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; // Dosya türlerini belirtin
            saveFileDialog.Title = "Dosya Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    if (Path.GetExtension(filePath).ToLower() == ".rtf")
                    {
                        richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    }

                    MessageBox.Show("Dosya başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Dosya Aç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    if (Path.GetExtension(filePath).ToLower() == ".rtf")
                    {
                        richTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    }

                    MessageBox.Show("Dosya başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                DialogResult result = MessageBox.Show(
                    "Değişiklikleri kaydetmek istiyor musunuz?",
                    "Yeni Belge",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    Save();
                }
            }

            richTextBox.Clear();
        }

        private void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Dosya Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog.FileName;
                    if (Path.GetExtension(path).ToLower() == ".rtf")
                    {
                        richTextBox.SaveFile(path, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        richTextBox.SaveFile(path, RichTextBoxStreamType.PlainText);
                    }

                    MessageBox.Show("Dosya kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
