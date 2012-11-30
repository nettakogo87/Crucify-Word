using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Хранит все карточки пользователя
 * Пока можно добавить карточку или удалить, а еще получить список карточек.
 * Но я думаю что в будуйщем через словарь можно будет добавлять новые слова не посредственно в "Хранилище слов"
 */
namespace Crucify_Word
{
    public class Vocabulary
    {
        public Vocabulary(string vocabularyName)
        {
            this.vocabularyName = vocabularyName;
            this.cards = new List<Card>();
        }
        private List<Card> cards;
        private string vocabularyName;

        public string VocabularyName
        {
            set { this.vocabularyName = value; }
            get { return this.vocabularyName; }
        }
        public List<Card> GetAllCards()
        {
            return this.cards.GetRange(0, this.cards.Count);
        }
        public void AddCardToVocabulary(Card newCard)
        {
            if (!this.ExistCard(newCard))
            {
                cards.Add(newCard);
            }
        }
        public void RemoveCardFromVocabulary(Card badCard)
        {
            if (this.ExistCard(badCard))
            {
                cards.Remove(badCard);
            }
        }
        public int GetCardsCount()
        {
            return this.cards.Count;
        }

        // приватные методы 
        private bool ExistCard(Card newCard)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.ForeignWord == newCard.ForeignWord && card.Translation == newCard.Translation;
                }
            );
        }
        private bool ExistCard(string word, string translation)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.ForeignWord == word && card.Translation == translation;
                }
            );
        }
    }
}
