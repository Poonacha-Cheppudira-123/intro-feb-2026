import { Component } from '@angular/core'; // allows you to create custom reusable UI elements
import { RouterOutlet } from '@angular/router'; // ?
import { Nav } from './nav/nav'; // Import Navigation Bar component from Nav Bar

// tells us how to create, render, style, and optimize a UI block
@Component({
  selector: 'app-root', // custom HTML tag in component: placed in index.html to render the component
  imports: [Nav, RouterOutlet], // import components that we want to use inside this component (Nav component + RouterOutlet)
  // Template Property => contains HTML that angular should render when the component is displayed.
  template: `
    <app-nav>
      <main class="container mx-auto pt-4">
        <router-outlet></router-outlet>
      </main>
    </app-nav>
  `,
  // Styles => takes an array of strings to attach inline CSS to a component
  styles: [],
})
export class App {}
