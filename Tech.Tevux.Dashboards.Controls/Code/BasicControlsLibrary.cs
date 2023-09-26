using System.Collections.Generic;

namespace Tech.Tevux.Dashboards.Controls;

public class BasicControlsLibrary : ILibrary, IDashboardControlProvider, IDashboardControlEditorProvider {
    public static BasicControlsLibrary Instance { get; } = new();

    private BasicControlsLibrary() {
        DashboardControls.Add(typeof(Label));
        DashboardControls.Add(typeof(NumberOutput));
        DashboardControls.Add(typeof(TextOutput));
        DashboardControls.Add(typeof(NumberInput));
        DashboardControls.Add(typeof(Image));

        DashboardControlEditors.Add(typeof(Image), new List<Type> { typeof(ImageEditor) });
    }

    #region Dependency injection

    [InjectedByHost]
    public ISharedLibraryMessagingProvider GlobalMessenger { get; set; } = new EmptySharedLibraryMessagingProvider();

    [InjectedByHost]
    public ILogger Logger { get; set; } = NullLogger.Instance;

    #endregion

    #region Dependency providers

    public List<System.Type> DashboardControls { get; private set; } = new();
    public Dictionary<Type, List<Type>> DashboardControlEditors { get; } = new();

    #endregion

    #region ILibrary

    private bool _isInitialized;

    public void Initialize() {
        if (_isInitialized) { return; }

        _isInitialized = true;
    }

    #endregion

    #region IDisposable

    private bool _isDisposed;

    public void Dispose() {
        // A good article explaining how to implement Dispose. https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
        Dispose(true);
        GC.SuppressFinalize(this);
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

    #endregion
}
