using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Security.Policy;
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
using System.Linq;
using System.Collections.Generic;

namespace StudentSquads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Squad> squads = new List<Squad>();
        List<GeneralInformation> generalInformations = new List<GeneralInformation>();
        List<Announcement> Announcements = new List<Announcement>();
        List<Timetable> Timetables = new List<Timetable>();
        RandomPhoto photo = new RandomPhoto();
     

        int selectedSquad = -1;
        int currentTabIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void uploadSquads()
        {
            using HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync("http://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/getSquads.php");

            string squadsJSON = await response.Content.ReadAsStringAsync();

            squads = JsonConvert.DeserializeObject<List<Squad>>(squadsJSON);
            List<SquadItem> items = new();

            foreach (Squad squad in squads)
            {
                items.Add(new SquadItem() { Name = squad.Name, Logo = squad.logo, Id = squad.id });
            }
            squadList.ItemsSource = items;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            uploadSquads();
        }

        private void squadList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                selectedSquad = squads[squadList.SelectedIndex].id;
            }
            catch (Exception ex)
            {

            }
            
        }

        private async void uploadGeneralInformation()
        {
            using HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync("http://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/generalInfo.json");

            string generalJSON = await response.Content.ReadAsStringAsync();

            string info = "";

            generalInformations = JsonConvert.DeserializeObject<List<GeneralInformation>>(generalJSON);
            for (int i = 0; i < generalInformations.Count; i++)
            {
                if (int.Parse(generalInformations[i].id) == selectedSquad)
                {
                    info = generalInformations[i].information;
                }
            }

            generalInformation.Text = info;
        }

        private async void loadGeneralInformation_Click(object sender, RoutedEventArgs e)
        {
            uploadGeneralInformation();
        }

        private async void uploadNewsList()
        {
            using HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync("https://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/announcements.json");

            string generalJSON = await response.Content.ReadAsStringAsync();

            List<AnnouncementItem> items = new();
            Announcements = JsonConvert.DeserializeObject<List<Announcement>>(generalJSON);
            for (int i = 0; i < Announcements.Count; i++)
            {
                if (int.Parse(Announcements[i].id) == selectedSquad)
                {
                    items.Add(new AnnouncementItem() { Time = Announcements[i].Time, AnnouncementText = Announcements[i].Text });
                }
            }
            announcementList.ItemsSource = items;
        }

        private async void newsList_Click(object sender, RoutedEventArgs e)
        {

            uploadNewsList();
        }

        private async void uploadMeetingList()
        {
            using HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync("http://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/getTimetable.php");

            string generalJSON = await response.Content.ReadAsStringAsync();

            List<TimetableItem> items = new();
            Timetables = JsonConvert.DeserializeObject<List<Timetable>>(generalJSON);
            for (int i = 0; i < Timetables.Count; i++)
            {
                if (int.Parse(Timetables[i].squad) == selectedSquad)
                {
                    items.Add(new TimetableItem() { Date = Timetables[i].date, Weekday = Timetables[i].weekday, StartTime = Timetables[i].start_time, EndTime = Timetables[i].end_time, IsCancelled = Timetables[i].is_cancelled });
                }
            }
            meetingList.ItemsSource = items;
        }

        private async void meetingList_Click(object sender, RoutedEventArgs e)
        {
            uploadMeetingList();
        }

        private async void uploadPhoto()
        {
            using HttpClient httpClient = new HttpClient();
            var values = new Dictionary<string, string>
              {
                  { "id", selectedSquad.ToString() }
              };

            var content = new FormUrlEncodedContent(values);

            var response = await httpClient.PostAsync("https://buildingsquaduspu.xn--100-5cdnry0bhchmgqi5d.xn--p1ai/php/getRandomPhoto.php", content);

            var responseString = await response.Content.ReadAsStringAsync();

            try
            {
                photo = JsonConvert.DeserializeObject<RandomPhoto>(responseString);

                Uri imageUri = new Uri(photo.link, UriKind.RelativeOrAbsolute);
                BitmapImage bitmap = new BitmapImage(imageUri);

                Photo.Source = bitmap;
                Description.Text = photo.description;

            }
            catch (Exception ex)
            {
                Description.Text = "Фотографии отсутствуют";
            }
        }
        private async void downloadPhoto_Click(object sender, RoutedEventArgs e)
        {
            uploadPhoto();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentTabIndex = Container.SelectedIndex;

            switch (currentTabIndex)
            {
                //case 0: uploadSquads(); break;
                case 1: uploadGeneralInformation(); break;
                case 2: uploadNewsList(); break;
                case 3: uploadMeetingList(); break;
                case 4: uploadPhoto(); break;
                default: break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uploadSquads();
        }

        
    }
}