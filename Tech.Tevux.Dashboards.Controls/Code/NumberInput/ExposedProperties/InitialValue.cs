namespace Tech.Tevux.Dashboards.Controls;
public partial class NumberInput {
    public static readonly DependencyProperty InitialValueProperty = DependencyProperty.Register(
        nameof(InitialValue),
        typeof(decimal),
        typeof(NumberInput),
        new PropertyMetadata(0m));

    [ExposedNumber]
    [DisplayName("Initial value")]
    [Category(OptionCategory.Main)]
    public decimal InitialValue {
        get { return (decimal)GetValue(InitialValueProperty); }
        set { SetValue(InitialValueProperty, value); }
    }
}
