using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NewFileNotfier
{
    class FileWatcher
    {
        public string Path {get; set;}

        private string _mask;
        public string Mask
        {
            get 
            { 
                return _mask; 
            }
            set 
            {
                _mask = (string.IsNullOrWhiteSpace(value) ? "*" : value);
            }
        }

        
        private bool _running;
        public bool Running 
        { 
            get { return _running; } 
        }

        private FileSystemWatcher _fileSystemWatcher;

        public FileWatcher() 
        {
            _running = false;
        }
        public FileWatcher(string path, string mask)
        {
            Path = path;
            Mask = mask;
            _running = false;
        }
        public void Start()
        {
            _fileSystemWatcher = new FileSystemWatcher(Path, _mask);
            _fileSystemWatcher.Created += _fileSystemWatcher_FileCreated;
            _fileSystemWatcher.EnableRaisingEvents = true;

            _running = (_fileSystemWatcher != null);
        }
        public void Stop()
        {
            _running = false;
        }

        private void _fileSystemWatcher_FileCreated(object sender, FileSystemEventArgs e)
        {
            OnNewFileAdded(e);
        }

        public event FileSystemEventHandler NewFileAddedEvent;
        protected virtual void OnNewFileAdded(FileSystemEventArgs e)
        {
            var handler = NewFileAddedEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
