﻿using MVCGrid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCGrid.Models
{
    public class TemplateModel
    {
        public TemplateModel()
        {
        }

        public string Value { get; set; }

        public IMVCGridColumn GridColumn { get; set; }
        public dynamic Item { get; set; }
        public GridContext GridContext { get; set; }
        public Row Row { get; set; }
    }
}
