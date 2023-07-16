using System.Windows.Input;
using Autodesk.Navisworks.Api.Automation;

namespace NavisPlugin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            //when you add Navisworks Application it adds the nw.API.Automation
            var nwApp = new NavisworksApplication();
            nwApp.Visible = true;
        }
    }
}