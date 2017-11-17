using System;
using Xamarin.Forms;

namespace MySurveyApp.Controls
{
    public partial class FormEntry : Xamarin.Forms.Grid
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(FormEntry), default(string), Xamarin.Forms.BindingMode.OneWay);
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(FormEntry), default(string), BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }

            set
            {
                SetValue(TextProperty, value);
            }
        }

        public FormEntry()
        {
            InitializeComponent();

            title.Text = Title;
            entry.Text = Text;
            entry.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                title.Text = Title;
            }
            else if (propertyName == TextProperty.PropertyName)
            {
                entry.Text = Text;
            }
        }
    }
}