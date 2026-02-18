import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-profile-page',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: ` <p>This is the profile page</p> `,
  styles: ``,
})
export class Profile {}
