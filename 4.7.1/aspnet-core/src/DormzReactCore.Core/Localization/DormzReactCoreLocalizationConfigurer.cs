using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DormzReactCore.Localization
{
    public static class DormzReactCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DormzReactCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DormzReactCoreLocalizationConfigurer).GetAssembly(),
                        "DormzReactCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
