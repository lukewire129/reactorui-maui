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
public partial interface ITemplatedView : Compatibility.ILayout
{
}

public partial class TemplatedView<T> : Compatibility.Layout<T>, ITemplatedView where T : Microsoft.Maui.Controls.TemplatedView, new()
{
    public TemplatedView()
    {
        TemplatedViewStyles.Default?.Invoke(this);
    }

    public TemplatedView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        TemplatedViewStyles.Default?.Invoke(this);
    }

    internal override void Reset()
    {
        base.Reset();
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && TemplatedViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class TemplatedView : TemplatedView<Microsoft.Maui.Controls.TemplatedView>
{
    public TemplatedView()
    {
    }

    public TemplatedView(Action<Microsoft.Maui.Controls.TemplatedView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class TemplatedViewExtensions
{
}

public static partial class TemplatedViewStyles
{
    public static Action<ITemplatedView>? Default { get; set; }
    public static Dictionary<string, Action<ITemplatedView>> Themes { get; } = [];
}