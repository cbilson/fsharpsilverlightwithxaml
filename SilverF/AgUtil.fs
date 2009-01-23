#light

module AgUtil

    open System
    open System.IO
    open System.Reflection
    open System.Windows
    open System.Windows.Markup
    open System.Windows.Controls

    let getResourceAsText name =
        let fullName = sprintf "%s.xaml" name
        use stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fullName)
        use reader = new StreamReader(stream)
        reader.ReadToEnd()
    
    let loadXamlUserControl name =
        let xaml = getResourceAsText name
        XamlReader.Load(xaml) :?> UserControl
        
        