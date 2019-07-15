using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace TemplateParentBug
{
    public sealed class CustomControl1 : ToggleButton
    {
        public CustomControl1()
        {
            this.DefaultStyleKey = typeof(CustomControl1);
        }

        public static readonly DependencyProperty Content2Property = DependencyProperty.Register(
            "Content2", typeof(object), typeof(CustomControl1), new PropertyMetadata(default(object)));

        public object Content2
        {
            get { return (object) GetValue(Content2Property); }
            set { SetValue(Content2Property, value); }
        }

    }
}
