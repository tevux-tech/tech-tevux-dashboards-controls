using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Windows.Controls;
using System.Windows.Input;
using DevBot9.Mvvm;
using Microsoft.Win32;

namespace Tech.Tevux.Dashboards.Controls;

public class ImageEditor : Control, IDisposable {
    public static readonly DependencyProperty LoadCommandProperty = DependencyProperty.Register(
        nameof(LoadCommand),
        typeof(ICommand),
        typeof(ImageEditor),
        new PropertyMetadata(default(ICommand)));

    static ImageEditor() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageEditor), new FrameworkPropertyMetadata(typeof(ImageEditor)));
    }

    public ImageEditor(Control control) : this() {
        if (control is not Image imageControl) { return; }

        LoadCommand = new DelegateCommand(() => {
            var dialog = new OpenFileDialog {
                Filter = "Images|*.png;*.jpg"
            };

            if (dialog.ShowDialog() == true) {
                // Loading image in whatever format it is.
                using var image = System.Drawing.Image.FromFile(dialog.FileName);

                // Re-saving image to memory as PNG.
                using var pngStream = new MemoryStream();
                image.Save(pngStream, ImageFormat.Png);
                var pngBytes = pngStream.ToArray();

                // Converting to base64 and assigning it to the control
                var base64String = Convert.ToBase64String(pngBytes);
                imageControl.RawData = base64String;
            }
        });
    }

    public ImageEditor() { }

    public ICommand LoadCommand {
        get { return (ICommand)GetValue(LoadCommandProperty); }
        set { SetValue(LoadCommandProperty, value); }
    }

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
