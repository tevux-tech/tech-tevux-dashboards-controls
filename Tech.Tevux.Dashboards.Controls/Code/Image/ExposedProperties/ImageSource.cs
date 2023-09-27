using System.Windows.Media;

namespace Tech.Tevux.Dashboards.Controls;

public partial class Image {
    public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
        nameof(ImageSource),
        typeof(ImageSource),
        typeof(Image),
        new PropertyMetadata(null));

    public ImageSource ImageSource {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }
}
