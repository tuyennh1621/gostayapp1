﻿using gostayapp1.Models;

namespace gostayapp1.Templates;

public class MapItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate SanFranTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return ((Position)item).Address.Contains("San Francisco") ? SanFranTemplate : DefaultTemplate;
    }
}

