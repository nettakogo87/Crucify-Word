using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс обертка для списка карточек, 
 * нужен для более удобного удаления и добавления карточек, а так же их поиска если потребуется
 */
namespace Crucify_Word
{
    public class CardList
    {
        private List<Card> cards;
        public CardList()
        {
            this.cards = new List<Card>();
        }
        public void AddCard(Card newCard)
        {
            if (!this.ExistCard(newCard))
            {
                cards.Add(newCard);
            }
        }
        public void RemoveCard(Card oldCard)
        {
            if (this.ExistCard(oldCard))
            {
                cards.Add(oldCard);
            }
        }
        public List<Card> GetCards()
        {
            return this.cards.GetRange(0, this.cards.Count);
        }
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
