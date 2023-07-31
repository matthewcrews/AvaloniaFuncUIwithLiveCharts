namespace AvaloniaFuncUIwithLiveCharts

module Counter =
    open Avalonia.Controls
    open Avalonia.FuncUI.DSL
    open Avalonia.Layout

    type State = { count : int }
    let init () = { count = 0 }

    type Msg = Increment | Decrement | Reset

    let update (msg: Msg) (state: State) : State =
        match msg with
        | Increment -> { state with count = state.count + 1 }
        | Decrement -> { state with count = state.count - 1 }
        | Reset -> init ()

    let view (state: State) (dispatch) =
        DockPanel.create [
            DockPanel.children [
                CartesianChart.create [
                    CartesianChart.plotFromData [0.0; 1.0; 0.0]
                ]
            ]
        ]
