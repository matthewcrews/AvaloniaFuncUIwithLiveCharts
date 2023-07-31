namespace AvaloniaFuncUIwithLiveCharts


open Avalonia.FuncUI.Builder
open Avalonia.FuncUI.DSL
open Avalonia.FuncUI.Types
open LiveChartsCore.SkiaSharpView
open LiveChartsCore.SkiaSharpView.Avalonia


[<AutoOpen>]
module CartesianChart =

    let create (attrs: IAttr<CartesianChart> list): IView<CartesianChart> =
        ViewBuilder.Create<CartesianChart>(attrs)

    type CartesianChart with
        static member stepLinePlot<'T when 'T :> CartesianChart> (value: StepLineSeries<_>) : IAttr<'T> =
            AttrBuilder<'T>.CreateProperty<StepLineSeries<_>>(CartesianChart.content, value, ValueNone)

    let plotFromData (values: _ list) =
        let series = StepLineSeries<_>()
        series.Values <- values
        series
