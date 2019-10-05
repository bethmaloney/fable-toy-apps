module App

(**
 The famous Increment/Decrement ported from Elm.
 Now without Elmish!
*)

open Feliz
open Browser.Dom

let view = React.functionComponent(fun () ->
  let (count, setCount) = React.useState(0)

  Html.div [
    Html.h1 count

    Html.button [
      prop.style [ style.marginRight 5 ]
      prop.text "Increment"
      prop.onClick (fun _ -> setCount(count + 1))
    ]

    Html.button [
        prop.style [ style.marginLeft 5 ]
        prop.onClick (fun _ -> setCount(count - 1))
        prop.text "Decrement"
    ]
  ]
)

ReactDOM.render(view(), document.getElementById("elmish-app"))
