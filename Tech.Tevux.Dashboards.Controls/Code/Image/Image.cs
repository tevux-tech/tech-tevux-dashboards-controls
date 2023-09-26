namespace Tech.Tevux.Dashboards.Controls;

[Category("General")]
[DisplayName("Image")]
public partial class Image : ControlBase {
    static Image() {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Image), new FrameworkPropertyMetadata(typeof(Image)));

        // It is probably better to have empty caption by default for images. Overriding default value.
        CaptionProperty.OverrideMetadata(forType: typeof(Image), typeMetadata: new PropertyMetadata(""));
    }

    public Image() {
        // Some default "no image" image. Only used when adding a new instance. 
        RawData = "iVBORw0KGgoAAAANSUhEUgAAAIAAAACACAIAAABMXPacAAAABGdBTUEAALGPC/xhBQAAAAlwSFlzAAAOwgAADsIBFShKgAAAAuxJREFUeF7t1+uVojAAQOGpi4Ksx2psxmJmQ14kkHVHDzl3He/3LwKBcBX161soA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMAzAAwA8AMADMA7OQA9+vylSzXe35tlV+/3PL4x26XONvl1s72m5wcIN+vqL3brwa4G+A56X4tS7zdzYfg5U/ArzcnwPW2u+HHAPfb9RJfi5bLdfwer5+AOErThLDbwcu6KYxT83Wirfq6V3eO5hT39vRZc7n9tU38+M15BIWVlBTp2ncB8nCnrr8xCvAveed8aOfxPGnr6Lj+G+1M0wL097wPUJaYn+zr+zeOB8v8S4C053Yf40zlCyNPE6YNH6s8Y3hPx21xono1ab/u2sqoXEqYtN18unkBylri7egW2d+nqL/PjWGAeuT+sN149wxaxU31ao4B8uCovdozzQxQhmE0ClB2Wg1eSvoNTwXIg17aNLjN/RmO3jNAXs/uSznv1CypLLseV/UTPhNgd5Zu1zSoH47wRV4uZX+G6SYH2NbaBKjvsvodkI5qDyv6CV8IkM7RnyINBmcLth1rk/ggm1VkeoBtSUF5vXlpM1xjP+EzAWrmTtr1cP5l+605Pu6dA2xLalfR/9RuHgK91wPEYTlFmD/9DIqbxvd4m2b95fOTizvDyQHeQsoU/8FF5ZfmtHf5I58b4AC5/x8ZYP+Mid8AE58yD31mgP+IAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgCYAWAGgBkAZgDU9/cfjZ3agjBmqoIAAAAASUVORK5CYII=";
    }
}
