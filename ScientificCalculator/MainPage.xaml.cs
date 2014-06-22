using ScientificCalculator.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace ScientificCalculator
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private bool op=false;
        private double mem = 0.0;
        int oper = 0;
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            // Replace Textbox Text with 1
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "1";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "1";
                }                
            }
            else
            {
                Display.Text = "1";
            }
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "2";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "2";
                }
            }
            else
            {
                Display.Text = "2";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "3";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "3";
                }
            }
            else
            {
                Display.Text = "3";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "4";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "4";
                }
            }
            else
            {
                Display.Text = "4";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "5";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "5";
                }
            }
            else
            {
                Display.Text = "5";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "6";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "6";
                }
            }
            else
            {
                Display.Text = "6";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "7";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "7";
                }
            }
            else
            {
                Display.Text = "7";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "8";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "8";
                }
            }
            else
            {
                Display.Text = "8";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "9";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "9";
                }
            }
            else
            {
                Display.Text = "9";
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "0";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + "0";
                }
            }
            else
            {
                Display.Text = "0";
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (oper != 0)
            {
                // Result of previous calculation
                switch (oper)
                {
                    case 1:
                        Display.Text = Convert.ToString(mem + Convert.ToDouble(Display.Text));
                        break;
                    case 2:
                        Display.Text = Convert.ToString(mem - Convert.ToDouble(Display.Text));
                        break;
                    case 3:
                        Display.Text = Convert.ToString(mem * Convert.ToDouble(Display.Text));
                        break;
                    case 4:
                        Display.Text = Convert.ToString(mem / Convert.ToDouble(Display.Text));
                        break;
                }
            }
            oper = 1;
            mem = Convert.ToDouble(Display.Text);
            op = true;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (oper != 0)
            {
                // Result of previous calculation
                switch (oper)
                {
                    case 1:
                        Display.Text = Convert.ToString(mem + Convert.ToDouble(Display.Text));
                        break;
                    case 2:
                        Display.Text = Convert.ToString(mem - Convert.ToDouble(Display.Text));
                        break;
                    case 3:
                        Display.Text = Convert.ToString(mem * Convert.ToDouble(Display.Text));
                        break;
                    case 4:
                        Display.Text = Convert.ToString(mem / Convert.ToDouble(Display.Text));
                        break;
                }
            }
            oper = 2;
            mem = Convert.ToDouble(Display.Text);
            op = true;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (oper != 0)
            {
                // Result of previous calculation
                switch (oper)
                {
                    case 1:
                        Display.Text = Convert.ToString(mem + Convert.ToDouble(Display.Text));
                        break;
                    case 2:
                        Display.Text = Convert.ToString(mem - Convert.ToDouble(Display.Text));
                        break;
                    case 3:
                        Display.Text = Convert.ToString(mem * Convert.ToDouble(Display.Text));
                        break;
                    case 4:
                        Display.Text = Convert.ToString(mem / Convert.ToDouble(Display.Text));
                        break;
                }
            }
            oper = 3;
            mem = Convert.ToDouble(Display.Text);
            op = true;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            if (oper != 0)
            {
                // Result of previous calculation
                switch (oper)
                {
                    case 1:
                        Display.Text = Convert.ToString(mem + Convert.ToDouble(Display.Text));
                        break;
                    case 2:
                        Display.Text = Convert.ToString(mem - Convert.ToDouble(Display.Text));
                        break;
                    case 3:
                        Display.Text = Convert.ToString(mem * Convert.ToDouble(Display.Text));
                        break;
                    case 4:
                        Display.Text = Convert.ToString(mem / Convert.ToDouble(Display.Text));
                        break;
                }
            }
            oper = 4;
            mem = Convert.ToDouble(Display.Text);
            op = true;
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            op = false;
            oper = 0;
            Display.Text = "0.0";
            mem = 0.0;
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (oper)
            {
                case 1:
                    Display.Text = Convert.ToString(mem + Convert.ToDouble(Display.Text));
                    break;
                case 2:
                    Display.Text = Convert.ToString(mem - Convert.ToDouble(Display.Text));
                    break;
                case 3:
                    Display.Text = Convert.ToString(mem * Convert.ToDouble(Display.Text));
                    break;
                case 4:
                    Display.Text = Convert.ToString(mem / Convert.ToDouble(Display.Text));
                    break;
            }
            op = false;
            oper = 0;
            mem = Convert.ToDouble(Display.Text);
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0")
            {
                if (op)
                {
                    Display.Text = "0.";
                    op = false;
                }
                else
                {
                    Display.Text = Display.Text + ".";
                }
            }
            else
            {
                Display.Text = "0.";
            }
        }
    }
}
