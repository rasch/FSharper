//{caret}
namespace XXX.YYY

type private A<'T> = List<'T>

namespace XXX1

type private A<'T> = System.Collections.Generic.Dictionary<'T, 'T>
type private A1<'T, 'T1> = System.Collections.Generic.Dictionary<'T, 'T1>

namespace global

type B = int