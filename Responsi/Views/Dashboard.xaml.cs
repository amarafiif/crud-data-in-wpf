using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Responsi.ViewModels;
using Responsi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Responsi.Views
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {

        //  private void MnuUser_Click(object sender, RoutedEventArgs e)
        // {
        //     PnlContent.Children.Clear();
        //      PnlContent.Children.Add(new UsersView());
        //  }
        public Dashboard()
        {

            InitializeComponent();
            vm = new UserViewModel();
            vm.OnCallBack += ResetComponent;
            DataContext = vm;
            ResetComponent();
        }

        private UserViewModel vm;

        private void TblData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Visible;
            BtnEdit.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Visible;


        }

        private void ResetComponent()
        {
            TxtUid.IsReadOnly = true;

            BtnNew.Visibility = Visibility.Visible;
            BtnEdit.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Visible;
            LblUid.Visibility = Visibility.Visible;
            TxtUid.Visibility = Visibility.Visible;

            TxtName.IsEnabled = false;
            TxtUser.IsEnabled = false;
            TxtPassword.IsEnabled = false;
            ChkStatus.IsEnabled = false;

            vm.Model = new User();
            BtnNew.Focus();
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            BtnNew.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Visible;
            BtnInsert.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            TxtUser.IsEnabled = true;
            TxtPassword.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            vm.Model = new User();
            vm.IsChecked = true;
            TxtName.Focus();
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            BtnEdit.Visibility = Visibility.Visible;
            BtnInsert.Visibility = Visibility.Visible;
            BtnReset.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
            TxtName.IsEnabled = true;
            TxtUser.IsEnabled = true;
            TxtPassword.IsEnabled = true;
            ChkStatus.IsEnabled = true;
            LblUid.Visibility = Visibility.Visible;
            TxtUid.Visibility = Visibility.Visible;
            TxtName.Focus();
        }


        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
