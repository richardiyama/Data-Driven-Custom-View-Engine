using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Core
{
    public class DataForm
    {
        string _template;

        public int Id { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [AllowHtml]
        public string Template
        {
            get
            {
                return HttpUtility.HtmlDecode(_template);
            }

            set
            {
                string sanitized = HttpUtility.HtmlEncode(value);
                _template = sanitized;
            }
        }

        public List<DataField> Fields { get; set; }

        public string SubmitUrl { get; set; }
        public string SubmitName { get; set; }
    }
}