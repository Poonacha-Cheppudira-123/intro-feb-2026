import { Component, ChangeDetectionStrategy, input, computed, output, inject } from '@angular/core';
import { CounterStore } from '../counter-store';

@Component({
  selector: 'app-basics-fizzbuzz',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    @switch (store.fizzBuzz()) {
      @case ('fizzbuzz') {
        <div>FizzBuzz!</div>
      }
      @case ('fizz') {
        <div>Fizz!</div>
      }
      @case ('buzz') {
        <div>Buzz!</div>
      }
    }
  `,
  styles: ``,
})
export class Fizzbuzz {
  store = inject(CounterStore);

  fizzBuzz = computed(() => {});
  // 'fizz' | 'buzz' | 'fizzbuzz' | 'nada'
}
