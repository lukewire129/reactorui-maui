// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MauiReactor.XamlConverterTool.Shapes;
public partial class MauiCodeEllipseGeometry : MauiCodeGeometry
{
    public MauiCodeEllipseGeometry(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("Center", "Microsoft.Maui.Graphics.Point", false);
        RegisterProperty("RadiusX", "double", false);
        RegisterProperty("RadiusY", "double", false);
    }
}