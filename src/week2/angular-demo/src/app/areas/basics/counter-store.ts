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
  //   withComputed((store) => computed()),
);
