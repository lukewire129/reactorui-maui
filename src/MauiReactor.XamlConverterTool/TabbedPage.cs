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
public partial class MauiCodeTabbedPage : MauiCodeMultiPage
{
    public MauiCodeTabbedPage(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("BarBackgroundColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("BarBackground", "Microsoft.Maui.Controls.Brush", false);
        RegisterProperty("BarTextColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("UnselectedTabColor", "Microsoft.Maui.Graphics.Color", false);
        RegisterProperty("SelectedTabColor", "Microsoft.Maui.Graphics.Color", false);
    }
}