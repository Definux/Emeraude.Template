using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Seo.Attributes;
using Definux.Seo.Models;
using Emeraude.Template.Application.Requests.InitialStates.Home;

namespace Emeraude.Template.Pages
{
    [EmRoute]
    [EmLanguageRoute]
    [MetaTag(MainMetaTags.Title, "Home")]
    [MetaTag(MainMetaTags.Description, "Description")]
    [Canonical("/")]
    public class HomePage : EmPage<HomeViewModel, HomeInitialStateQuery>
    {
    }
}