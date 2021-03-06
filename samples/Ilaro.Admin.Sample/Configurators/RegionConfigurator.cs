﻿using Ilaro.Admin.Core;
using Ilaro.Admin.Core.Customization;
using Ilaro.Admin.Sample.Models.Northwind;

namespace Ilaro.Admin.Sample.Configurators
{
    public class RegionConfigurator : EntityConfiguration<Region>
    {
        public RegionConfigurator()
        {
            Table("Region");

            Property(x => x.RegionDescription, x =>
            {
                x.Required();
                x.StringLength(50);
                x.Template(editor: Templates.Editor.TextArea);
            });

            Property(x => x.Territories, x => x.Cascade(CascadeOption.Delete));
        }
    }
}