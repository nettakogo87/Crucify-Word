using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс Иностранное слово. Содержит уникальный ID и уникальное слово. 
 * В данный момент содержит только один перевод. Но в будуйщем переводы можно будет добавлять.
 */
namespace Crucify_Word
{
    public class ForeignWord
    {
        public ForeignWord(string word, string translation):this(word, translation, String.Empty) {}
        public ForeignWord(string word, string translation, string transcription)
        {
            this.id = 0; // придумать очень сложный способ вычисления нового id
            this.word = word;
            this.transcription = transcription;
            Translation translationOfCard = new Translation(translation);
            this.translations = new TranslationList(translationOfCard);
        }

        private Int64 id;
        private string word;
        private string transcription;
        private TranslationList translations;

        public Int64 Id
        {
            get { return id; }
        }
        public string Word
        {
            get { return word; }
        }
        public string Transcription
        {
            get { return transcription; }
        }
        public TranslationList Translations
        {
            get { return translations; }
        }
    }
}
