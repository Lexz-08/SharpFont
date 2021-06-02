## SharpFont
### Description
Easily convert byte[] to Font or FontFamily or just get it from the file itself.

### How To Use
This is made obviously assuming you have the `System.Drawing` namespace referenced. As it is the only way to actually access the Font's properties through a variable if you made the variable of type `Font`.<br>
Now do take note, I'm only showing an example of how to load fonts in with this library. I'm not guessing the method of which Microsoft uses to load the default font into Visual Studio Desktop Application projects.
```csharp
// Load ALL installed fonts on your currently active system.
string[] InstalledFontNames = FontLoader.InstalledFontNames;

foreach (string FontName in InstalledFontNames)
{
    // Loads the 'Microsoft Sans Serif' font if you have it installed, which you most likely do.
    if (FontName == "Microsoft Sans Serif")
    {
        // The default font that is loaded in whenever creating a new Desktop Application in Visual Studio.
        Font MicrosoftSansSerif = new Font(FontName, 8.25f);
        
        // Only type this code below if you have System.Windows.Forms referenced on a Windows Forms Application, which you should.
        // Also this code assumes you are accessing and modifying an object of type Form.
        Font = MicrosoftSansSerif;
    }
}
```

### Download
[SharpFont.dll](https://github.com/Lexz-08/SharpFont/releases/download/sharpfont/SharpFont.dll)
