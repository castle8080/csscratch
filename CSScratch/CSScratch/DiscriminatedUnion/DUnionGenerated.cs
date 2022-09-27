namespace CSScratch.DiscriminatedUnion
{

    public class DUnion<T1> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        #endregion

        public void SwitchP(Action<T1> t1Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        public DUnion(T12 t12) : base(new DUnionValue<T12>(t12)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        public bool Is(DUnionType<T12> t12) => UnionValue.IsType<T12>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        public T12 Get(DUnionType<T12> k) => UnionValue.Get<T12>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                t12Action(Get(DUnionType.Of<T12>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func, Func<T12, T> t12Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                return t12Func(Get(DUnionType.Of<T12>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        public DUnion(T12 t12) : base(new DUnionValue<T12>(t12)) { }
        public DUnion(T13 t13) : base(new DUnionValue<T13>(t13)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        public bool Is(DUnionType<T12> t12) => UnionValue.IsType<T12>();
        public bool Is(DUnionType<T13> t13) => UnionValue.IsType<T13>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        public T12 Get(DUnionType<T12> k) => UnionValue.Get<T12>();
        public T13 Get(DUnionType<T13> k) => UnionValue.Get<T13>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                t12Action(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                t13Action(Get(DUnionType.Of<T13>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func, Func<T12, T> t12Func, Func<T13, T> t13Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                return t12Func(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                return t13Func(Get(DUnionType.Of<T13>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        public DUnion(T12 t12) : base(new DUnionValue<T12>(t12)) { }
        public DUnion(T13 t13) : base(new DUnionValue<T13>(t13)) { }
        public DUnion(T14 t14) : base(new DUnionValue<T14>(t14)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        public bool Is(DUnionType<T12> t12) => UnionValue.IsType<T12>();
        public bool Is(DUnionType<T13> t13) => UnionValue.IsType<T13>();
        public bool Is(DUnionType<T14> t14) => UnionValue.IsType<T14>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        public T12 Get(DUnionType<T12> k) => UnionValue.Get<T12>();
        public T13 Get(DUnionType<T13> k) => UnionValue.Get<T13>();
        public T14 Get(DUnionType<T14> k) => UnionValue.Get<T14>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                t12Action(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                t13Action(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                t14Action(Get(DUnionType.Of<T14>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func, Func<T12, T> t12Func, Func<T13, T> t13Func, Func<T14, T> t14Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                return t12Func(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                return t13Func(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                return t14Func(Get(DUnionType.Of<T14>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        public DUnion(T12 t12) : base(new DUnionValue<T12>(t12)) { }
        public DUnion(T13 t13) : base(new DUnionValue<T13>(t13)) { }
        public DUnion(T14 t14) : base(new DUnionValue<T14>(t14)) { }
        public DUnion(T15 t15) : base(new DUnionValue<T15>(t15)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        public bool Is(DUnionType<T12> t12) => UnionValue.IsType<T12>();
        public bool Is(DUnionType<T13> t13) => UnionValue.IsType<T13>();
        public bool Is(DUnionType<T14> t14) => UnionValue.IsType<T14>();
        public bool Is(DUnionType<T15> t15) => UnionValue.IsType<T15>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        public T12 Get(DUnionType<T12> k) => UnionValue.Get<T12>();
        public T13 Get(DUnionType<T13> k) => UnionValue.Get<T13>();
        public T14 Get(DUnionType<T14> k) => UnionValue.Get<T14>();
        public T15 Get(DUnionType<T15> k) => UnionValue.Get<T15>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                t12Action(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                t13Action(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                t14Action(Get(DUnionType.Of<T14>()));
            else if (Is(DUnionType.Of<T15>()))
                t15Action(Get(DUnionType.Of<T15>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func, Func<T12, T> t12Func, Func<T13, T> t13Func, Func<T14, T> t14Func, Func<T15, T> t15Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                return t12Func(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                return t13Func(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                return t14Func(Get(DUnionType.Of<T14>()));
            else if (Is(DUnionType.Of<T15>()))
                return t15Func(Get(DUnionType.Of<T15>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }

    public class DUnion<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : DUnion
    {

        #region CTORS
        public DUnion(T1 t1) : base(new DUnionValue<T1>(t1)) { }
        public DUnion(T2 t2) : base(new DUnionValue<T2>(t2)) { }
        public DUnion(T3 t3) : base(new DUnionValue<T3>(t3)) { }
        public DUnion(T4 t4) : base(new DUnionValue<T4>(t4)) { }
        public DUnion(T5 t5) : base(new DUnionValue<T5>(t5)) { }
        public DUnion(T6 t6) : base(new DUnionValue<T6>(t6)) { }
        public DUnion(T7 t7) : base(new DUnionValue<T7>(t7)) { }
        public DUnion(T8 t8) : base(new DUnionValue<T8>(t8)) { }
        public DUnion(T9 t9) : base(new DUnionValue<T9>(t9)) { }
        public DUnion(T10 t10) : base(new DUnionValue<T10>(t10)) { }
        public DUnion(T11 t11) : base(new DUnionValue<T11>(t11)) { }
        public DUnion(T12 t12) : base(new DUnionValue<T12>(t12)) { }
        public DUnion(T13 t13) : base(new DUnionValue<T13>(t13)) { }
        public DUnion(T14 t14) : base(new DUnionValue<T14>(t14)) { }
        public DUnion(T15 t15) : base(new DUnionValue<T15>(t15)) { }
        public DUnion(T16 t16) : base(new DUnionValue<T16>(t16)) { }
        #endregion

        #region IsMethods
        public bool Is(DUnionType<T1> t1) => UnionValue.IsType<T1>();
        public bool Is(DUnionType<T2> t2) => UnionValue.IsType<T2>();
        public bool Is(DUnionType<T3> t3) => UnionValue.IsType<T3>();
        public bool Is(DUnionType<T4> t4) => UnionValue.IsType<T4>();
        public bool Is(DUnionType<T5> t5) => UnionValue.IsType<T5>();
        public bool Is(DUnionType<T6> t6) => UnionValue.IsType<T6>();
        public bool Is(DUnionType<T7> t7) => UnionValue.IsType<T7>();
        public bool Is(DUnionType<T8> t8) => UnionValue.IsType<T8>();
        public bool Is(DUnionType<T9> t9) => UnionValue.IsType<T9>();
        public bool Is(DUnionType<T10> t10) => UnionValue.IsType<T10>();
        public bool Is(DUnionType<T11> t11) => UnionValue.IsType<T11>();
        public bool Is(DUnionType<T12> t12) => UnionValue.IsType<T12>();
        public bool Is(DUnionType<T13> t13) => UnionValue.IsType<T13>();
        public bool Is(DUnionType<T14> t14) => UnionValue.IsType<T14>();
        public bool Is(DUnionType<T15> t15) => UnionValue.IsType<T15>();
        public bool Is(DUnionType<T16> t16) => UnionValue.IsType<T16>();
        #endregion

        #region GetMethods
        public T1 Get(DUnionType<T1> k) => UnionValue.Get<T1>();
        public T2 Get(DUnionType<T2> k) => UnionValue.Get<T2>();
        public T3 Get(DUnionType<T3> k) => UnionValue.Get<T3>();
        public T4 Get(DUnionType<T4> k) => UnionValue.Get<T4>();
        public T5 Get(DUnionType<T5> k) => UnionValue.Get<T5>();
        public T6 Get(DUnionType<T6> k) => UnionValue.Get<T6>();
        public T7 Get(DUnionType<T7> k) => UnionValue.Get<T7>();
        public T8 Get(DUnionType<T8> k) => UnionValue.Get<T8>();
        public T9 Get(DUnionType<T9> k) => UnionValue.Get<T9>();
        public T10 Get(DUnionType<T10> k) => UnionValue.Get<T10>();
        public T11 Get(DUnionType<T11> k) => UnionValue.Get<T11>();
        public T12 Get(DUnionType<T12> k) => UnionValue.Get<T12>();
        public T13 Get(DUnionType<T13> k) => UnionValue.Get<T13>();
        public T14 Get(DUnionType<T14> k) => UnionValue.Get<T14>();
        public T15 Get(DUnionType<T15> k) => UnionValue.Get<T15>();
        public T16 Get(DUnionType<T16> k) => UnionValue.Get<T16>();
        #endregion

        public void SwitchP(Action<T1> t1Action, Action<T2> t2Action, Action<T3> t3Action, Action<T4> t4Action, Action<T5> t5Action, Action<T6> t6Action, Action<T7> t7Action, Action<T8> t8Action, Action<T9> t9Action, Action<T10> t10Action, Action<T11> t11Action, Action<T12> t12Action, Action<T13> t13Action, Action<T14> t14Action, Action<T15> t15Action, Action<T16> t16Action)
        {
            if (Is(DUnionType.Of<T1>()))
                t1Action(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                t2Action(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                t3Action(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                t4Action(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                t5Action(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                t6Action(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                t7Action(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                t8Action(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                t9Action(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                t10Action(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                t11Action(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                t12Action(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                t13Action(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                t14Action(Get(DUnionType.Of<T14>()));
            else if (Is(DUnionType.Of<T15>()))
                t15Action(Get(DUnionType.Of<T15>()));
            else if (Is(DUnionType.Of<T16>()))
                t16Action(Get(DUnionType.Of<T16>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }

        public T Switch<T>(Func<T1, T> t1Func, Func<T2, T> t2Func, Func<T3, T> t3Func, Func<T4, T> t4Func, Func<T5, T> t5Func, Func<T6, T> t6Func, Func<T7, T> t7Func, Func<T8, T> t8Func, Func<T9, T> t9Func, Func<T10, T> t10Func, Func<T11, T> t11Func, Func<T12, T> t12Func, Func<T13, T> t13Func, Func<T14, T> t14Func, Func<T15, T> t15Func, Func<T16, T> t16Func)
        {
            if (Is(DUnionType.Of<T1>()))
                return t1Func(Get(DUnionType.Of<T1>()));
            else if (Is(DUnionType.Of<T2>()))
                return t2Func(Get(DUnionType.Of<T2>()));
            else if (Is(DUnionType.Of<T3>()))
                return t3Func(Get(DUnionType.Of<T3>()));
            else if (Is(DUnionType.Of<T4>()))
                return t4Func(Get(DUnionType.Of<T4>()));
            else if (Is(DUnionType.Of<T5>()))
                return t5Func(Get(DUnionType.Of<T5>()));
            else if (Is(DUnionType.Of<T6>()))
                return t6Func(Get(DUnionType.Of<T6>()));
            else if (Is(DUnionType.Of<T7>()))
                return t7Func(Get(DUnionType.Of<T7>()));
            else if (Is(DUnionType.Of<T8>()))
                return t8Func(Get(DUnionType.Of<T8>()));
            else if (Is(DUnionType.Of<T9>()))
                return t9Func(Get(DUnionType.Of<T9>()));
            else if (Is(DUnionType.Of<T10>()))
                return t10Func(Get(DUnionType.Of<T10>()));
            else if (Is(DUnionType.Of<T11>()))
                return t11Func(Get(DUnionType.Of<T11>()));
            else if (Is(DUnionType.Of<T12>()))
                return t12Func(Get(DUnionType.Of<T12>()));
            else if (Is(DUnionType.Of<T13>()))
                return t13Func(Get(DUnionType.Of<T13>()));
            else if (Is(DUnionType.Of<T14>()))
                return t14Func(Get(DUnionType.Of<T14>()));
            else if (Is(DUnionType.Of<T15>()))
                return t15Func(Get(DUnionType.Of<T15>()));
            else if (Is(DUnionType.Of<T16>()))
                return t16Func(Get(DUnionType.Of<T16>()));
            else
                throw new InvalidOperationException("This should not be possible.");
        }
    }
}

