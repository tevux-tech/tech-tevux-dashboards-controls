using System.Collections.Generic;

namespace Tech.Tevux.Dashboards.Controls;

public class MyLibrary : IDashboardControlProvider {
    public static MyLibrary Instance { get; } = new MyLibrary();

    public List<System.Type> GetDashboardControls() {
        return new List<System.Type> { typeof(Label) };
    }
}
