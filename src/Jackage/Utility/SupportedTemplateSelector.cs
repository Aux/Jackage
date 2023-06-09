﻿using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Metadata;
using Jackage.Jackbox;
using System.Collections.Generic;

namespace Jackage.Views;

public class SupportedTemplateSelector : IDataTemplate
{
    public bool SupportsRecycling => false;

    [Content]
    public Dictionary<string, IDataTemplate> Templates { get; } = new Dictionary<string, IDataTemplate>();

    public IControl Build(object data)
    {
        return Templates[((ISupported)data).IsSupported ? "Enabled": "Disabled"].Build(data);
    }

    public bool Match(object data)
    {
        if (data is not ISupported supported)
            return false;

        return true;
    }
}
