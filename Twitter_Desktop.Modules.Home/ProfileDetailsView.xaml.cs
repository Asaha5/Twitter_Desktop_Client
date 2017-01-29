using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Twitter_Desktop.Modules.Home
{
    /// <summary>
    /// Interaction logic for ProfileDetailsView.xaml
    /// </summary>
    [Export()]
    public partial class ProfileDetailsView : UserControl
    {
        public ProfileDetailsView()
        {
            InitializeComponent();
        }
    }
}
