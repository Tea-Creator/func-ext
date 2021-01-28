using System;

namespace FuncExt
{
    public static class CurryExtensions
    {
        #region Actions
        public static Func<T1, Action<T2>> Curry<T1, T2>(this Action<T1, T2> action)
        {
            return x => y => action(x, y);
        }

        public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action)
        {
            return x => Curry<T2, T3>((y, z) => action(x, y, z));
        }

        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action)
        {
            return x => Curry<T2, T3, T4>((y, z, v) => action(x, y, z, v));
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action)
        {
            return x => Curry<T2, T3, T4, T5>((y, z, v, t) => action(x, y, z, v, t));
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action)
        {
            return x => Curry<T2, T3, T4, T5, T6>((y, z, v, t, n) => action(x, y, z, v, t, n));
        }
        #endregion

        #region Funcs
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return t1 => t2 => func(t1, t2);
        }

        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func)
        {
            return t1 => Curry<T2, T3, TResult>((t2, t3) => func(t1, t2, t3));
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func)
        {
            return t1 => Curry<T2, T3, T4, TResult>((t2, t3, t4) => func(t1, t2, t3, t4));
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func)
        {
            return t1 => Curry<T2, T3, T4, T5, TResult>((t2, t3, t4, t5) => func(t1, t2, t3, t4, t5));
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return t1 => Curry<T2, T3, T4, T5, T6, TResult>((t2, t3, t4, t5, t6) => func(t1, t2, t3, t4, t5, t6));
        }
        #endregion
    }
}
