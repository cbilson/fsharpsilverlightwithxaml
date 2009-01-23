#light

namespace SilverF
    open System
    open System.Windows
    open System.Windows.Browser
    open System.Windows.Controls

    type App() as this = 
        inherit Application()
       
        do
            //let visual = new NoXamlFSharpControl()
            let visual = AgUtil.loadXamlUserControl "SomeXamlView"
            this.Startup.Add (fun _ -> this.RootVisual <- visual)
            
            let button = visual.FindName("theButton") :?> Button
            button.Click.Add(fun _ -> button.Content <- "OK, thanks!")
            
            HtmlPage.Document.SetProperty("title", "Title set from f#! Hah!")
