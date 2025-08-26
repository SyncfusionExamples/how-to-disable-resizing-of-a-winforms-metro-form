# How to disable resizing of a WinForms MetroForm

This sample illustrates how to disable resizing of [WinForms MetroForm](https://www.syncfusion.com/winforms-ui-controls/metroform).

In `MetroForm`, user can change the size of the form dynamically by using the resizing cursor that displayed when hovering the mouse on the form border. Resizing of the form can be disabled by setting the [FormBorderStyle](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.formborderstyle?view=windowsdesktop-7.0&viewFallbackFrom=net-5.0) property of the form to [FixedDialog](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formborderstyle?view=windowsdesktop-7.0#fields), [FixedSingle](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formborderstyle?view=windowsdesktop-7.0#fields), or [Fixed3D](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.formborderstyle?view=windowsdesktop-7.0#fields).

``` csharp
public Form1()
{
    InitializeComponent();
    this.FormBorderStyle = FormBorderStyle.FixedSingle; // OR FormBorderStyle.FixedDialog OR FormBorderStyle.Fixed3D
}
```

## Requirements to run the demo
Visual Studio 2015 and above versions