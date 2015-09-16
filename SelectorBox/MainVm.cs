using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectorBox
{
    public class MainVm
    {
        private readonly ObservableCollection<Event> _events = new ObservableCollection<Event>();

        public MainVm()
        {
            _events.Add(new Event(Severity.Warning, "Warning"));
            _events.Add(new Event(Severity.Info, "Info"));
            _events.Add(new Event(Severity.Error, "Error"));
        }

        public ObservableCollection<Event> Events
        {
            get { return _events; }
        }
    }
}
