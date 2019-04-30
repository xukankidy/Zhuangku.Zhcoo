using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhuangku.DevTool.EntityBuilder.Model
{
    public class FieldModel
    {
        public string AccessType { get; set; }

        public string DataType { get; set; }

        public string FieldName { get; set; }

        public string Comment { get; set; }

        public bool AllowNulll { get; set; }
    }
}
