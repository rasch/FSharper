//{caret}
module X

type [<Serializable>] public A<'T, 'T1 when 'T :> System.Collections.Generic.IList<int> and 'T1 :struct> = System.Collections.Generic.Dictionary<'T, 'T1>
