using System.IO.Compression;

namespace ReadingFiles
{
    public class DirectoryMonitor
    {
        private string? monitorPath;
        private string? logFilePath;
        public DirectoryMonitor(string? path, string? logPath)
        {
            monitorPath = path;
            logFilePath = logPath;

            if(monitorPath == null)
                return;
            FileSystemWatcher watcher = new(monitorPath);
            watcher.NotifyFilter = NotifyFilters.LastAccess | 
                NotifyFilters.LastWrite |
                NotifyFilters.FileName |
                NotifyFilters.DirectoryName;

            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnRenamed; 

            watcher.EnableRaisingEvents = true; 
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            LogChange($"{e.ChangeType} File: {e.FullPath}");
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            LogChange($"Renamed file: {e.FullPath}");
        }

        private void LogChange(string message)
        {
            if(logFilePath == null)
                return;
            try
            {
                using(StreamWriter sw = new(logFilePath, true))
                {
                    sw.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch(Exception)
            {
                return;
            }
        }

        public void CompressLogFile(string outputFilePath)
        {   
            if(logFilePath == null)
                return; 
            try 
            {
                using(FileStream originalFileStream = File.OpenRead(logFilePath))
                using(FileStream compressFileStream = File.Create(outputFilePath))
                using(GZipStream compressionStream = new(compressionStream, CompressionMode.Compress))
                {
                    originalFileStream.CopyTo(compressionStream);
                }
            }
            catch(Exception)
            {

            }
        }

        public void DecompressLogFile(string inputFilePath, string outputFilePath)
        {
            try
            {
                using(FileStream originalFileStream = File.OpenRead(inputFilePath))
                using(FileStream decompressedFileStream = File.Create(outputFilePath))
                using(GZipStream decompressionStream = new(originalFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
            catch(Exception)
            {

            }
        }
    }
}