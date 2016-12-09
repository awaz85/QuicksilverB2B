﻿using EPiServer.Core;
using EPiServer.Reference.Commerce.Site.Features.Search.Models;
using EPiServer.Reference.Commerce.Site.Features.Search.ViewModels;

namespace EPiServer.Reference.Commerce.Site.Features.Search.Services
{
    public interface IFindProductSearchService
    {
        CustomSearchResult SearchProducts(IContent currentContent, FilterOptionViewModel filterOptions);
    }
}
