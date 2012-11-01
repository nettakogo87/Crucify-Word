using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс представляетс собой Русское слово - перевод Английского. 
 * В последующем предполагается что будет хранить идентификатор популярности данного перевода.
 */
namespace Crucify_Word
{
    public class Translation
    {
        public Translation(string word)
        {
            this.word = word; 
        }
        private string word;
        public string Word
        {
            get { return word; }
            set { word = value; }
        }
    }
}
