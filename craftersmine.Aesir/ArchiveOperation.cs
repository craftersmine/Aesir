using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Aesir
{
    public class ArchiveOperation
    {
        public ArchiveOperationType OperationType { get; private set; }
        public event EventHandler<OperationProgressChangedEventArgs> OperationProgressChanged;
        public event EventHandler OperationCompleted;

        private Action CancelCallback { get; set; }
        private Action PauseCallback { get; set; }
        private Action ResumeCallback { get; set; }
        private Action<ArchiveOperation> OperationStarter { get; set; }

        public ArchiveOperation(ArchiveOperationType type, Action<ArchiveOperation> operationStarter, Action cancelCallback, Action pauseCallback, Action resumeCallback)
        {
            OperationType = type;
            OperationStarter = operationStarter;
            CancelCallback = cancelCallback;
            PauseCallback = pauseCallback;
            ResumeCallback = resumeCallback;
        }

        public void Start()
        {
            OperationStarter?.Invoke(this);
        }

        public void Update(OperationProgressChangedEventArgs args)
        {
            OperationProgressChanged?.Invoke(this, args);
        }

        public void Pause()
        {
            PauseCallback?.Invoke();
        }

        public void Resume()
        {
            ResumeCallback?.Invoke();
        }

        public void Cancel()
        {
            CancelCallback?.Invoke();
            OperationCompleted?.Invoke(this, EventArgs.Empty);
        }

        public void Complete()
        {
            OperationCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    public class OperationProgressChangedEventArgs : EventArgs
    {
        public int CurrentFile { get; private set; }
        public int TotalFiles { get; private set; }
        public string? SourceFilePath { get; private set; }
        public string? DestinationFilePath { get; private set; }

        public OperationProgressChangedEventArgs(int currentFile, int totalFiles, string? sourceFilePath, string? destinationFilePath)
        {
            CurrentFile = currentFile;
            TotalFiles = totalFiles;
            SourceFilePath = sourceFilePath;
            DestinationFilePath = destinationFilePath;
        }
    }

    public enum ArchiveOperationType
    {
        Extraction,
        Validation,
        Adding
    }
}
