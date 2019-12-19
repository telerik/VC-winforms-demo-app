namespace Presentation.Common
{
    public class AccessTypeEventArgs : IAccessTypeEventArgs
    {
        public enum AccessType
        {
            Read,
            Add,
            Update,
            Delete
        }

        public bool ValuesWereChanged { get; set; }

        public AccessType AccessTypeValue { get; set; }
    }
}
