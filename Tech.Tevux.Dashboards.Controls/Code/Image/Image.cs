namespace Tech.Tevux.Dashboards.Controls;

[Category("General")]
[DisplayName("Image")]
public partial class Image : ControlBase {
    static Image() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Image), new FrameworkPropertyMetadata(typeof(Image)));
    }

    public Image() {
    }
}
