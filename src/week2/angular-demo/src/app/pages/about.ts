import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-profile',
  imports: [],
  templateUrl: './about.html',
  styles: [],
})
export class About {
  name = signal('Jeff');
}
