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
public partial class MauiCodePolyline : MauiCodeShape
{
    public MauiCodePolyline(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("Points", "Microsoft.Maui.Controls.PointCollection", false);
        RegisterProperty("FillRule", "Microsoft.Maui.Controls.Shapes.FillRule", true);
    }
}