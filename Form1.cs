using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crucify_Word
{
    public partial class Form1 : Form
    {
        private Vocabulary myVocabulary;

        public Form1()
        {
            this.myVocabulary = new Vocabulary("MyVocabulary");
            InitializeComponent();
        }

        private void wordTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vocabularyPanel.Visible = false;
            this.addWordPanel.Visible = true;
        }

        private void wordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.wordDataGridView.Rows.Clear();
            if (0 < this.myVocabulary.GetCardsCount())
            {
                List<Card> cards = this.myVocabulary.GetAllCards();
                for (int i = 0; i < cards.Count; i++)
                {
                    Card card = cards[i];
                    this.wordDataGridView.Rows.Add(card.ForeignWord, card.Transcription, card.Translation, card.Progress);
                }
            }
            this.addWordPanel.Visible = false;
            this.vocabularyPanel.Visible = true;
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            // а так же проверить нет ли уже карточки с этим словом в словаре.
            string newWord = addWordTextBox.Text.ToLower().Trim();
            string transcription = addTranscriptionTextBox.Text.ToLower().Trim();
            string translation = addTranslationTextBox.Text.ToLower().Trim();
            Card newCard = new Card(newWord, transcription, translation);
            this.myVocabulary.AddCardToVocabulary(newCard);
            this.addWordTextBox.Clear();
            this.addTranscriptionTextBox.Clear();
            this.addTranslationTextBox.Clear();
        }
        // проверяет заполнены ли поля "слово" и "перевод", если да - кнока "добавить" становится видима
        private void addWordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (("" != this.addWordTextBox.Text.Trim()) && ("" != this.addTranslationTextBox.Text.Trim()))
            {
                this.addWordButton.Enabled = true;
            }
            else
            {
                this.addWordButton.Enabled = false;
            }
        }
        // проверяет заполнены ли поля "слово" и "перевод", если да - кнопка "добавить" становится видима
        private void addTranslationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (("" != this.addWordTextBox.Text.Trim()) && ("" != this.addTranslationTextBox.Text.Trim()))
            {
                this.addWordButton.Enabled = true;
            }
            else
            {
                this.addWordButton.Enabled = false;
            }
        }
    }
}
