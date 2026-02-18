import { Component, ChangeDetectionStrategy, input, computed, output } from '@angular/core';

@Component({
  selector: 'app-basics-fizzbuzz',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    @switch (fizzBuzz()) {
      @case ('fizzbuzz') {
        <div>FizzBuzz!</div>
      }
      @case ('buzz') {
        <div>Buzz</div>
      }
      @case ('fizz') {
        <div>Fizz!</div>
      }
    }
  `,
  styles: ``,
})
export class Fizzbuzz {
  count = input.required<number>();
  fizzbuzzing = output<boolean>();

  fizzBuzz = computed(() => {
    const c = this.count();
    if (c === 0) {
      return `nada`;
    }
    if (c % 3 === 0 && c % 5 === 0) {
      this.fizzbuzzing.emit(true);
      return 'fizzbuzz';
    } else if (c % 3 === 0) {
      return 'fizz';
    } else if (c % 5 === 0) {
      return 'buzz';
    }
    return 'nada';
  });
}
