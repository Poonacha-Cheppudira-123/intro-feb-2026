import { computed } from '@angular/core';
import { patchState, signalStore, withComputed, withMethods, withState } from '@ngrx/signals';

type CounterState = {
  current: number;
  magic: boolean;
};

export const CounterStore = signalStore(
  withState<CounterState>({
    current: 0,
    magic: false,
  }),
  withMethods((store) => {
    return {
      increment: () => patchState(store, { current: store.current() + 1 }),
      decrement: () => patchState(store, { current: store.current() - 1 }),
      reset: () => patchState(store, { current: 0 }),
    };
  }),
  withComputed((store) => {
    return {
      resetShouldBeDisabled: computed(() => store.current() === 0),
      fizzBuzz: computed(() => {
        const c = store.current();
        if (c === 0) {
          return 'nada';
        }
        if (c % 3 === 0 && c % 5 === 0) {
          // this is bad, by the way - don't do this, but I waqnt you see it

          return 'fizzbuzz';
        } else if (c % 3 === 0) {
          return 'fizz';
        } else if (c % 5 === 0) {
          return 'buzz';
        }
        return 'nada';
      }),
    };
  }),
);
