using System.Collections.Generic;

namespace Tech.Tevux.Dashboards.Controls;

public class MyLibrary : ILibrary, IDashboardControlProvider {
    private bool _isDisposed;
    public static MyLibrary Instance { get; } = new MyLibrary();
    public List<System.Type> DashboardControls { get; private set; } = null!;

    public void Dispose() {
        // A good article explaining how to implement Dispose. https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public List<System.Type> GetDashboardControls() {
        return DashboardControls;
    }

    public void Initialize() {
        DashboardControls = new List<System.Type>() { typeof(Label) };
    }

    protected virtual void Dispose(bool isCalledManually) {
        if (_isDisposed == false) {
            if (isCalledManually) {
                // Dispose managed objects here.
            }

            // Free unmanaged resources here and set large fields to null.

            _isDisposed = true;
        }
    }
}
