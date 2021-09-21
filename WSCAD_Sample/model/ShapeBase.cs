using JsonSubTypes;
using MapWinGIS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSCAD_Sample.model
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(Line), "line")]
    [JsonSubtypes.KnownSubType(typeof(Circle), "circle")]
    [JsonSubtypes.KnownSubType(typeof(Triangle), "triangle")]
    public abstract class ShapeBase
    {

        protected static UInt32 TRANSPARENT = (UInt32)System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(255, 255, 255, 255));
        public virtual string type { get; }
        public string color { get; set; }

        public abstract Shapefile drawShape();

        public abstract void applyDecoration(Shapefile sf);


        protected UInt32 prepareColor()
        {
            string[] colorVals = this.color.Split(';');
            //ARGB
            var result = (UInt32)(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(Int32.Parse(colorVals[0]), Int32.Parse(colorVals[1]), Int32.Parse(colorVals[2]), Int32.Parse(colorVals[3]))));
            return result;
        }
    }
}
