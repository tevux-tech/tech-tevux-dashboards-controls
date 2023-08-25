using System.ComponentModel;

namespace Tech.Tevux.Dashboards.Controls;

[Category("General")]
[DisplayName("Label")]
public partial class Label : ControlBase {
    static Label() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Label), new FrameworkPropertyMetadata(typeof(Label)));
    }
}
