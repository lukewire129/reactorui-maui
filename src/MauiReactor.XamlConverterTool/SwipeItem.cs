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

namespace MauiReactor.XamlConverterTool;
public partial class MauiCodeSwipeItem : MauiCodeMenuItem
{
    public MauiCodeSwipeItem(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("BackgroundColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("IsVisible", "bool", false);
    }
}