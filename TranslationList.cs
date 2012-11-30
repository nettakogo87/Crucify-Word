using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
        public bool AddTranslation(Translation trans)
        {
            Translation result = this.FindTranslationByWord(trans.Word);
            if (null == result)
            {
                this.translations.Add(trans);
                return true;
            }
            return false;
        }
        public bool RemoveTranslation(Translation trans)
        {
            Translation result = this.FindTranslationByWord(trans.Word);
            if (null != result)
            {
                this.translations.Remove(result);
                return true;
            }
            return false;
        }

        public void save()
        {
            foreach(Translation tr in this.translations)
            {
                tr.save();
            }
        }

        public void load()
        {
            DirectoryInfo translatDir = new DirectoryInfo(@"voc\translations");
            for (int i = 0; i < translatDir.GetFiles().Length; i++)
            {
                Translation translation = new Translation();
                translation.load(translatDir.GetFiles()[i].Name);
                this.translations.Add(translation);
            }
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
