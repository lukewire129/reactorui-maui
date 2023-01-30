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
    public partial interface IEntryCell : ICell
    {
        PropertyValue<string>? Text { get; set; }

        PropertyValue<string>? Label { get; set; }

        PropertyValue<string>? Placeholder { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? LabelColor { get; set; }

        PropertyValue<Microsoft.Maui.Keyboard>? Keyboard { get; set; }

        PropertyValue<Microsoft.Maui.TextAlignment>? HorizontalTextAlignment { get; set; }

        PropertyValue<Microsoft.Maui.TextAlignment>? VerticalTextAlignment { get; set; }

        Action? CompletedAction { get; set; }

        Action<object?, EventArgs>? CompletedActionWithArgs { get; set; }
    }

    public partial class EntryCell<T> : Cell<T>, IEntryCell where T : Microsoft.Maui.Controls.EntryCell, new()
    {
        public EntryCell()
        {
        }

        public EntryCell(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<string>? IEntryCell.Text { get; set; }

        PropertyValue<string>? IEntryCell.Label { get; set; }

        PropertyValue<string>? IEntryCell.Placeholder { get; set; }

        PropertyValue<Microsoft.Maui.Graphics.Color>? IEntryCell.LabelColor { get; set; }

        PropertyValue<Microsoft.Maui.Keyboard>? IEntryCell.Keyboard { get; set; }

        PropertyValue<Microsoft.Maui.TextAlignment>? IEntryCell.HorizontalTextAlignment { get; set; }

        PropertyValue<Microsoft.Maui.TextAlignment>? IEntryCell.VerticalTextAlignment { get; set; }

        Action? IEntryCell.CompletedAction { get; set; }

        Action<object?, EventArgs>? IEntryCell.CompletedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIEntryCell = (IEntryCell)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.TextProperty, thisAsIEntryCell.Text);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.LabelProperty, thisAsIEntryCell.Label);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.PlaceholderProperty, thisAsIEntryCell.Placeholder);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.LabelColorProperty, thisAsIEntryCell.LabelColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.KeyboardProperty, thisAsIEntryCell.Keyboard);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.HorizontalTextAlignmentProperty, thisAsIEntryCell.HorizontalTextAlignment);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.EntryCell.VerticalTextAlignmentProperty, thisAsIEntryCell.VerticalTextAlignment);
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
            var thisAsIEntryCell = (IEntryCell)this;
            if (thisAsIEntryCell.CompletedAction != null || thisAsIEntryCell.CompletedActionWithArgs != null)
            {
                NativeControl.Completed += NativeControl_Completed;
            }

            OnAttachingNativeEvents();
            base.OnAttachNativeEvents();
        }

        private void NativeControl_Completed(object? sender, EventArgs e)
        {
            var thisAsIEntryCell = (IEntryCell)this;
            thisAsIEntryCell.CompletedAction?.Invoke();
            thisAsIEntryCell.CompletedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.Completed -= NativeControl_Completed;
            }

            OnDetachingNativeEvents();
            base.OnDetachNativeEvents();
        }
    }

    public partial class EntryCell : EntryCell<Microsoft.Maui.Controls.EntryCell>
    {
        public EntryCell()
        {
        }

        public EntryCell(Action<Microsoft.Maui.Controls.EntryCell?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class EntryCellExtensions
    {
        public static T Text<T>(this T entryCell, string text)
            where T : IEntryCell
        {
            entryCell.Text = new PropertyValue<string>(text);
            return entryCell;
        }

        public static T Text<T>(this T entryCell, Func<string> textFunc)
            where T : IEntryCell
        {
            entryCell.Text = new PropertyValue<string>(textFunc);
            return entryCell;
        }

        public static T Label<T>(this T entryCell, string label)
            where T : IEntryCell
        {
            entryCell.Label = new PropertyValue<string>(label);
            return entryCell;
        }

        public static T Label<T>(this T entryCell, Func<string> labelFunc)
            where T : IEntryCell
        {
            entryCell.Label = new PropertyValue<string>(labelFunc);
            return entryCell;
        }

        public static T Placeholder<T>(this T entryCell, string placeholder)
            where T : IEntryCell
        {
            entryCell.Placeholder = new PropertyValue<string>(placeholder);
            return entryCell;
        }

        public static T Placeholder<T>(this T entryCell, Func<string> placeholderFunc)
            where T : IEntryCell
        {
            entryCell.Placeholder = new PropertyValue<string>(placeholderFunc);
            return entryCell;
        }

        public static T LabelColor<T>(this T entryCell, Microsoft.Maui.Graphics.Color labelColor)
            where T : IEntryCell
        {
            entryCell.LabelColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(labelColor);
            return entryCell;
        }

        public static T LabelColor<T>(this T entryCell, Func<Microsoft.Maui.Graphics.Color> labelColorFunc)
            where T : IEntryCell
        {
            entryCell.LabelColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(labelColorFunc);
            return entryCell;
        }

        public static T Keyboard<T>(this T entryCell, Microsoft.Maui.Keyboard keyboard)
            where T : IEntryCell
        {
            entryCell.Keyboard = new PropertyValue<Microsoft.Maui.Keyboard>(keyboard);
            return entryCell;
        }

        public static T Keyboard<T>(this T entryCell, Func<Microsoft.Maui.Keyboard> keyboardFunc)
            where T : IEntryCell
        {
            entryCell.Keyboard = new PropertyValue<Microsoft.Maui.Keyboard>(keyboardFunc);
            return entryCell;
        }

        public static T HorizontalTextAlignment<T>(this T entryCell, Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : IEntryCell
        {
            entryCell.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignment);
            return entryCell;
        }

        public static T HorizontalTextAlignment<T>(this T entryCell, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc)
            where T : IEntryCell
        {
            entryCell.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
            return entryCell;
        }

        public static T VerticalTextAlignment<T>(this T entryCell, Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : IEntryCell
        {
            entryCell.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignment);
            return entryCell;
        }

        public static T VerticalTextAlignment<T>(this T entryCell, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc)
            where T : IEntryCell
        {
            entryCell.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
            return entryCell;
        }

        public static T OnCompleted<T>(this T entryCell, Action? completedAction)
            where T : IEntryCell
        {
            entryCell.CompletedAction = completedAction;
            return entryCell;
        }

        public static T OnCompleted<T>(this T entryCell, Action<object?, EventArgs>? completedActionWithArgs)
            where T : IEntryCell
        {
            entryCell.CompletedActionWithArgs = completedActionWithArgs;
            return entryCell;
        }
    }
}