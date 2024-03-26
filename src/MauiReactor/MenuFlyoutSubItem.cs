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
public partial interface IMenuFlyoutSubItem : IMenuFlyoutItem
{
}

public partial class MenuFlyoutSubItem<T> : MenuFlyoutItem<T>, IMenuFlyoutSubItem where T : Microsoft.Maui.Controls.MenuFlyoutSubItem, new()
{
    public MenuFlyoutSubItem()
    {
        MenuFlyoutSubItemStyles.Default?.Invoke(this);
    }

    public MenuFlyoutSubItem(Action<T?> componentRefAction) : base(componentRefAction)
    {
        MenuFlyoutSubItemStyles.Default?.Invoke(this);
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
        if (ThemeKey != null && MenuFlyoutSubItemStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class MenuFlyoutSubItem : MenuFlyoutSubItem<Microsoft.Maui.Controls.MenuFlyoutSubItem>
{
    public MenuFlyoutSubItem()
    {
    }

    public MenuFlyoutSubItem(Action<Microsoft.Maui.Controls.MenuFlyoutSubItem?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class MenuFlyoutSubItemExtensions
{
}

public static partial class MenuFlyoutSubItemStyles
{
    public static Action<IMenuFlyoutSubItem>? Default { get; set; }
    public static Dictionary<string, Action<IMenuFlyoutSubItem>> Themes { get; } = [];
}