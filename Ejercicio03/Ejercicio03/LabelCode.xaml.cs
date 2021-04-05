using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelCode : ContentPage
    {
        public LabelCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            var underlinelabel = new Label { Text= "This is underline text.",
                TextDecorations=TextDecorations.Underline };
            var strikethroughtlabel = new Label { Text = "This is underline text with strikethrought.",
                TextDecorations=TextDecorations.Strikethrough };
            var bothlabel = new Label { Text = "This is underline text with strikethrought.",
                TextDecorations=TextDecorations.Underline | TextDecorations.Strikethrough };
            stack.Children.Add(underlinelabel);
            stack.Children.Add(strikethroughtlabel);
            stack.Children.Add(bothlabel);
            Content = stack;
        }
    }
}