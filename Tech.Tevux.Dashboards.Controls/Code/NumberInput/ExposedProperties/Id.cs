namespace Tech.Tevux.Dashboards.Controls;

public partial class NumberInput {
    public static readonly DependencyProperty IdProperty = DependencyProperty.Register(
        nameof(Id),
        typeof(string),
        typeof(NumberInput),
        new PropertyMetadata("noname", (obj, e) => {
            ((NumberInput)obj).Reconfigure();
        }));

    [ExposedSingleLineText]
    [Category(OptionCategory.Main)]
    public string Id {
        get { return (string)GetValue(IdProperty); }
        set { SetValue(IdProperty, value); }
    }
}
