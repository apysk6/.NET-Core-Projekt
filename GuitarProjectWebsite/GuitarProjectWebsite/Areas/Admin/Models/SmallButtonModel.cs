using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProjectWebsite.Areas.Admin.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? CategoryId { get; set; }
        public int? GuitarId { get; set; }
        public int? ProducerId { get; set; }
        public string UserId { get; set; }
        public string Tooltip
        {
            get
            {
                switch (ButtonType)
                {
                    case "btn-primary":
                        return "Edit";

                    case "btn-danger":
                        return "Delete";

                    case "btn-success":
                        return "Details";
                }

                return string.Empty;
            }
        }

        public string ActionParameters
        {
            get
            {
                var param = new StringBuilder("/");

                if (CategoryId != null && CategoryId >= 0)
                    param.Append(CategoryId);

                if (GuitarId != null && GuitarId >= 0)
                    param.Append(GuitarId);

                if (ProducerId != null && ProducerId >= 0)
                    param.Append(ProducerId);

                if (UserId != null && !UserId.Equals(string.Empty))
                    param.Append(UserId);

                return param.ToString();
            }
        }
    }
}


