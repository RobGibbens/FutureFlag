using FeatureFlag;

namespace Example.Features.Main
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string VersionString => new VersionHelper().Version.ToString();
    }
}
