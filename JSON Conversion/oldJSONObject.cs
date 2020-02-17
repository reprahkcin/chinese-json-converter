using System.Collections.Generic;

namespace JSON_Conversion
{
    public class oldJSONObject
    {

        public string id { get; set; }
        public string chinese { get; set; }
        public string[] chinesePhrase { get; set; }
        public string romanizedPhrase { get; set; }
        public string romanizedImportantCharacter { get; set; }
        public int strokes { get; set; }
        public string wordAudio { get; set; }
        public string phraseAudio { get; set; }
        public int[] importantCharacter { get; set; }
        public string[] mainGraphics { get; set; }
        public string[] strokeAudio { get; set; }
        public string[] strokePng { get; set; }
        public string characterAnimated { get; set; }
        public string[] timecodes { get; set; }
        public string englishTranslation { get; set; }


    }
}