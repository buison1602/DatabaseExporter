using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExporter.Options
{
    // Dùng đối tượng DatabaseExportOptions trong trường hợp: sau khi thu thập thông tin thì trả ra DatabaseExportOptions
    // vì nó chứa cả 2 thằng DatabaseOptions và ExportOptions
    public class DatabaseExportOptions
    {
        public DatabaseOptions DatabaseOptions { get; set; } = new();
        public ExportOptions ExportOptions { get; set; } = new();
    }
}
