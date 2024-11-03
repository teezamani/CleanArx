using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArx.Core.Options
{
    public class AppSettings
    {
        public const string SectionName = "Appsettings";
        public string DefaultConnection { get; set; } = null!;
        public string Test { get; set; } = null!;
    }
}
