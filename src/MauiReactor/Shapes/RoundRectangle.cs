// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor.Shapes;
public partial interface IRoundRectangle : Shapes.IShape
{
    object? CornerRadius { get; set; }
}

public sealed partial class RoundRectangle : Shapes.Shape<Microsoft.Maui.Controls.Shapes.RoundRectangle>, IRoundRectangle
{
    public RoundRectangle()
    {
        RoundRectangleStyles.Default?.Invoke(this);
    }

    public RoundRectangle(Action<Microsoft.Maui.Controls.Shapes.RoundRectangle?> componentRefAction) : base(componentRefAction)
    {
        RoundRectangleStyles.Default?.Invoke(this);
    }

    object? IRoundRectangle.CornerRadius { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIRoundRectangle = (IRoundRectangle)this;
        thisAsIRoundRectangle.CornerRadius = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIRoundRectangle = (IRoundRectangle)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, thisAsIRoundRectangle.CornerRadius);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && RoundRectangleStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class RoundRectangleExtensions
{
    static object? SetCornerRadius(object roundRectangle, RxAnimation animation) => ((IRoundRectangle)roundRectangle).CornerRadius = ((RxCornerRadiusAnimation)animation).CurrentValue();
    public static T CornerRadius<T>(this T roundRectangle, Microsoft.Maui.CornerRadius cornerRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = cornerRadius;
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(cornerRadius), SetCornerRadius);
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, Func<Microsoft.Maui.CornerRadius> cornerRadiusFunc)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(cornerRadiusFunc);
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, double uniformRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new CornerRadius(uniformRadius);
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(uniformRadius)), SetCornerRadius);
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, double topLeft, double topRight, double bottomLeft, double bottomRight, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new CornerRadius(topLeft, topRight, bottomLeft, bottomRight);
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(topLeft, topRight, bottomLeft, bottomRight)), SetCornerRadius);
        return roundRectangle;
    }
}

public static partial class RoundRectangleStyles
{
    public static Action<IRoundRectangle>? Default { get; set; }
    public static Dictionary<string, Action<IRoundRectangle>> Themes { get; } = [];
}