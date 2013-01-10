using System;
using System.Collections.Generic;
using Crucify_Word.DomainLayer;

namespace Crucify_Word.BusinessLayer
{
    public interface ICardsController
    {
        void CreateCard(int id, string foreignWord, string transcription, string translation);
        void LoadAllCards();
        void SaveCardById(int id);
        void RemoveCardById(int id);
        List<Card> GetAllCards();
    }
}
