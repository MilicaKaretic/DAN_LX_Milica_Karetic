using DAN_LX_Milica_Karetic.Model;
using DAN_LX_Milica_Karetic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DAN_LX_Milica_Karetic.View
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
            this.DataContext = new AddUserViewModel(this);
        }

        /// <summary>
        /// Window constructor for editing users
        /// </summary>
        /// <param name="userEdit">user that is bing edited</param>
        public AddUserWindow(tblUser userEdit)
        {
            InitializeComponent();
            this.DataContext = new AddUserViewModel(this, userEdit);
        }

        /// <summary>
        /// Validate that User input is just numbers
        /// </summary>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
