﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.Core;
using Sdl.LanguagePlatform.TranslationMemory;
using Sdl.LanguagePlatform.TranslationMemoryApi;

namespace $safeprojectname$
{
    class MyTranslationProvider : ITranslationProvider
    {
        #region ITranslationProvider Members

        public ITranslationProviderLanguageDirection GetLanguageDirection(LanguagePair languageDirection)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public void LoadState(string translationProviderState)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public void RefreshStatusInfo()
        {
            throw new NotImplementedException();
        }

        public string SerializeState()
        {
            throw new NotImplementedException();
        }

        public ProviderStatusInfo StatusInfo
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsConcordanceSearch
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsDocumentSearches
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsFilters
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsFuzzySearch
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsLanguageDirection(LanguagePair languageDirection)
        {
            throw new NotImplementedException();
        }

        public bool SupportsMultipleResults
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsPenalties
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsPlaceables
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsScoring
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsSearchForTranslationUnits
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsSourceConcordanceSearch
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsStructureContext
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsTaggedInput
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsTargetConcordanceSearch
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsTranslation
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsUpdate
        {
            get { throw new NotImplementedException(); }
        }

        public bool SupportsWordCounts
        {
            get { throw new NotImplementedException(); }
        }

        public TranslationMethod TranslationMethod
        {
            get { throw new NotImplementedException(); }
        }

        public Uri Uri
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}

