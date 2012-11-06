using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс словаря, в нем хранятся карточки слов, которые изучает пользователь.
 * Пока можно добавить карточку или удалить, а еще получить список карточек.
 * Но я думаю что в будуйщем через словарь можно будет добавлять новые слова не посредственно в "Хранилище слов"
 */
namespace Crucify_Word
{
    public class Vocabulary
    {
        public Vocabulary(string vocabularyName)
        {
            this.id = 0; // ну как всегда придумать инкрементатор
            this.vocabularyName = vocabularyName;
            this.cardList = new List<Card>();
        }

        private Int64 id;
        private string vocabularyName;
        private List<Card> cardList;

        public Int64 Id
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
            this.cardList.Add(newCard);
        }
        public void DelCardFromVocabulary(Card badCard)
        {
            this.cardList.Remove(badCard);
        }
        public Card[] GetCardList()
        {
            int cardCount = this.cardList.Count;
            Card[] cardMass = new Card[cardCount];
            for (int i = 0; i < cardCount; i++)
            {
                cardMass[i] = this.cardList[i];
            }
            return cardMass;
        }
    }
}
