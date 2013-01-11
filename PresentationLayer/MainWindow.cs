using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Crucify_Word.BusinessLayer;
using Crucify_Word.DomainLayer;
using Crucify_Word.PresentationLayer;

namespace Crucify_Word
{
    public partial class MainWindow : Form, IView
    {
        private ICardsController _controller;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetController(CardsController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            this.dataGridViewCards.Rows.Clear();
        }

        public void AddCardToGrid(Card card)
        {
            this.dataGridViewCards.Rows.Add(card.Id, card.ForeignWord, card.Transcription, card.Translation);
        }

        private void buttonAddCard_Click(object sender, System.EventArgs e)
        {
            string foreignWord   = this.textBoxForeignWord.Text.Trim();
            string transcription = this.textBoxTranscription.Text.Trim();
            string translation   = this.textBoxTranslation.Text.Trim();
            _controller.CreateCard(foreignWord, transcription, translation);
            this.textBoxForeignWord.Clear();
            this.textBoxTranscription.Clear();
            this.textBoxTranslation.Clear();
            SelectingRow();
        }

        private void buttonRemoveCard_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.dataGridViewCards.Rows.Count; i++)
            {
                if (this.dataGridViewCards.Rows[i].Selected)
                {
                    _controller.RemoveCardById(Convert.ToInt32(this.dataGridViewCards[0, i].Value.ToString()));
                    this.dataGridViewCards.Rows.RemoveAt(i);
                }
            }
            SelectingRow();
        }

        private void dataGridViewCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectingRow();
        }
        public void SelectingRow()
        {
            int i = dataGridViewCards.SelectedCells[0].RowIndex;
            dataGridViewCards.Rows[i].Selected = true;
        }
        public void SelectingRow(int i)
        {
            dataGridViewCards.Rows[i].Selected = true;
        }
    }
}
