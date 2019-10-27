using System;
using System.Collections.Generic;
using System.Globalization;
using pg.texts.exception;
using pg.texts.utility;

namespace pg.texts
{
    /// <summary>
    /// A static text provider service that can be used to get any string contained within the currently loaded translation data.
    /// </summary>
    public sealed class Texts
    {
        private static List<CultureInfo> _availableLocales;
        private static CultureInfo _currentLocale;
        private static bool _isInitialised = false;

        /// <summary>
        /// Initialises the text provider service.
        /// </summary>
        /// <param name="textInitializer"></param>
        /// <returns></returns>
        public static void Init(TextInitializer textInitializer)
        {
            throw new NotImplementedException();
        }

        public static CultureInfo GetCurrentLocale()
        {
            if (!_isInitialised)
            {
                throw new TextProviderNotInitialisedException();
            }

            return _currentLocale;
        }

        public static void SetCurrentLocale(CultureInfo locale)
        {
            if (!_isInitialised)
            {
                throw new TextProviderNotInitialisedException();
            }
            _currentLocale = locale ?? throw new ArgumentNullException(nameof(locale));
        }

        public static bool IsLocaleAvailable(CultureInfo locale)
        {
            if (!_isInitialised)
            {
                throw new TextProviderNotInitialisedException();
            }

            if (locale == null)
            {
                throw new ArgumentNullException(nameof(locale));
            }

            return _availableLocales.Contains(locale);
        }

        public static IEnumerable<CultureInfo> GetAvailableLocales()
        {
            if (!_isInitialised)
            {
                throw new TextProviderNotInitialisedException();
            }

            return _availableLocales.ConvertAll(locale => (CultureInfo) locale.Clone());
        }

        public string Get(string key)
        {
            if (!_isInitialised)
            {
                throw new TextProviderNotInitialisedException();
            }

            throw new NotImplementedException();
        }
    }
}
