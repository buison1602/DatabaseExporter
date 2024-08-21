# DatabaseExporter

Để chạy Debug
  + Vào phần Properties của phần DBExporter
  + Vào phần Debug/General mở Open debug launch profile UI
  + Nhập  "Server=BUISON; DATABASE=HR; Trusted_Connection=True; TrustServerCertificate=True" -q:"SELECT * FROM countries" -f:D:\Work_C#\testDBExport123HAHAHA -server:SqlServer -format:csv 
