using System.Collections.Generic;
using System.Globalization;
using pg.dat.utility;

namespace pg.texts.utility
{
    public sealed class TextInitializer
    {
        private Dictionary<CultureInfo, string> _languageToFileMap;
        private Dictionary<CultureInfo, List<Translation>> _languageToTranslationMap;

        public Dictionary<CultureInfo, string> LanguageToFileMap =>
            _languageToFileMap ?? new Dictionary<CultureInfo, string>();

        public Dictionary<CultureInfo, List<Translation>> LanguageToTranslationMap =>
            _languageToTranslationMap ?? new Dictionary<CultureInfo, List<Translation>>();

        public CultureInfo Locale { get; set; }
    }
}
