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
        public const int NUMBER_OF_REPEATED_PACK = 0;
        public const int NUMBER_OF_REMOVAL_PACK = 11;
        public const int COUNT_OF_LESSONS = 10;
        public Vocabulary(string vocabularyName)
        {
            this.id = 0; // ну как всегда придумать инкрементатор
            this.vocabularyName = vocabularyName;
            this.cards = new List<Card>();
        }
        private List<Card> cards;
        private int id;
        private string vocabularyName;

        public List<Card> GetCards()
        {
            return this.cards.GetRange(0, this.cards.Count);
        }
        public int Id
        {
            get { return this.id; }
        }
        public string VocabularyName
        {
            set { this.vocabularyName = value;}
            get { return this.vocabularyName; }
        }
        public void AddCardToVocabulary(Card newCard)
        {
            if (!this.ExistCard(newCard))
            {
                cards.Add(newCard);
            }
        }
        public void DelCardFromVocabulary(Card badCard)
        {
            if (this.ExistCard(badCard))
            {
                cards.Remove(badCard);
            }
        }
        public int GetCardsCount()
        {
            return cards.Count;
        }


        // приватные методы 
        private bool ExistCard(Card newCard)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.CardWord.Word == newCard.CardWord.Word && card.SelectTranslation == newCard.SelectTranslation;
                }
            );
        }
        private bool ExistCard(string word, string translation)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.CardWord.Word == word && card.SelectTranslation == translation;
                }
            );
        }
        private bool ExistCard(string word, Translation translation)
        {
            return this.cards.Exists(
                delegate(Card card)
                {
                    return card.CardWord.Word == word && card.SelectTranslation == translation.Word;
                }
            );
        }
    }
}
