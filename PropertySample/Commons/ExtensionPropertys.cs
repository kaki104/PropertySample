using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PropertySample.Commons
{
    public class ExPropertys
    {
        public static string GetBindablePassword(DependencyObject obj)
        {
            return (string)obj.GetValue(BindablePasswordProperty);
        }

        public static void SetBindablePassword(DependencyObject obj, string value)
        {
            obj.SetValue(BindablePasswordProperty, value);
        }

        // Using a DependencyProperty as the backing store for BindablePassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BindablePasswordProperty =
            DependencyProperty.RegisterAttached("BindablePassword", typeof(string), typeof(ExPropertys), new PropertyMetadata(null));




        public static bool GetIsPasswordBindable(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsPasswordBindableProperty);
        }

        public static void SetIsPasswordBindable(DependencyObject obj, bool value)
        {
            obj.SetValue(IsPasswordBindableProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsPasswordBindable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPasswordBindableProperty =
            DependencyProperty.RegisterAttached("IsPasswordBindable", typeof(bool), typeof(ExPropertys), new PropertyMetadata(false, IsPasswordBindableChanged));

        private static void IsPasswordBindableChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //이렇게 사용하는 것은 저도 처음 입니다. VisualStudio 2017에서만 가능할 듯 합니다.
            if (!(d is PasswordBox passwordBox)) return;

            if ((bool) e.NewValue)
            {
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
            else
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox) sender;
            SetBindablePassword(passwordBox, passwordBox.Password);
        }
    }
}
