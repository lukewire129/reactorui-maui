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
public partial class MauiCodeGrid : MauiCodeLayout
{
    public MauiCodeGrid(XElement xamlElement) : base(xamlElement)
    {
        RegisterProperty("RowSpacing", "double", false);
        RegisterProperty("ColumnSpacing", "double", false);
    }
}