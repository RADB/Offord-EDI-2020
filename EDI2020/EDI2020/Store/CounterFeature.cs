using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI2020.Store.Counter
{
    public class CounterFeature: Feature<CounterState>
    {   
        public override string GetName() => "Counter";
        protected override CounterState GetInitialState() => new CounterState(currentCount: 0);
    }

    public class CounterState
    {
        public int CurrentCount { get; }

        public CounterState(int currentCount)
        {
            CurrentCount = currentCount;
        }
    }

    public class IncrementCounterAction { }

    public static class Reducers
    {
        [ReducerMethod]
        public static CounterState Reduce(CounterState state, IncrementCounterAction action)
        {
            return new CounterState(currentCount: state.CurrentCount + 1);
        }
    }
}


