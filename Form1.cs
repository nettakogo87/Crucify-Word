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
            this.addPartOfSpeechComboBox.SelectedIndex = ForeignWord.NOT_KNOW - 1;
        }

        private void wordTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vocabularyPanel.Visible = false;
            this.addWordPanel.Visible = true;
            this.addPartOfSpeechComboBox.SelectedIndex = ForeignWord.NOT_KNOW - 1;
        }

        private void wordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.wordDataGridView.Rows.Clear();
            if (0 < this.myVocabulary.GetCardsCount())
            {
                List<Card> cards = this.myVocabulary.GetCards();
                for (int i = 0; i < this.myVocabulary.GetCardsCount(); i++)
                {
                    Card card = cards[i];
                    this.wordDataGridView.Rows.Add(card.CardWord.Word, card.CardWord.Transcription, card.SelectTranslation, card.Progress);
                }
            }
            this.addWordPanel.Visible = false;
            this.vocabularyPanel.Visible = true;
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            // а так же проверить нет ли уже карточки с этим словом в словаре.
            ForeignWord newForeignWord;
            string newWord = addWordTextBox.Text.ToLower();
            string transcription = addTranscriptionTextBox.Text.ToLower().Trim();
            string translation = addTranslationTextBox.Text.ToLower();
            if ("" == transcription)
            {
                newForeignWord = new ForeignWord(newWord, translation, this.addPartOfSpeechComboBox.SelectedIndex + 1);
            }
            else 
            {
                newForeignWord = new ForeignWord(newWord, translation, transcription, this.addPartOfSpeechComboBox.SelectedIndex + 1);
            }
            Card newCard = new Card(newForeignWord, translation);
            this.myVocabulary.AddCardToVocabulary(newCard);
            this.addWordTextBox.Clear();
            this.addTranscriptionTextBox.Clear();
            this.addTranslationTextBox.Clear();
            this.addPartOfSpeechComboBox.SelectedIndex = ForeignWord.NOT_KNOW - 1;
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
