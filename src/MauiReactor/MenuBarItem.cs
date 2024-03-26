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
public partial interface IMenuBarItem : IBaseMenuItem
{
    object? Text { get; set; }

    object? IsEnabled { get; set; }
}

public partial class MenuBarItem<T> : BaseMenuItem<T>, IMenuBarItem where T : Microsoft.Maui.Controls.MenuBarItem, new()
{
    public MenuBarItem()
    {
        MenuBarItemStyles.Default?.Invoke(this);
    }

    public MenuBarItem(Action<T?> componentRefAction) : base(componentRefAction)
    {
        MenuBarItemStyles.Default?.Invoke(this);
    }

    object? IMenuBarItem.Text { get; set; }

    object? IMenuBarItem.IsEnabled { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIMenuBarItem = (IMenuBarItem)this;
        thisAsIMenuBarItem.Text = null;
        thisAsIMenuBarItem.IsEnabled = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIMenuBarItem = (IMenuBarItem)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.MenuBarItem.TextProperty, thisAsIMenuBarItem.Text);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.MenuBarItem.IsEnabledProperty, thisAsIMenuBarItem.IsEnabled);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && MenuBarItemStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class MenuBarItem : MenuBarItem<Microsoft.Maui.Controls.MenuBarItem>
{
    public MenuBarItem()
    {
    }

    public MenuBarItem(Action<Microsoft.Maui.Controls.MenuBarItem?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class MenuBarItemExtensions
{
    public static T Text<T>(this T menuBarItem, string text)
        where T : IMenuBarItem
    {
        menuBarItem.Text = text;
        return menuBarItem;
    }

    public static T Text<T>(this T menuBarItem, Func<string> textFunc)
        where T : IMenuBarItem
    {
        menuBarItem.Text = new PropertyValue<string>(textFunc);
        return menuBarItem;
    }

    public static T IsEnabled<T>(this T menuBarItem, bool isEnabled)
        where T : IMenuBarItem
    {
        menuBarItem.IsEnabled = isEnabled;
        return menuBarItem;
    }

    public static T IsEnabled<T>(this T menuBarItem, Func<bool> isEnabledFunc)
        where T : IMenuBarItem
    {
        menuBarItem.IsEnabled = new PropertyValue<bool>(isEnabledFunc);
        return menuBarItem;
    }
}

public static partial class MenuBarItemStyles
{
    public static Action<IMenuBarItem>? Default { get; set; }
    public static Dictionary<string, Action<IMenuBarItem>> Themes { get; } = [];
}