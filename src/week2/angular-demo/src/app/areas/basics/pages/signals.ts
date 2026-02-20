import { Component, ChangeDetectionStrategy, signal, computed, inject } from '@angular/core';
import { Fizzbuzz } from './fizzbuzz';
import { CounterStore } from '../counter-store';

@Component({
  selector: 'app-basics-signals',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [Fizzbuzz],
  template: `
    <div class="flex flex-row p-8 gap-4" [class.animate-pulse]="store.magic()">
      <button class="btn btn-md btn-warning btn-circle" (click)="store.decrement()">-</button>
      <span class="mx-2">{{ store.current() }}</span>
      <button class="btn btn-md btn-primary btn-circle" (click)="store.increment()">+</button>
      <button
        class="btn btn-sm btn-secondary"
        [disabled]="store.resetShouldBeDisabled()"
        (click)="store.reset()"
      >
        Reset
      </button>
    </div>
    <app-basics-fizzbuzz />
  `,
  styles: ``,
})
export class SignalsPage {
  store = inject(CounterStore);
}
