using System.Collections.Generic;

namespace Tech.Tevux.Dashboards.Controls;

public class MyLibrary : IDashboardControlProvider {
    public List<System.Type> GetDashboardControls() {
        return new List<System.Type> { typeof(Label) };
    }
}
