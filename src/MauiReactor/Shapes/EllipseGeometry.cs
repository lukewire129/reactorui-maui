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
    public partial interface IEllipseGeometry : Shapes.IGeometry
    {
        PropertyValue<Microsoft.Maui.Graphics.Point>? Center { get; set; }
        PropertyValue<double>? RadiusX { get; set; }
        PropertyValue<double>? RadiusY { get; set; }


    }
    public partial class EllipseGeometry<T> : Shapes.Geometry<T>, IEllipseGeometry where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry, new()
    {
        public EllipseGeometry()
        {

        }

        public EllipseGeometry(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Graphics.Point>? IEllipseGeometry.Center { get; set; }
        PropertyValue<double>? IEllipseGeometry.RadiusX { get; set; }
        PropertyValue<double>? IEllipseGeometry.RadiusY { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIEllipseGeometry = (IEllipseGeometry)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty, thisAsIEllipseGeometry.Center);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, thisAsIEllipseGeometry.RadiusX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, thisAsIEllipseGeometry.RadiusY);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIEllipseGeometry = (IEllipseGeometry)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, thisAsIEllipseGeometry.RadiusX);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, thisAsIEllipseGeometry.RadiusY);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class EllipseGeometry : EllipseGeometry<Microsoft.Maui.Controls.Shapes.EllipseGeometry>
    {
        public EllipseGeometry()
        {

        }

        public EllipseGeometry(Action<Microsoft.Maui.Controls.Shapes.EllipseGeometry?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class EllipseGeometryExtensions
    {
        public static T Center<T>(this T ellipseGeometry, Microsoft.Maui.Graphics.Point center) where T : IEllipseGeometry
        {
            ellipseGeometry.Center = new PropertyValue<Microsoft.Maui.Graphics.Point>(center);
            return ellipseGeometry;
        }

        public static T Center<T>(this T ellipseGeometry, Func<Microsoft.Maui.Graphics.Point> centerFunc) where T : IEllipseGeometry
        {
            ellipseGeometry.Center = new PropertyValue<Microsoft.Maui.Graphics.Point>(centerFunc);
            return ellipseGeometry;
        }
        public static T Center<T>(this T ellipseGeometry, double x, double y) where T : IEllipseGeometry
        {
            ellipseGeometry.Center = new PropertyValue<Microsoft.Maui.Graphics.Point>(new Microsoft.Maui.Graphics.Point(x, y));
            return ellipseGeometry;
        }



        public static T RadiusX<T>(this T ellipseGeometry, double radiusX, RxDoubleAnimation? customAnimation = null) where T : IEllipseGeometry
        {
            ellipseGeometry.RadiusX = new PropertyValue<double>(radiusX);
            ellipseGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, customAnimation ?? new RxDoubleAnimation(radiusX), v => ellipseGeometry.RadiusX = new PropertyValue<double>(v.CurrentValue()));
            return ellipseGeometry;
        }

        public static T RadiusX<T>(this T ellipseGeometry, Func<double> radiusXFunc) where T : IEllipseGeometry
        {
            ellipseGeometry.RadiusX = new PropertyValue<double>(radiusXFunc);
            return ellipseGeometry;
        }



        public static T RadiusY<T>(this T ellipseGeometry, double radiusY, RxDoubleAnimation? customAnimation = null) where T : IEllipseGeometry
        {
            ellipseGeometry.RadiusY = new PropertyValue<double>(radiusY);
            ellipseGeometry.AppendAnimatable(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, customAnimation ?? new RxDoubleAnimation(radiusY), v => ellipseGeometry.RadiusY = new PropertyValue<double>(v.CurrentValue()));
            return ellipseGeometry;
        }

        public static T RadiusY<T>(this T ellipseGeometry, Func<double> radiusYFunc) where T : IEllipseGeometry
        {
            ellipseGeometry.RadiusY = new PropertyValue<double>(radiusYFunc);
            return ellipseGeometry;
        }




    }
}