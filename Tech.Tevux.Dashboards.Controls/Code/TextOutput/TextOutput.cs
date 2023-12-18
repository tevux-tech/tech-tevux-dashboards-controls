namespace Tech.Tevux.Dashboards.Controls;

[Category("General")]
[DisplayName("Text output")]
public partial class TextOutput : TextualOutputControlBase {
    private readonly ISharedLibraryMessagingProvider _interLibraryMessenger;
    private bool _isDisposed;

    static TextOutput() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(TextOutput), new FrameworkPropertyMetadata(typeof(TextOutput)));
    }

    public TextOutput() {
        _interLibraryMessenger = BasicControlsLibrary.Instance.GlobalMessenger;
    }

    public override void OnApplyTemplate() {
        base.OnApplyTemplate();

        if (DesignerProperties.GetIsInDesignMode(this)) { return; }

        Reconfigure();
    }

    public override void Reconfigure() {
        base.Reconfigure();

        _interLibraryMessenger.Unregister(this);
        _interLibraryMessenger.Register<GetValueMessage>(this, Id, HandleGetValueMessage);
        _interLibraryMessenger.Register<SetValueMessage>(this, Id, HandleSetValueMessage);
    }

    protected override void Dispose(bool isCalledManually) {
        if (_isDisposed == false) {
            if (isCalledManually) {
                // Free managed resources here.
                _interLibraryMessenger.Unregister(this);
            }

            // Free unmanaged resources here and set large fields to null.
            _isDisposed = true;
        }

        base.Dispose(isCalledManually);
    }

    private void HandleGetValueMessage(GetValueMessage message) {
        Dispatcher.Invoke(() => {
            message.Value = TextualValue;
        });
    }

    private void HandleSetValueMessage(SetValueMessage message) {
        Dispatcher.Invoke(() => {
            if (AutoConverter.TryGetAsText(message.Value, out var text)) {
                TextualValue = text;
            } else {
                ErrorMessage = "Value sent to this control is not a text.";
            }
        });
    }
}
