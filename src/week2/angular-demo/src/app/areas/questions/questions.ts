import { Component, ChangeDetectionStrategy, inject } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { QuestionStore } from './question-store';

@Component({
  selector: 'app-questions',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  template: `
    <div class="flex flex-col items-center justify-center gap-4">
      <h2 class="text-2xl font-bold">Questions and Answers!</h2>
    </div>

    <div class="flex flex-row gap-4 mt-4">
      <a class="btn btn-neutral" [routerLinkActive]="['active']" [routerLink]="['.']"
        >List of Open Questions</a
      >
      <a class="btn btn-neutral" [routerLinkActive]="['active']" [routerLink]="['ask']"
        >Ask A Question</a
      >
    </div>

    <router-outlet />
  `,
  styles: ``,
})
export class Questions {
  store = inject(QuestionStore);
}
