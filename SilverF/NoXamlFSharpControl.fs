#light

namespace SilverF
    open System
    open System.Windows
    open System.Windows.Controls

    (*
        A user control done completely in f#...kind of tedious and we 
        can't use blend or any fancy designer tools...
    *)
    type NoXamlFSharpControl() as this = 
        inherit UserControl()
        
        do
            let button = new Button()
            button.HorizontalAlignment <- HorizontalAlignment.Center
            button.VerticalAlignment <- VerticalAlignment.Center
            button.Content <- "Click Me!"
            button.Click.Add (fun _ -> button.Content <- "OK, thanks for clicking me.")
            this.Content <- button


