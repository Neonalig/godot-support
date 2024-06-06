using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.Application.UI.Options;
using JetBrains.Application.UI.Options.OptionsDialog;
using JetBrains.IDE.UI;
using JetBrains.Lifetimes;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings;
using JetBrains.ReSharper.LiveTemplates.UI;
using JetBrains.ReSharper.Plugins.Godot.CSharp.LiveTemplates;
using JetBrains.ReSharper.Plugins.Godot.CSharp.LiveTemplates.Scope;
using JetBrains.Rider.Model;
using JetBrains.UI.ThemedIcons;

namespace JetBrains.ReSharper.Plugins.Godot.Rider.Integration.CSharp.Feature.Services.LiveTemplates
{
    [ZoneMarker(typeof(IRiderModelZone))]
    [OptionsPage("RiderGodotLiveTemplatesSettings", "Godot", typeof(GodotLogoIconsThemedIcons.Godot))]
    public class GodotLiveTemplatesOptionsPage : RiderLiveTemplatesOptionPageBase
    {
        public GodotLiveTemplatesOptionsPage(Lifetime lifetime,
                                             GodotProjectScopeCategoryUIProvider uiProvider,
                                             OptionsPageContext optionsPageContext,
                                             OptionsSettingsSmartContext optionsSettingsSmartContext,
                                             StoredTemplatesProvider storedTemplatesProvider,
                                             ScopeCategoryManager scopeCategoryManager,
                                             IDialogHost dialogHost,
                                             TemplatesUIFactory uiFactory, IconHostBase iconHostBase)
            : base(lifetime, uiProvider, optionsPageContext, optionsSettingsSmartContext, storedTemplatesProvider, scopeCategoryManager,
                uiFactory, iconHostBase, dialogHost, "CSHARP")
        {
        }
    }
}