namespace WPF.Framework
{
    public interface IInfo
    {
        string Alias { get; }
        bool IsDefault { get; }
        bool CreateByDefault { get; }
    }
}
