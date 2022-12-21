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
        public event EventHandler<OperationCompletedEventArgs> OperationCompleted;

        private Action CancelAction { get; set; }
        private Action PauseAction { get; set; }
        private Action ResumeAction { get; set; }
        private Action<ArchiveOperation> OperationStarter { get; set; }
        private object? CustomData { get; set; }

        public ArchiveOperation(ArchiveOperationType type, Action<ArchiveOperation> operationStarter, Action cancelAction, Action pauseAction, Action resumeAction)
        {
            OperationType = type;
            OperationStarter = operationStarter;
            CancelAction = cancelAction;
            PauseAction = pauseAction;
            ResumeAction = resumeAction;
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
            PauseAction?.Invoke();
        }

        public void Resume()
        {
            ResumeAction?.Invoke();
        }

        public void SetCustomData(object? data)
        {
            CustomData = data;
        }

        public void Cancel()
        {
            CancelAction?.Invoke();
            OperationCompleted?.Invoke(this, new OperationCompletedEventArgs(true, CustomData));
        }

        public void Complete()
        {
            OperationCompleted?.Invoke(this, new OperationCompletedEventArgs(false, CustomData));
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

    public class OperationCompletedEventArgs : EventArgs
    {
        public object? CustomData { get; private set; }
        public bool IsCancelled { get; private set; }

        public OperationCompletedEventArgs(bool isCancelled, object? customData)
        {
            CustomData = customData;
            IsCancelled = isCancelled;
        }
    }

    public enum ArchiveOperationType
    {
        Extraction,
        Validation,
        Adding
    }
}
