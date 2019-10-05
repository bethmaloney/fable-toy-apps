module App

(**
 The famous Increment/Decrement ported from Elm.
 Now without Elmish 😉
*)

open Fable.React
open Fable.React.Props
open Browser.Dom

let view = FunctionComponent.Of(fun () ->
    let counter = Hooks.useState 0
    
    div [] [
          h1 [] [str (string counter.current)]

          button [ 
            OnClick (fun _ -> counter.update (counter.current + 1))
            Style [ MarginRight 5 ]
          ] [ str "Increment" ]

          button [ 
            OnClick (fun _ -> counter.update (counter.current - 1))
            Style [ MarginLeft 5 ]
          ] [ str "Decrement" ]
    ]
  )

ReactDom.render(view(), document.getElementById("elmish-app"))
