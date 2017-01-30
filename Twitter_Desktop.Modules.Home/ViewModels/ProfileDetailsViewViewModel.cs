using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter_Desktop.Modules.Home.Models;

namespace Twitter_Desktop.Modules.Home.ViewModels
{
    public class ProfileDetailsViewViewModel : INotifyPropertyChanged
    {
        public ProfileDetailsViewViewModel()
        {
            BuildTaskDetailsCollection();
        }
        private ObservableCollection<TaskDetails> _dataCollection;
        public ObservableCollection<TaskDetails> DataCollection
        { 
            get
            {
                return _dataCollection;
            }
            set
            {
                _dataCollection = value;
                OnPropertyChanged("DataCollection");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void BuildTaskDetailsCollection()
        {
            var list = new List<TaskDetails>
            {
                new TaskDetails
                {
                    TaskName="Task 1",
                    TaskPlace = "Home",
                    TaskType = "Bug",
                    Duration = 10
                },
                new TaskDetails
                {
                    TaskName="Task 2",
                    TaskPlace = "Office",
                    TaskType = "User Story",
                    Duration = 101
                },
                new TaskDetails
                {
                    TaskName="Task 3",
                    TaskPlace = "Home",
                    TaskType = "Bug",
                    Duration = 24
                },
                new TaskDetails
                {
                    TaskName="Task 4",
                    TaskPlace = "Home",
                    TaskType = "Bug",
                    Duration = 1
                },
                new TaskDetails
                {
                    TaskName="Task 5",
                    TaskPlace = "Office",
                    TaskType = "Bug",
                    Duration = 11
                },
                new TaskDetails
                {
                    TaskName="Task 6",
                    TaskPlace = "Office",
                    TaskType = "Bug",
                    Duration = 898
                },
            };

            if (_dataCollection == null)
            {
                _dataCollection = new ObservableCollection<TaskDetails>();
                _dataCollection.AddRange(list);
            }
            else
            {
                _dataCollection.AddRange(list);
            }
        }
    }
}
