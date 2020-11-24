# How to disable resizing of a WinForms MetroForm?

This sample illustrates how to disable resizing of MetroForm.

In MetroForm, user can change the size of the form dynamically by using the resizing cursor that displayed when hovering the mouse on the form border. Resizing of the form can be disabled by setting the FormBorderStyle property of the form to `FixedDialog`, `FixedSingle`, or `Fixed3D`.

```C#
public Form1()
{
    InitializeComponent();
    this.FormBorderStyle = FormBorderStyle.FixedSingle; // OR FormBorderStyle.FixedDialog OR FormBorderStyle.Fixed3D
}
```

## Requirements to run the demo
Visual Studio 2015 and above versions

