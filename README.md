# How to Disable Resizing of a WinForms MetroForm?

This sample illustrates how to disable resizing of [WinForms MetroForm](https://www.syncfusion.com/winforms-ui-controls/metroform).

In [MetroForm](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.MetroForm.html), user can change the size of the form dynamically by using the resizing cursor that displayed when hovering the mouse on the form border. Resizing of the form can be disabled by setting the `FormBorderStyle` property of the form to `FixedDialog`, `FixedSingle`, or `Fixed3D`.

#### C#
``` csharp
public Form1()
{
    InitializeComponent();
    this.FormBorderStyle = FormBorderStyle.FixedSingle; // OR FormBorderStyle.FixedDialog OR FormBorderStyle.Fixed3D
}
```

Take a moment to peruse the WinForms [MetroForm - Getting Started](https://help.syncfusion.com/windowsforms/metro-form/getting-started) documentation, where you can find about MetroForm features with code examples.

## Requirements to run the demo
Visual Studio 2015 and above versions