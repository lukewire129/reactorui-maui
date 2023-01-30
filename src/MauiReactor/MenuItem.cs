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
namespace MauiReactor
{
    public partial interface IMenuItem : IBaseMenuItem
    {
        PropertyValue<bool>? IsDestructive { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IconImageSource { get; set; }

        PropertyValue<string>? Text { get; set; }

        Action? ClickedAction { get; set; }

        Action<object?, EventArgs>? ClickedActionWithArgs { get; set; }
    }

    public partial class MenuItem<T> : BaseMenuItem<T>, IMenuItem where T : Microsoft.Maui.Controls.MenuItem, new()
    {
        public MenuItem()
        {
        }

        public MenuItem(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<bool>? IMenuItem.IsDestructive { get; set; }

        PropertyValue<Microsoft.Maui.Controls.ImageSource>? IMenuItem.IconImageSource { get; set; }

        PropertyValue<string>? IMenuItem.Text { get; set; }

        Action? IMenuItem.ClickedAction { get; set; }

        Action<object?, EventArgs>? IMenuItem.ClickedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIMenuItem = (IMenuItem)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty, thisAsIMenuItem.IsDestructive);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty, thisAsIMenuItem.IconImageSource);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.MenuItem.TextProperty, thisAsIMenuItem.Text);
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
        partial void OnAttachingNativeEvents();
        partial void OnDetachingNativeEvents();
        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIMenuItem = (IMenuItem)this;
            if (thisAsIMenuItem.ClickedAction != null || thisAsIMenuItem.ClickedActionWithArgs != null)
            {
                NativeControl.Clicked += NativeControl_Clicked;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_Clicked(object? sender, EventArgs e)
        {
            var thisAsIMenuItem = (IMenuItem)this;
            thisAsIMenuItem.ClickedAction?.Invoke();
            thisAsIMenuItem.ClickedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Clicked -= NativeControl_Clicked;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class MenuItem : MenuItem<Microsoft.Maui.Controls.MenuItem>
    {
        public MenuItem()
        {
        }

        public MenuItem(Action<Microsoft.Maui.Controls.MenuItem?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class MenuItemExtensions
    {
        public static T IsDestructive<T>(this T menuItem, bool isDestructive)
            where T : IMenuItem
        {
            menuItem.IsDestructive = new PropertyValue<bool>(isDestructive);
            return menuItem;
        }

        public static T IsDestructive<T>(this T menuItem, Func<bool> isDestructiveFunc)
            where T : IMenuItem
        {
            menuItem.IsDestructive = new PropertyValue<bool>(isDestructiveFunc);
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(iconImageSource);
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Func<Microsoft.Maui.Controls.ImageSource> iconImageSourceFunc)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(iconImageSourceFunc);
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, string file)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromFile(file));
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Func<string> action)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action()));
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, string resourceName, Assembly sourceAssembly)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly));
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Uri imageUri)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromUri(imageUri));
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(new UriImageSource{Uri = imageUri, CachingEnabled = cachingEnabled, CacheValidity = cacheValidity});
            return menuItem;
        }

        public static T IconImageSource<T>(this T menuItem, Func<Stream> imageStream)
            where T : IMenuItem
        {
            menuItem.IconImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(Microsoft.Maui.Controls.ImageSource.FromStream(imageStream));
            return menuItem;
        }

        public static T Text<T>(this T menuItem, string text)
            where T : IMenuItem
        {
            menuItem.Text = new PropertyValue<string>(text);
            return menuItem;
        }

        public static T Text<T>(this T menuItem, Func<string> textFunc)
            where T : IMenuItem
        {
            menuItem.Text = new PropertyValue<string>(textFunc);
            return menuItem;
        }

        public static T OnClicked<T>(this T menuItem, Action? clickedAction)
            where T : IMenuItem
        {
            menuItem.ClickedAction = clickedAction;
            return menuItem;
        }

        public static T OnClicked<T>(this T menuItem, Action<object?, EventArgs>? clickedActionWithArgs)
            where T : IMenuItem
        {
            menuItem.ClickedActionWithArgs = clickedActionWithArgs;
            return menuItem;
        }
    }
}