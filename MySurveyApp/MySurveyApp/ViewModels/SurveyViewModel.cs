using System;

namespace MySurveyApp.ViewModels
{
    public class SurveyViewModel : MySurveyApp.ViewModels.ViewModelBase
    {
        private string _FirstName = default(string);
        public string FirstName
        {
            get => _FirstName;
            set
            {
                _FirstName = value;
                NotifyPropertyChanged();
            }
        }

        private string _LastName = default(string);
        public string LastName
        {
            get => _LastName;
            set
            {
                _LastName = value;
                NotifyPropertyChanged();
            }
        }

        private string _Company = default(string);
        public string Company
        {
            get => _Company;
            set
            {
                _Company = value;
                NotifyPropertyChanged();
            }
        }

        private bool _UsesAndroid = default(bool);
        public bool UsesAndroid
        {
            get => _UsesAndroid;
            set
            {
                _UsesAndroid = value;
                NotifyPropertyChanged();
            }
        }

        private string _AndroidResponse = default(string);
        public string AndroidResponse
        {
            get => _AndroidResponse;
            set
            {
                _AndroidResponse = value;
                NotifyPropertyChanged();
            }
        }

        private bool _UsesiOS = default(bool);
        public bool UsesiOS
        {
            get => _UsesiOS;
            set
            {
                _UsesiOS = value;
                NotifyPropertyChanged();
            }
        }

        private string _iOSResponse = default(string);
        public string iOSResponse
        {
            get => _iOSResponse;
            set
            {
                _iOSResponse = value;
                NotifyPropertyChanged();
            }
        }

        private bool _UsesForms = default(bool);
        public bool UsesForms
        {
            get => _UsesForms;
            set
            {
                _UsesForms = value;
                NotifyPropertyChanged();
            }
        }

        private string _FormsResponse = default(string);
        public string FormsResponse
        {
            get => _FormsResponse;
            set
            {
                _FormsResponse = value;
                NotifyPropertyChanged();
            }
        }
    }
}