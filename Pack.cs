using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Колода в которой хранятся карточки. 
 * Экземпляры этого класса будут представлять собой начальную колоду и колоду изьятия
 */
namespace Crucify_Word
{
    public class Pack 
    {
        public Pack(int packNumber)
        {
            this.packNumber = packNumber;
            this.cardList = new CardList();
        }
        protected int packNumber;
        protected CardList cardList;
        public int PackNumber
        {
            get { return this.packNumber; }
        }
        public void AddCard(Card newCard)
        {
            this.cardList.AddCard(newCard);
        }
        public void RemoveCard(Card oldCard)
        {
            this.cardList.RemoveCard(oldCard);
        }
    }
}
