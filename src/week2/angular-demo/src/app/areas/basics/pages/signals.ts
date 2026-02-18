import { Component, ChangeDetectionStrategy, signal, computed, inject } from '@angular/core';
import { Fizzbuzz } from './fizzbuzz';
import { CounterStore } from '../counter-store';

@Component({
  selector: 'app-basics-signals',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [Fizzbuzz],
  template: `
    <div class="flex flex-row p-8 gap-4" [class.animate-pulse]="magic()">
      <button class="btn btn-sm btn-warning btn-circle" (click)="decrement()">-</button>
      <span class="mx-2">{{ current() }}</span>
      <button class="btn btn-sm btn-primary btn-circle" (click)="increment()">+</button>
      <button
        class="btn btn-sm btn-secondary"
        [disabled]="resetShouldBeDisabled()"
        (click)="current.set(0)"
      >
        Reset
      </button>
    </div>
    <app-basics-fizzbuzz [count]="current()" (fizzbuzzing)="magic.set(true)" />
  `,
  styles: ``,
})
export class SignalsPage {
  store = inject(CounterStore);
  current = signal(0);
  magic = signal(false);

  increment() {
    this.current.update((oldVal) => oldVal + 1);
  }

  decrement() {
    this.current.update((oldVal) => oldVal - 1);
  }

  resetShouldBeDisabled = computed(() => this.current() == 0);
}
