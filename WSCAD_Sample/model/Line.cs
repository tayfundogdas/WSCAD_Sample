using MapWinGIS;
using System;

namespace WSCAD_Sample.model
{
    public class Line : ShapeBase
    {
        public override string type { get; } = "line";
        public string a { get; set; }
        public string b { get; set; }

        public override Shapefile drawShape()
        {
            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POLYLINE);

            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYLINE);
            shp.ImportFromWKT(this.prepareWKT());
            int index = 0;
            sf.EditInsertShape(shp, ref index);

            this.applyDecoration(sf);

            return sf;
        }

        private string prepareWKT()
        { 
            //seperator
            var x = this.a.Replace(';', ' ');
            var y = this.b.Replace(';', ' ');
            //decimal
            x = x.Replace(',', '.');
            y = y.Replace(',', '.');
            var xy = x + ',' + y;
            var wkt = string.Format("LINESTRING ({0})", xy);

            return wkt;
        }

        public override void applyDecoration(Shapefile sf)
        {
            var utils = new Utils();
            var pattern = new LinePattern();
            var color = base.prepareColor();
            pattern.AddLine(utils.ColorByName(tkMapColor.DarkBlue), 6.0f, tkDashStyle.dsSolid);
            pattern.AddLine(color, 4.0f, tkDashStyle.dsSolid);
            var ct = sf.Categories.Add("Line");
            ct.DrawingOptions.LinePattern = pattern;
            ct.DrawingOptions.UseLinePattern = true;
            sf.set_ShapeCategory(0, 0);
        }
    }
}
