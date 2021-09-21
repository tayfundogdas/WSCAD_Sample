using MapWinGIS;
using System;

namespace WSCAD_Sample.model
{
    public class Triangle : ShapeBase
    {
        public override string type { get; } = "triangle";
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }

        public bool? filled { get; set; }

        public override Shapefile drawShape()
        {
            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POLYGON);

            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYGON);
            shp.ImportFromWKT(this.prepareWKT());
            int index = 0;
            sf.EditInsertShape(shp, ref index);

            this.applyDecoration(sf);

            return sf;
        }

        private string prepareWKT()
        {
            //"POLYGON ((-15 -20, 15 -20.3, 0 21))"
            //seperator
            var x = this.a.Replace(';', ' ');
            var y = this.b.Replace(';', ' ');
            var z = this.c.Replace(';', ' ');
            //decimal
            x = x.Replace(',', '.');
            y = y.Replace(',', '.');
            z = z.Replace(',', '.');
            var xyz = x + ',' + y + ',' + z;
            var wkt = string.Format("POLYGON (({0}))", xyz);

            return wkt;
        }

        public override void applyDecoration(Shapefile sf)
        {
            var ct = sf.Categories.Add("Triangle");
            if (filled.Value)
            {
                ct.DrawingOptions.FillColor = base.prepareColor();
            }
            else
            {
                ct.DrawingOptions.FillColor = TRANSPARENT;
            }
            sf.set_ShapeCategory(0, 0);
        }
    }
}
