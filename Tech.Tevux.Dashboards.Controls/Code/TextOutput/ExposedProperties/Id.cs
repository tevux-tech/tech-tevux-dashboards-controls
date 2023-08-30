namespace Tech.Tevux.Dashboards.Controls;

public partial class TextOutput {
    public static readonly DependencyProperty IdProperty = DependencyProperty.Register(
        nameof(Id),
        typeof(string),
        typeof(TextOutput),
        new PropertyMetadata("noname", (d, e) => {
            ((TextOutput)d).Reconfigure();
        }));

    [ExposedSingleLineText]
    [Category(OptionCategory.Main)]
    public string Id {
        get { return (string)GetValue(IdProperty); }
        set { SetValue(IdProperty, value); }
    }
}
