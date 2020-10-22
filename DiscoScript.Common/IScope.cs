namespace DiscoScript.Common
{
    public interface IScope <out TReturn, in TValue>
    {
        ScopeKind Kind { get; }
        TReturn DeclareVariable(string name);
        TReturn AssignVariable(string name, TValue value);
        TReturn FindVariable(string name);
        TReturn GetProperty(string name);
        TReturn SetProperty(string name, TValue value);
    }

    
}