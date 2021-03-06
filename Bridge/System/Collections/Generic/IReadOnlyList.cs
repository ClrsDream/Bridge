using Bridge;

namespace System.Collections.Generic
{
    [External]
    [Convention(Target = ConventionTarget.Member, Member = ConventionMember.Method, Notation = Notation.LowerCamelCase)]
    public interface IReadOnlyCollection<T> : IEnumerable<T>
    {
        int Count
        {
            [Template("System.Array.getCount({this}, {T})")]
            get;
        }
    }

    [External]
    [Convention(Target = ConventionTarget.Member, Member = ConventionMember.Method, Notation = Notation.LowerCamelCase)]
    public interface IReadOnlyList<T> : IReadOnlyCollection<T>
    {
        T this[int index]
        {
            [Template("System.Array.getItem({this}, {0}, {T})")]
            get;
        }
    }
}