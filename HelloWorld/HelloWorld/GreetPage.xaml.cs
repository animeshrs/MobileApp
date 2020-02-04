using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            Slider.Value = 0.5;
        }
    }
}