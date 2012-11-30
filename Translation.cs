using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/**
 * Класс представляетс собой Русское слово - перевод Английского. 
 * В последующем предполагается что будет хранить идентификатор популярности данного перевода.
 */
namespace Crucify_Word
{
    public class Translation
    {
        public Translation()
        {
            this.word = "";
        }
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
        public void save()
        {
            FileInfo newWordDoc = new FileInfo(@"voc\translations\" + this.word + ".txt");
            StreamWriter sw = newWordDoc.CreateText();
            sw.WriteLine(this.word);
            sw.Close();
        }
        public void load(string word)
        {
            FileInfo newWordDoc = new FileInfo(word);
            StreamReader sw = newWordDoc.OpenText();
            this.word = sw.ReadLine();
            sw.Close();
        }
    }
}
