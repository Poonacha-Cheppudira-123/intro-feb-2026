import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { Fizzbuzz } from './pages/fizzbuzz';
import { CounterStore } from './counter-store';

// ./ ../
@Component({
  selector: 'app-basics-home',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterOutlet, RouterLink, Fizzbuzz],
  template: `
    <div class="flex flex-col items-center justify-center gap-4">
      <h2 class="text-2xl font-bold">Basic Stuff You Should Know About Angular</h2>
    </div>

    <div class="flex flex-row gap-4 mt-4">
      <a class="btn btn-neutral" routerLink="dashboard">Home</a>
      <a class="btn btn-neutral" routerLink="signals">Signals</a>
      <a class="btn btn-neutral" routerLink="resources">Resources Demo</a>
    </div>
    @if (store.fizzBuzz() !== 'nada') {
      <div class="alert alert-success">
        <app-basics-fizzbuzz />
      </div>
    }
    <router-outlet></router-outlet>
  `,
  styles: ``,
})
export class Home {
  store = inject(CounterStore);
}
