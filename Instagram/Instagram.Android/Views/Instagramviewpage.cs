using Xamarin.Forms;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    public class InstagramViewPage : ContentPage
    {

        public InstagramViewPage()
        {

            BackgroundColor = Color.White;

            var twitterViewModel = new InstagramViewModel();

            BindingContext = twitterViewModel;

            var label = new Label
            {
                Text = "Instagram",
                TextColor = Color.Gray,
                FontSize = 24
            };

            var dataTemplate = new DataTemplate(() =>
            {
                var screenNameLabel = new Label
                {
                    TextColor = Color.FromHex("#1c5380"),
                    FontSize = 22
                };
                var textLabel = new Label
                {
                    TextColor = Color.Black,
                    FontSize = 14
                };
                var likesLabel = new Label
                {
                    TextColor = Color.FromHex("#517fa4"),
                    FontSize = 14
                };
                var commentsLabel = new Label
                {
                    TextColor = Color.FromHex("#517fa4"),
                    FontSize = 14
                };
                var profileImage = new Image
                {
                    WidthRequest = 60,
                    HeightRequest = 60,
                    VerticalOptions = LayoutOptions.Start
                };
                var mediaImage = new Image
                {
                    HeightRequest = 200
                };

                screenNameLabel.SetBinding(Label.TextProperty, new Binding("UserName"));
                textLabel.SetBinding(Label.TextProperty, new Binding("Text"));
                profileImage.SetBinding(Image.SourceProperty, new Binding("ProfilePicture"));
                mediaImage.SetBinding(Image.SourceProperty, new Binding("StandardResolutionUrl"));
                likesLabel.SetBinding(Label.TextProperty, new Binding("LikesCount", BindingMode.Default, null, null, "{0:n0} likes |"));
                commentsLabel.SetBinding(Label.TextProperty, new Binding("CommentsCount", BindingMode.Default, null, null, "{0:n0} likes"));

                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(0, 5),
                        Children =
                        {
                            profileImage,
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    screenNameLabel,
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,
                                        Children =
                                        {
                                            likesLabel,
                                            commentsLabel,
                                        }
                                    },
                                    textLabel,
                                    mediaImage,
                                }
                            }
                        }
                    }
                };
            });

            var listView = new ListView
            {
                HasUnevenRows = true
            };

            listView.SetBinding(ListView.ItemsSourceProperty, "InstagramItems");

            listView.ItemTemplate = dataTemplate;

            Content = new StackLayout
            {
                Padding = new Thickness(5, 10),
                Children =
                {
                    label,
                    listView
                }
            };
        }
    }
}