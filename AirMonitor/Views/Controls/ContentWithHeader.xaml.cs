using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentWithHeader : StackLayout
    {
        public ContentWithHeader()
        {
            InitializeComponent();
        }
    }
}