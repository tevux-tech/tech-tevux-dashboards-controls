namespace Tech.Tevux.Dashboards.Controls;

public partial class NumberOutput {
    public static readonly DependencyProperty IdProperty = DependencyProperty.Register(
        nameof(Id),
        typeof(string),
        typeof(NumberOutput),
        new PropertyMetadata("noname", (d, e) => {
            ((NumberOutput)d).Reconfigure();
        }));

    [ExposedSingleLineText]
    [Category(OptionCategory.Main)]
    public string Id {
        get { return (string)GetValue(IdProperty); }
        set { SetValue(IdProperty, value); }
    }
}
