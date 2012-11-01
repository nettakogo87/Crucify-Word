using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * TranslationList создан для того что бы инкапсулировать то как хранятся переводы. 
 * Может быть придется отказаться от List...
 */
namespace Crucify_Word
{
    public class TranslationList
    {
        private List<Translation> translations;
        public TranslationList()
        {
            this.translations = new List<Translation>();
        }
        public TranslationList(Translation trans) 
        {
            this.translations = new List<Translation>();
            this.translations.Add(trans);
        }
        /**
         * Возвращает true если элемент добавлен, иначе вернет false.
         */
        public bool AddTranslationByWord(string word)
        {
            Translation result = this.FindTranslationByWord(word);
            if (null == result)
            {
                Translation trans = new Translation(word);
                this.translations.Add(trans);
                return true;
            }
            return false;
        }
        /**
         * Возвращает true если элемент удален, иначе вернет false.
         */
        public bool RemoveTranslationByWord(string word)
        {
            Translation result = this.FindTranslationByWord(word);
            if (null != result) {
                this.translations.Remove(result);
                return true;
            }
            return false;
        }
        /**
         * возвращает переменную типа Translation в случае успеха, в случае неудачи вернет null!!!
         */
        private Translation FindTranslationByWord(string word)
        {
            Translation result = this.translations.Find(
                delegate(Translation trans)
                {
                    return trans.Word == word;
                }
                );
            return result;
        }
    }
}
