import { Component, ChangeDetectionStrategy } from '@angular/core';
import { PageLayout } from '@ht/shared/ui-common/layouts/page';

@Component({
  selector: 'ht-home-about',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [PageLayout],
  template: `
    <app-ui-page title="About the Starter Project">
      I use this starter and keep it up to date for my own projects. The link to the repo is here:
      <em>Coming Soon</em>. <em>PUT LINK HERE</em>.
    </app-ui-page>
  `,
  styles: ``,
})
export class AboutPage {}
