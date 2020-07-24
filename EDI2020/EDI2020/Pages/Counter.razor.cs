using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Fluxor;
using Microsoft.AspNetCore.Components;
using EDI2020.Store.Counter;

namespace EDI2020.Pages
{
	public partial class Counter
	{
		[Inject]
		private IState<CounterState> CounterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            var action = new IncrementCounterAction();
            Dispatcher.Dispatch(action);
        }

        /* private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }*/

        private void GoHome()
        {
            nav.NavigateTo(uri: "/");
        }

    }
}
