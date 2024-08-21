namespace DBExporter.DatabaseWriter.Abstractions
{
    public interface IDataWriterFactory 
    // Mỗi 1 factory để tạo ra 1 định dạng file(DataWriter) sẽ phải implement interface này 
    {
        IDataWriter GetDataWriter();
    }
}
