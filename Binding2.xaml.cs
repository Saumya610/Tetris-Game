using MyNs;
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

namespace ShowingBinding
{
    /// <summary>
    /// Interaction logic for Binding2.xaml
    /// </summary>
    public partial class Binding2 : Window
    {
        Person personModel = new Person() { ID = "101", FirstName = "Sachin", LastName = "Tendulkar" };
        public Binding2()
        {
            InitializeComponent();
            Init();
            InitStk1();
            InitStk2();
            InitStk3();
        }
        void Init()
        {
            //set through binding stk2
            Binding binding = new Binding();
            binding.Source = personModel;
            binding.Path = new PropertyPath("ID");
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Mode = BindingMode.TwoWay;
            inpId.SetBinding(TextBox.TextProperty, binding);

            Binding binding2 = new Binding();
            binding2.Source = personModel;
            binding2.Path = new PropertyPath("FirstName");
            binding2.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding2.Mode = BindingMode.TwoWay;
            inpFN.SetBinding(TextBox.TextProperty, binding2);

            Binding binding3 = new Binding();
            binding3.Source = personModel;
            binding3.Path = new PropertyPath("LastName");
            binding3.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding3.Mode = BindingMode.TwoWay;
            inpLn.SetBinding(TextBox.TextProperty, binding3);
        }
        void InitStk1()
        {
            //set the properties
            txtId.Text = personModel.ID;
            txtFName.Text = personModel.FirstName;
            txtLName.Text = personModel.LastName;
        }
        void InitStk2()
        {
            //set through binding stk2
            Binding binding = new Binding();
            binding.Source = personModel;
            binding.Path = new PropertyPath("ID");
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Mode = BindingMode.OneWay;
            txtId2.SetBinding(TextBlock.TextProperty, binding);

            Binding binding2 = new Binding();
            binding2.Source = personModel;
            binding2.Path = new PropertyPath("FirstName");
            binding2.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding2.Mode = BindingMode.OneWay;
            txtFName2.SetBinding(TextBlock.TextProperty, binding2);

            Binding binding3 = new Binding();
            binding3.Source = personModel;
            binding3.Path = new PropertyPath("LastName");
            binding3.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding3.Mode = BindingMode.OneWay;
            txtLName2.SetBinding(TextBlock.TextProperty, binding3);
        }

        void InitStk3()
        {
            //set through binding stk3

            stk3.DataContext = personModel;
            Binding binding = new Binding();
            //binding.Source = personModel;
            binding.Path = new PropertyPath("ID");
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Mode = BindingMode.OneWay;
            txtId3.SetBinding(TextBlock.TextProperty, binding);

            Binding binding2 = new Binding();
            // binding2.Source = personModel;
            binding2.Path = new PropertyPath("FirstName");
            binding2.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding2.Mode = BindingMode.OneWay;
            txtFName3.SetBinding(TextBlock.TextProperty, binding2);

            Binding binding3 = new Binding();
            //binding3.Source = personModel;
            binding3.Path = new PropertyPath("LastName");
            binding3.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding3.Mode = BindingMode.OneWay;
            txtLName3.SetBinding(TextBlock.TextProperty, binding3);
        }
    }
}

