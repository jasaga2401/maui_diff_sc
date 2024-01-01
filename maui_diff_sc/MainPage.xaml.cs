using System.Collections.ObjectModel;

namespace maui_diff_sc
{
    public partial class MainPage : ContentPage
    {
         
        public ObservableCollection<BasePage> Pages { get; set; }

        public MainPage()
        {
            InitializeComponent();            

            Pages = new ObservableCollection<BasePage>
        {
            new PageType1 {
                ImageUrl1 = "marcus.jpg",
                Title = "Marcus Rashford", 
                Description = "Some player information below:",
                Age = 26,
                Appearances = 383,
                totalGoals = 126
            },

            new PageType2 {
                ImageUrl2 = "casemiro.jpg",
                Title = "Casemiro", 
                Description = "Some player information below:",
                Age = 31,
                Appearances = 66,
                totalGoals = 11

            },

            new PageType3 {
                ImageUrl3 = "martinez.jpg",
                Title = "Lisandro Martinez",
                Description = "Some player information below:",
                Age = 25,
                Appearances = 51,
                totalGoals = 1
            },
            
            // new PageType2 { ImageUrl = "car1.png" },
            // Add more pages as needed
        };

            BindingContext = this;
        }

  
    }

}
