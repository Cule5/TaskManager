using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Domain
{
    public abstract class ValueObject<T>
        where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            return obj is T valueObject && EqualsCore(valueObject);
        }

        protected virtual bool EqualsCore(T other)
        {
            using (var otherEnumerator = other.GetProperties().GetEnumerator())
            using (var enumerator = GetProperties().GetEnumerator())
                while (otherEnumerator.MoveNext() && enumerator.MoveNext())
                {
                    if (otherEnumerator.Current != null && !otherEnumerator.Current.Equals(enumerator.Current))
                        return false;
                }

            return true;
        }

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        protected virtual int GetHashCodeCore()
        {
            var properties = GetProperties();

            return properties.Aggregate(0, (current, prop) => (current * 397) ^ prop.GetHashCode());
        }

        public static bool operator ==(ValueObject<T> a, ValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
        {
            return !(a == b);
        }

        protected abstract IEnumerable<object> GetProperties();

    }
}
