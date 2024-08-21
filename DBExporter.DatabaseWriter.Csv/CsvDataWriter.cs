using CsvHelper;
using DBExporter.DatabaseObjects;
using DBExporter.DatabaseWriter.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExporter.DatabaseWriter.Csv
{
    internal class CsvDataWriter : IDataWriter
    {
        public CsvDataWriter()
        {
        }

        public void WriteData(ExportSource database, Stream stream)
        {
            // stream ở đây đại đại diện cho file muốn tạo 
            // writer(StreamWriter) đóng vai trò như cầu nối giữa chương trình và file
            // csv(CsvWriter) sử dụng writer(StreamWriter) để ghi dữ liệu vào file
            using var writer = new StreamWriter(stream);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            // Lấy ra số cột của database 
            var columns = database.Reader.GetColumnSchema();

            // Đọc từng dùng từ trên xuống của database 
            while (database.Reader.Read())
            {
                // Đọc từng cột theo hàng ngang ứng với mỗi dòng rồi ghi vào file csv
                for (int i = 0; i < columns.Count; i++)
                {
                    csv.WriteField(database.Reader[i].ToString(), true);
                }
                
                // sau khi ghi xong thì chuyển xuống dòng tiếp theo trong file csv
                csv.NextRecord();
            }

            // Flush() sẽ đẩy bất kỳ dữ liệu nào còn đệm trong đối tượng csv ra file.
            csv.Flush();
        }
    }
}
