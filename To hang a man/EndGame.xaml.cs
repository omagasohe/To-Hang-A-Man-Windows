using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace To_hang_a_man
{
    /// <summary>
    /// Page splashed at end of game.
    /// </summary>
    public sealed partial class EndGame : Page
    {
        public EndGame()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter != null)
            {
                EndData d = (EndData)e.Parameter;
                if (d.win)
                    txtState.Text = "You won, congradulations!";
                else
                    txtState.Text = "Please try again!";

                txtDef.Text = d.definition;
                txtWord.Text = "The Word was " + d.word;
                    
            }
            base.OnNavigatedTo(e);
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void txtState_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
