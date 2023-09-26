using System.Drawing;
using System.IO.Compression;
using System.Windows.Media.Imaging;

namespace Tech.Tevux.Dashboards.Controls;

public partial class Image {
    public static readonly DependencyProperty RawDataProperty = DependencyProperty.Register(
        nameof(RawData),
        typeof(string),
        typeof(Image),
        new PropertyMetadata("", (d, e) => {
            if (d is not Image zeImage) { return; }
            if (e.NewValue is not string newRawData) { return; }
            if (newRawData.Length <= 0) { return; }

            using var pngStream = new System.IO.MemoryStream(Convert.FromBase64String(newRawData));
            var image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = pngStream;
            image.EndInit();
            zeImage.ImageSource = image;
        }));

    [ExposedSingleLineText(false, true)]
    [Category(OptionCategory.Main)]
    public string RawData {
        get { return (string)GetValue(RawDataProperty); }
        set { SetValue(RawDataProperty, value); }
    }
}
