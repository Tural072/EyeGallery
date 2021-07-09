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

namespace EyeGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image Image;
        public List<Image> Images { get; set; }
        public MainWindow()
        {
            Images = new List<Image> {
            new Image
                {
                ImagePath="Images/1monaLisa.jpg"
                },
            new Image
                {
                ImagePath="Images/2theLastSupper.jpg"

                },
            new Image
                {
                ImagePath="Images/3theStarryNight.jpg"

                },
            new Image
                {

                },
            new Image
                {

                },
            new Image
                {

                },
            new Image
                {

                },
            new Image
                {

                },
            new Image
                {

                },
            new Image
                {

                }
            };
            InitializeComponent();
            DataContext = this;
        }
    }
}
