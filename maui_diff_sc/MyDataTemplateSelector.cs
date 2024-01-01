using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_diff_sc
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public required DataTemplate PageType1Template { get; set; }
        public required DataTemplate PageType2Template { get; set; }
        public required DataTemplate PageType3Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item switch
            {
                PageType1 _ => PageType1Template,
                PageType2 _ => PageType2Template,
                PageType3 _ => PageType3Template,
                _ => throw new NotImplementedException()
            };
        }
    }
}
