using System;
using System.Windows;
using System.Windows.Controls;

namespace SelectorBox
{
    public class IconTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InfoTemplate { get; set; }

        public DataTemplate WarningTemplate { get; set; }

        public DataTemplate ErrorTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var @event = item as Event;
            if (@event != null)
            {
                switch (@event.Severity)
                {
                    case Severity.Info:
                        return InfoTemplate;
                    case Severity.Warning:
                        return WarningTemplate;
                    case Severity.Error:
                        return ErrorTemplate;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return base.SelectTemplate(item, container);
        }
    }
}
