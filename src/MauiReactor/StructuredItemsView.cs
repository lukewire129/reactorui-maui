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
    public partial interface IStructuredItemsView : IItemsView
    {
        PropertyValue<Microsoft.Maui.Controls.ItemSizingStrategy>? ItemSizingStrategy { get; set; }
    }

    public partial class StructuredItemsView<T> : ItemsView<T>, IStructuredItemsView where T : Microsoft.Maui.Controls.StructuredItemsView, new()
    {
        public StructuredItemsView()
        {
        }

        public StructuredItemsView(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<Microsoft.Maui.Controls.ItemSizingStrategy>? IStructuredItemsView.ItemSizingStrategy { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIStructuredItemsView = (IStructuredItemsView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.StructuredItemsView.ItemSizingStrategyProperty, thisAsIStructuredItemsView.ItemSizingStrategy);
            base.OnUpdate();
            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
    }

    public partial class StructuredItemsView : StructuredItemsView<Microsoft.Maui.Controls.StructuredItemsView>
    {
        public StructuredItemsView()
        {
        }

        public StructuredItemsView(Action<Microsoft.Maui.Controls.StructuredItemsView?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class StructuredItemsViewExtensions
    {
        public static T ItemSizingStrategy<T>(this T structuredItemsView, Microsoft.Maui.Controls.ItemSizingStrategy itemSizingStrategy)
            where T : IStructuredItemsView
        {
            structuredItemsView.ItemSizingStrategy = new PropertyValue<Microsoft.Maui.Controls.ItemSizingStrategy>(itemSizingStrategy);
            return structuredItemsView;
        }

        public static T ItemSizingStrategy<T>(this T structuredItemsView, Func<Microsoft.Maui.Controls.ItemSizingStrategy> itemSizingStrategyFunc)
            where T : IStructuredItemsView
        {
            structuredItemsView.ItemSizingStrategy = new PropertyValue<Microsoft.Maui.Controls.ItemSizingStrategy>(itemSizingStrategyFunc);
            return structuredItemsView;
        }
    }
}