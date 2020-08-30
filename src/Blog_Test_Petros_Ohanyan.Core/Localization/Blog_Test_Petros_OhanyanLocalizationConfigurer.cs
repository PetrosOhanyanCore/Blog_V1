using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Blog_Test_Petros_Ohanyan.Localization
{
    public static class Blog_Test_Petros_OhanyanLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Blog_Test_Petros_OhanyanConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Blog_Test_Petros_OhanyanLocalizationConfigurer).GetAssembly(),
                        "Blog_Test_Petros_Ohanyan.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
