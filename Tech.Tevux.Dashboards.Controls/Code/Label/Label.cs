using System.ComponentModel;

namespace Tech.Tevux.Dashboards.Controls;

[DashboardControl]
[Category("Basic")]
public partial class Label : ControlBase {
    static Label() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Label), new FrameworkPropertyMetadata(typeof(Label)));
    }
}
