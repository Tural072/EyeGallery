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
                Name="Mona Lisa",
                ImagePath="Images/monaLisa.jpg",
                Author="Leonardo Da Vinci",
                Date="1506's",
                Price="Price : \n$860 million",
                Description="Inarguably the most famous painting to have ever been created in the Western World, the Mona Lisa was painted by Leonardo da Vinci between 1503 and 1506. He finished working on it in 1519. The painting is displayed in Louvre museum of Paris. It is believed to be a portrait of Lisa Gherardini, an Italian noblewoman."
                },
            new Image
                {
                Name="The Last Supper",
                ImagePath="Images/theLastSupper.jpg",
                Author="Leonardo Da Vinci",
                Date="1.05.1498",
                Price="Price : \n$450 million",
                Description="The Last Supper is a famous painting by Leonardo da Vinci. The painting depicts the Last Supper of Jesus and His disciples. It is said to portay the confusion that ensued after Jesus declared that one of them would betray him. The painting was made between 1495 and 1498 and is placed in the Santa Maria Delle Grazie Monastery in Milan"
                },
            new Image
                {
                Name="The Starry Night",
                ImagePath="Images/theStarryNight.jpg",
                Author="Vincent Van Gogh",
                Date="11.06.1889",
                Price="Price : \n$100 million",
                Description="\"And he dreamed yet another dream, and told it his brethren, and said, Behold, I have dreamed a dream more; and, behold, the sun and the moon and the eleven stars made obeisance to me.\"Van Gogh painted Starry Night while in an Asylum where he had willingly committed himself. Earlier that year he had cut off his left ear lobe."
                },
            new Image
                {
                Name="The Scream",
                ImagePath="Images/theScream.jpg",
                Author="Edvard Munch",
                Date="1893's",
                Price="Price : \n$119.9 million",
                Description="There’s something mysterious about this image besides the aura of fear it creates. Only a master such as Munch could have put an emotion like fear on paper. Munch had made four versions of The Scream. At first he made a painted version and a crayon version. Later he added two more- one pastel version and a tempera paint version."
                },
            new Image
                {
                Name="The Girl With Pearl Earring",
                ImagePath="Images/theGirlWithAPearlEarring.jpg",
                Author="(Johannes Vermeer)",
                Date="1665's ",
                Price="Price : \n$10.62 million",
                Description="It is said that the girl is Vermeer’s eldest daughter, Maria. Her features are present in many of his works, but it remains hard to compare the pieces. A book, work of fiction with the same title was written by Tracy Chevalier."
                },
            new Image
                {
                Name="Guernica",
                ImagePath="Images/Guernica.jpg",
                Author="(Pablo Picasso)",
                Date="1937's",
                Price="Price : \n$200 million",
                Description="Guernica is a Picasso painting showing the bombing of Spain’s city of Guernica during the Spanish Civil War. The 1937 painting is housed in the Museo Reina Sofia in Madrid. It is considered to be one of the most important anti-war works of art in history."
                },
            new Image
                {
                Name="Massacre of the Innocents",
                ImagePath="Images/massacreOfTheInnocent.jpg",
                Author="(Peter Paul Rubens)",
                Date="1591's",
                Price="Price : \n$117 million",
                Description="The painting derives its theme from the biblical massacre of the innocents of Bethlehem. After being told about the birth of Christ by the three wise men, King Herod instructed the killing of young male children and infants in the city of Bethlehem. There are dead bodies of children lying about in the image."
                },
            new Image
                {
                Name="The Night Watch",
                ImagePath="Images/TheNightWatch.jpg",
                Author="(Rembrandt)",
                Date="1642's",
                Price="Price : \n$3.4 million",
                Description="The Night Watch was painted by Rembrandt in 1642. It depicts the departure of a city led by its captain. The painting is displayed at the Rijksmuseum in Amsterdam. The unique dark varnish makes the painting take on the appearance of a night scene."
                },
            new Image
                {
                Name="The Persistence Of Memory",
                ImagePath="Images/thePersistenceOfMemory.jpg",
                Author="(Salvador Dali)",
                Date="1931's",
                Price="Price : \n$200 million",
                Description="The Persistence of Memory was painted by Salvador Dali in 1931. It is one of his most famous paintings. The Persistence of Memory depicts melting clock faces and is thought to have been inspired by the Theory of Relativity. The painting is displayed at the MoMA."
                },
            new Image
                {
                Name="Whistler's Mother",
                ImagePath="Images/whistlersMother.jpg",
                Author="(James Whistler)",
                Date="1871's",
                Price="Price : \n$50 million",
                Description="Whistler’s Mother, or the Arrangement in Grey and Black, was painted in 1871 by James McNeill Whistler showing his mother seated on a chair against a gray wall. The painting is displayed in the Musée d’Orsay in Paris."
                },
            new Image
                {
                Name="The Last Judgement",
                ImagePath="Images/theLastJudgement.jpg",
                Author="(Hieronymus Bosch)",
                Date="1541's",
                Price="Price : \n$70 million",
                Description="The painting is nothing short of magnificent. It is beautifully done.The left panel shows the creation of Adam and Eve. The middle panel shows the ‘last judgement’ by Jesus as to who shall go to heaven and who shall go to hell. The Earth we can see is burning. The panel on the right is a loathsome image of hell."
                },
            new Image
                {
                Name="Metamorphosis of Narcissus",
                ImagePath="Images/metamorphisisOfNarcissus.jpg",
                Author="(Salvador Dali)",
                Date="1937's",
                Price="Price : \n$120 million",
                Description="We are all familiar with the greek mythology of Narcissus, the man who became obsessed with his own image. Well, Dali here has painted his own interpretation of Narcissus.The story goes something like this. Narcissus was beautiful and he ended up breaking the hearts of many. So the Gods interfered."
                }
            };
            DataContext = this;
            InitializeComponent();
        }

        private void mainListbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (mainListbox.SelectedItem is Image item)
            {
                PropertyWindow propertyWindow = new PropertyWindow();
                propertyWindow.ImageCopy = Images;
                propertyWindow.index = mainListbox.SelectedIndex;
                Image = item;
                propertyWindow.mainImage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.RelativeOrAbsolute));
                propertyWindow.priceTxtb.Text = item.Price;
                propertyWindow.descriptionTxtb.Text = item.Description;
                propertyWindow.dateTxtBlk.Text = item.Date;
                propertyWindow.nameTxtBlk.Text = item.Name+" "+item.Author;
                propertyWindow.ShowDialog();
            }
            
        }

        private void largeIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 300.0;
        }

        private void mediumIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 150.0;
        }

        private void smallIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 50.0;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
