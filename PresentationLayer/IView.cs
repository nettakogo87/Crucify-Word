using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crucify_Word.BusinessLayer;
using Crucify_Word.DomainLayer;

namespace Crucify_Word.PresentationLayer
{
    public interface IView
    {
        void SetController(CardsController controller);
        void ClearGrid();
        void AddCardToGrid(Card card);
    }
}
