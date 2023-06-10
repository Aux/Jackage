using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Metadata;
using Jackage.Jackbox;
using System.Collections.Generic;

namespace Jackage.Views;

public class PackTemplateSelector : IDataTemplate
{
    public bool SupportsRecycling => false;

    [Content]
    public Dictionary<string, IDataTemplate> Templates { get; } = new Dictionary<string, IDataTemplate>();

    public IControl Build(object data)
    {
        return Templates[((JackboxPack)data).IsSupported ? "Enabled": "Disabled"].Build(data);
    }

    public bool Match(object data)
    {
        if (data is not JackboxPack pack)
            return false;

        return true;
    }
}
