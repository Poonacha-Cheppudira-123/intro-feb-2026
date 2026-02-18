import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-basics-home',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ` <p>This is the basics stuff!</p> `,
  styles: ``,
})
export class HomePage {}
