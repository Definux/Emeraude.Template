﻿using Definux.Emeraude.Application.Localization;
using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Seo.Models;

namespace Emeraude.Template.Seo.SitemapPatterns
{
    public interface IHomePageSitemapPattern : IPageSitemapPattern
    {
    }

    public class HomePageSitemapPattern : EmPageSitemapPattern, IHomePageSitemapPattern
    {
        public HomePageSitemapPattern(ILanguageStore languageStore)
            : base("/", languageStore)
        {
            SinglePage = true;
            Priority = 1f;
            ChangeFrequency = SeoChangeFrequencyTypes.Always;
        }
    }
}
