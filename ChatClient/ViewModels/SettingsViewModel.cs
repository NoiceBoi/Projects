namespace ChatClient.ViewModels
{
    public class SettingsViewModel : PropertyChangedClass
    {
        public SettingsViewModel()
        {
            Test = Properties.Settings.Default.Settings_Test;
            Test1 = Properties.Settings.Default.Settings_Test1;
            SliderVal = Properties.Settings.Default.Settings_SliderVal;
            TextVal = Properties.Settings.Default.Settings_TextVal;
        }

       private bool _test = false;
        public bool Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("Test");
            }
        }

        private bool _test1 = false;
        public bool Test1
        {
            get { return _test1; }
            set
            {
                _test1 = value;
                OnPropertyChanged("Test1");
            }
        }

        private int _sliderVal = 0;
        public int SliderVal
        {
            get { return _sliderVal; }
            set
            {
                _sliderVal = value;
                OnPropertyChanged("SliderVal");
            }
        }

        private string _textVal;
        public string TextVal
        {
            get { return _textVal; }
            set
            {
                _textVal = value;
                OnPropertyChanged("TextVal");
            }
        }
    }
}
