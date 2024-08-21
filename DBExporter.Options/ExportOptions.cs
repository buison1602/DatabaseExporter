using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExporter.Options
{
    // Đối tượng thể hiện cho file dùng để ghi dữ liệu từ database

    public class ExportOptions
    {
        public ExportFormats ExportFormats { get; set; } = ExportFormats.Csv;
        public string FileName { get; set; } = "export";    // Nếu không đặt đường dẫn thì là "export" và
                                                            // được đặt ở dbexporter\DBExporter\bin\Debug\net8.0
        public bool ZipCompressed { get; set; } = false;
        public bool AppendExportTimeToFileName { get; set; } = false;
    }
}
