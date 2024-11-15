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
namespace MauiReactor;
public partial interface IView : IVisualElement
{
    object? VerticalOptions { get; set; }

    object? HorizontalOptions { get; set; }

    object? Margin { get; set; }
}

public abstract partial class View<T> : VisualElement<T>, IView where T : Microsoft.Maui.Controls.View, new()
{
    protected View()
    {
        ViewStyles.Default?.Invoke(this);
    }

    protected View(Action<T?> componentRefAction) : base(componentRefAction)
    {
        ViewStyles.Default?.Invoke(this);
    }

    object? IView.VerticalOptions { get; set; }

    object? IView.HorizontalOptions { get; set; }

    object? IView.Margin { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIView = (IView)this;
        thisAsIView.VerticalOptions = null;
        thisAsIView.HorizontalOptions = null;
        thisAsIView.Margin = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIView = (IView)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.View.VerticalOptionsProperty, thisAsIView.VerticalOptions);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.View.HorizontalOptionsProperty, thisAsIView.HorizontalOptions);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.View.MarginProperty, thisAsIView.Margin);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && ViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class ViewExtensions
{
    static object? SetMargin(object view, RxAnimation animation) => ((IView)view).Margin = ((RxThicknessAnimation)animation).CurrentValue();
    public static T VerticalOptions<T>(this T view, Microsoft.Maui.Controls.LayoutOptions verticalOptions)
        where T : IView
    {
        view.VerticalOptions = verticalOptions;
        return view;
    }

    public static T VerticalOptions<T>(this T view, Func<Microsoft.Maui.Controls.LayoutOptions> verticalOptionsFunc)
        where T : IView
    {
        view.VerticalOptions = new PropertyValue<Microsoft.Maui.Controls.LayoutOptions>(verticalOptionsFunc);
        return view;
    }

    public static T HorizontalOptions<T>(this T view, Microsoft.Maui.Controls.LayoutOptions horizontalOptions)
        where T : IView
    {
        view.HorizontalOptions = horizontalOptions;
        return view;
    }

    public static T HorizontalOptions<T>(this T view, Func<Microsoft.Maui.Controls.LayoutOptions> horizontalOptionsFunc)
        where T : IView
    {
        view.HorizontalOptions = new PropertyValue<Microsoft.Maui.Controls.LayoutOptions>(horizontalOptionsFunc);
        return view;
    }

    public static T Margin<T>(this T view, Microsoft.Maui.Thickness margin, RxThicknessAnimation? customAnimation = null)
        where T : IView
    {
        view.Margin = margin;
        view.AppendAnimatable(Microsoft.Maui.Controls.View.MarginProperty, customAnimation ?? new RxSimpleThicknessAnimation(margin), SetMargin);
        return view;
    }

    public static T Margin<T>(this T view, Func<Microsoft.Maui.Thickness> marginFunc)
        where T : IView
    {
        view.Margin = new PropertyValue<Microsoft.Maui.Thickness>(marginFunc);
        return view;
    }

    public static T Margin<T>(this T view, double leftRight, double topBottom, RxThicknessAnimation? customAnimation = null)
        where T : IView
    {
        view.Margin = new Thickness(leftRight, topBottom);
        view.AppendAnimatable(Microsoft.Maui.Controls.View.MarginProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(leftRight, topBottom)), SetMargin);
        return view;
    }

    public static T Margin<T>(this T view, double uniformSize, RxThicknessAnimation? customAnimation = null)
        where T : IView
    {
        view.Margin = new Thickness(uniformSize);
        view.AppendAnimatable(Microsoft.Maui.Controls.View.MarginProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(uniformSize)), SetMargin);
        return view;
    }

    public static T Margin<T>(this T view, double left, double top, double right, double bottom, RxThicknessAnimation? customAnimation = null)
        where T : IView
    {
        view.Margin = new Thickness(left, top, right, bottom);
        view.AppendAnimatable(Microsoft.Maui.Controls.View.MarginProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(left, top, right, bottom)), SetMargin);
        return view;
    }
}

public static partial class ViewStyles
{
    public static Action<IView>? Default { get; set; }
    public static Dictionary<string, Action<IView>> Themes { get; } = [];
}