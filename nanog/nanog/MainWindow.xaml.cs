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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;

namespace nanog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = ParameterViewModel.InitTable();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {

            //((MainViewModel) DataContext).Calculate();
            this.diagram1.Model = Calculator.Calculate((List<ParameterViewModel>)DataGrid.ItemsSource);
            /*var model = MappingHelper.Map(DataGrid.ItemsSource);         
            
            var s3 = model.Single(x => x.Parameter == ParameterEnum.S3 ).Value;
            var s4 = model.Single(x => x.Parameter == ParameterEnum.S4 ).Value;
            var k3 = model.Single(x => x.Parameter == ParameterEnum.K3 ).Value;
            var k4 = model.Single(x => x.Parameter == ParameterEnum.K4 ).Value;
            var d_n = model.Single(x => x.Parameter == ParameterEnum.DN).Value;
            var gamma_os = model.Single(x => x.Parameter == ParameterEnum.GammaOS).Value;
            var gamma_n = model.Single(x => x.Parameter == ParameterEnum.GammaN).Value;
            */
            //var result = (s4 * Math.Pow(1 /*TODO N*/, gamma_n)/(k4 + Math.Pow(1 /*TODO N*/, gamma_n))) - d_n * /*TODO N ist */ 1 + /*TODO X*/ 1 * 1 /* TODO N*/;
        }

        /* public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }

        */
    }
}
