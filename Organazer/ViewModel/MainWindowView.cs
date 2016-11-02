using System.Collections.ObjectModel;
using Organazer.Model;
using OrganazerLibrary;

namespace Organazer.ViewModel
{
    public class MainWindowView
    {
        public ObservableCollection<ListItem> Monday { get; set; }


        public MainWindowView()
        {
            Monday = new ObservableCollection<ListItem>();
            var contract = new DbContract();
            var task = contract.GetTaskasForDay(DayOfWeek.Monday);
            foreach (var taska in task)
            {
                Monday.Add(new ListItem() {Task=taska.ToString()});
            }
           
        }
    }
}