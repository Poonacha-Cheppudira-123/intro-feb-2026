import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Nav } from './nav/nav';

@Component({
  selector: 'app-root',
  imports: [Nav, RouterOutlet],
  template: `
    <app-nav>
      <main class="container mx-auto pt-4">
        <router-outlet></router-outlet>
      </main>
    </app-nav>
  `,
  styles: [],
})
export class App {}
