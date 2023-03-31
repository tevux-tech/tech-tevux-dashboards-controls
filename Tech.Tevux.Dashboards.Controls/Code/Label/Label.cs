using System.ComponentModel;

namespace Tech.Tevux.Dashboards.Controls;

[Category("Basic")]
[DisplayName("Label")]
public partial class Label : ControlBase {
    static Label() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Label), new FrameworkPropertyMetadata(typeof(Label)));
    }
}
