using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PropertySample.Controls
{
    public class GuideTextBox : TextBox
    {
        public string GuideText
        {
            get { return (string)GetValue(GuideTextProperty); }
            set { SetValue(GuideTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GuideText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GuideTextProperty =
            DependencyProperty.Register("GuideText", typeof(string), typeof(GuideTextBox), new PropertyMetadata(null));
    }
}
