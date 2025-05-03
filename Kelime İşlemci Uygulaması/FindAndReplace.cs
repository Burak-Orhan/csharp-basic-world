using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Kelime_İşlemci_Uygulaması
{
    public partial class FindAndReplace: Form
    {
        public RichTextBox RichTextBox { get; set; }

        public FindAndReplace()
        {
            InitializeComponent();
        }

        private void FindAndReplace_Load(object sender, EventArgs e)
        {

        }

        private List<int> foundIndexes = new List<int>();
        private string lastSearchedText = "";
        private int currentMatchIndex = 0;

        private void find_Click(object sender, EventArgs e)
        {
            string searchText = findTxt.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Lütfen aranacak metni girin.");
                return;
            }

            // Yeni metin arandıysa önceki verileri sıfırla
            if (searchText != lastSearchedText)
            {
                ClearHighlights();
                foundIndexes.Clear();
                currentMatchIndex = 0;
                lastSearchedText = searchText;

                int startIndex = 0;
                while ((startIndex = RichTextBox.Text.IndexOf(searchText, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    foundIndexes.Add(startIndex);
                    startIndex += searchText.Length;
                }

                if (foundIndexes.Count == 0)
                {
                    MessageBox.Show("Aranan metin bulunamadı.");
                    return;
                }
            }

            HighlightMatches(searchText);
            SelectCurrentMatch(searchText);
        }

        private void HighlightMatches(string searchText)
        {
            foreach (int index in foundIndexes)
            {
                RichTextBox.Select(index, searchText.Length);
                RichTextBox.SelectionBackColor = Color.LightYellow; // soluk sarı
            }
        }

        private void SelectCurrentMatch(string searchText)
        {
            if (foundIndexes.Count == 0) return;

            // Öncekini hafif yap
            RichTextBox.Select(foundIndexes[currentMatchIndex], searchText.Length);
            RichTextBox.SelectionBackColor = Color.LightYellow;

            // Sonrakini parlak yap
            currentMatchIndex = (currentMatchIndex + 1) % foundIndexes.Count;

            RichTextBox.Select(foundIndexes[currentMatchIndex], searchText.Length);
            RichTextBox.SelectionBackColor = Color.Yellow;
            RichTextBox.Focus();
        }

        private void ClearHighlights()
        {
            foreach (int index in foundIndexes)
            {
                RichTextBox.Select(index, lastSearchedText.Length);
                RichTextBox.SelectionBackColor = RichTextBox.BackColor;
            }
            RichTextBox.Select(0, 0); // Seçimi kaldır
        }

        private void FindAndReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearHighlights();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            string searchText = findTxt.Text;
            string replaceText = replaceTxt.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Lütfen bulunacak metni girin.");
                return;
            }

            if (foundIndexes.Count == 0)
            {
                MessageBox.Show("Lütfen önce 'Bul' işlemi yapın.");
                return;
            }

            // Şu anki eşleşmeyi değiştir
            int currentIndex = foundIndexes[currentMatchIndex];
            RichTextBox.Select(currentIndex, searchText.Length);
            RichTextBox.SelectedText = replaceText;

            // Değiştirilen kısmın uzunluğu değişebilir, bu yüzden aramayı tekrar yap
            foundIndexes.Clear();
            lastSearchedText = ""; // Yeni arama için resetle
            find_Click(null, null); // tekrar bul
        }


        private void replaceAll_Click(object sender, EventArgs e)
        {
            string searchText = findTxt.Text;
            string replaceText = replaceTxt.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Lütfen bulunacak metni girin.");
                return;
            }

            if (!Regex.IsMatch(RichTextBox.Text, Regex.Escape(searchText), RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Aranan metin bulunamadı.");
                return;
            }

            RichTextBox.Text = Regex.Replace(RichTextBox.Text, Regex.Escape(searchText), replaceText, RegexOptions.IgnoreCase);
            MessageBox.Show("Tüm eşleşen metinler değiştirildi.");
        }
    }
}
