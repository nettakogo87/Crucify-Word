using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс Карточки Английского слова. Содержит уникальный ID и уникальное слово. 
 * В данный момент содержит только один перевод. Но в будуйщем переводы можно будет добавлять.
 */
namespace Crucify_Word
{
    public class Card
    {
        public Card(string word, string translation):this(word, translation, String.Empty) {}
        public Card(string word, string translation, string transcription)
        {
            this.id = 0; // придумать очень сложный способ вычисления нового id
            this.word = word;
            this.transcription = transcription;
            this.translations = new List<Translation>();
            Translation translationOfCard = new Translation(translation);
            this.translations.Add(translationOfCard);
        }

        private Int64 id;
        private string word;
        private string transcription;
        private List<Translation> translations;

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
        public List<Translation> Translations
        {
            get { return translations; }
        }
    }
}
