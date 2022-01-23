using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor.Shapes
{
    public partial interface IRoundRectangle : Shapes.IShape
    {
        PropertyValue<Microsoft.Maui.CornerRadius>? CornerRadius { get; set; }


    }
    public sealed partial class RoundRectangle : Shapes.Shape<Microsoft.Maui.Controls.Shapes.RoundRectangle>, IRoundRectangle
    {
        public RoundRectangle()
        {

        }

        public RoundRectangle(Action<Microsoft.Maui.Controls.Shapes.RoundRectangle?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.CornerRadius>? IRoundRectangle.CornerRadius { get; set; }


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


    }


    public static partial class RoundRectangleExtensions
    {
        public static T CornerRadius<T>(this T roundRectangle, Microsoft.Maui.CornerRadius cornerRadius) where T : IRoundRectangle
        {
            roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(cornerRadius);
            return roundRectangle;
        }

        public static T CornerRadius<T>(this T roundRectangle, Func<Microsoft.Maui.CornerRadius> cornerRadiusFunc) where T : IRoundRectangle
        {
            roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(cornerRadiusFunc);
            return roundRectangle;
        }


        public static T CornerRadius<T>(this T roundRectangle, double uniformRadius) where T : IRoundRectangle
        {
            roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(new CornerRadius(uniformRadius));
            return roundRectangle;
        }
        public static T CornerRadius<T>(this T roundRectangle, double topLeft, double topRight, double bottomLeft, double bottomRight) where T : IRoundRectangle
        {
            roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(new CornerRadius(topLeft, topRight, bottomLeft, bottomRight));
            return roundRectangle;
        }


    }
}